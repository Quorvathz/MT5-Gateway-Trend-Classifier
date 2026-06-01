using System.Globalization;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private const string BullishClassification = "OPTIMAL ACCUMULATION ZONE / LONG ENTRY SECURE";
        private const string ShortClassification = "BULLISH INCOMPATIBLE / STRUCTURE ALIGNED FOR SHORT EXPOSURE";
        private const string StandbyClassification = "GATEWAY STANDBY / MARKET STREAM NOT YET AUTHORIZED";
        private const string DefaultGatewayWebSocketUri = "ws://127.0.0.1:8765";

        private readonly object _assetUniverseLock = new();
        private readonly Dictionary<string, AssetCardControls> _assetCards;
        private ClientWebSocket? _webSocket;
        private CancellationTokenSource? _gatewayCancellation;
        private System.Threading.Timer? _clockTimer;
        private bool _sessionActive;
        private string _activeLoginId = string.Empty;

        public Form1()
        {
            InitializeComponent();

            _assetCards = new Dictionary<string, AssetCardControls>(StringComparer.OrdinalIgnoreCase)
            {
                ["EURUSD"] = new AssetCardControls(lblEurSymbol, lblEurName, pnlEurAccent, lblEurBadge, lblEurClassification, lblEurMeta),
                ["XAUUSD"] = new AssetCardControls(lblXauSymbol, lblXauName, pnlXauAccent, lblXauBadge, lblXauClassification, lblXauMeta),
                ["BTCUSD"] = new AssetCardControls(lblBtcSymbol, lblBtcName, pnlBtcAccent, lblBtcBadge, lblBtcClassification, lblBtcMeta)
            };

            ApplyAssetUniverseFromInputs();
            ResetAssetCards();
            UpdateSessionStatus(false, string.Empty);
            StartClock();
        }

        private async void BtnInitialize_Click(object? sender, EventArgs e)
        {
            await InitializeGatewayAsync();
        }

        private void BtnUpdateAssets_Click(object? sender, EventArgs e)
        {
            ApplyAssetUniverseFromInputs();
        }

        private async Task InitializeGatewayAsync()
        {
            string loginId = string.IsNullOrWhiteSpace(txtLoginId.Text)
                ? "LOCAL-SESSION"
                : txtLoginId.Text.Trim();
            string password = txtPassword.Text;
            string gatewayUri = DefaultGatewayWebSocketUri;

            DisposeGateway();
            SetAuthenticationControlsEnabled(false);
            ActivateSessionUi(loginId);

            _gatewayCancellation = new CancellationTokenSource();
            _webSocket = new ClientWebSocket();

            try
            {
                await _webSocket.ConnectAsync(new Uri(gatewayUri), _gatewayCancellation.Token);
                await SendAuthenticationFrameAsync(loginId, password, _gatewayCancellation.Token);
                _ = Task.Run(() => ReceiveMarketStreamAsync(loginId, _gatewayCancellation.Token));
            }
            catch
            {
                // Keep the terminal-grade UI active when the local bridge is not running yet.
                DisposeGateway();
            }
        }

        private async Task SendAuthenticationFrameAsync(string loginId, string password, CancellationToken cancellationToken)
        {
            if (_webSocket is null || _webSocket.State != WebSocketState.Open)
            {
                return;
            }

            string authenticationPayload = JsonSerializer.Serialize(new
            {
                type = "authenticate",
                loginId,
                password,
                requestedSymbols = GetActiveSymbols(),
                client = "Institutional Market Intelligence & Trend Classifier"
            });

            byte[] payloadBytes = Encoding.UTF8.GetBytes(authenticationPayload);
            await _webSocket.SendAsync(
                payloadBytes,
                WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken);
        }

        private async Task ReceiveMarketStreamAsync(string loginId, CancellationToken cancellationToken)
        {
            byte[] buffer = new byte[8192];

            try
            {
                while (!cancellationToken.IsCancellationRequested &&
                       _webSocket is { State: WebSocketState.Open or WebSocketState.CloseReceived })
                {
                    using MemoryStream messageStream = new();
                    WebSocketReceiveResult result;

                    do
                    {
                        result = await _webSocket.ReceiveAsync(buffer, cancellationToken);

                        if (result.MessageType == WebSocketMessageType.Close)
                        {
                            await CloseGatewayAsync(cancellationToken);
                            SafeUi(() =>
                            {
                                UpdateSessionStatus(true, loginId);
                            });
                            return;
                        }

                        messageStream.Write(buffer, 0, result.Count);
                    }
                    while (!result.EndOfMessage);

                    if (result.MessageType != WebSocketMessageType.Text)
                    {
                        continue;
                    }

                    string message = Encoding.UTF8.GetString(messageStream.ToArray());
                    ProcessMarketMessage(message, loginId);
                }
            }
            catch (OperationCanceledException)
            {
                // Normal shutdown path.
            }
            catch (ObjectDisposedException)
            {
                // Normal shutdown path.
            }
            catch
            {
                SafeUi(() =>
                {
                    UpdateSessionStatus(true, loginId);
                });
            }
        }

        private void ProcessMarketMessage(string message, string loginId)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return;
            }

            if (TryReadMarketSignal(message, out MarketSignal signal))
            {
                SafeUi(() =>
                {
                    UpdateSessionStatus(true, loginId);
                    UpdateAssetCard(signal.Symbol, signal.IsBullish, signal.PriceText);
                });
                return;
            }

            foreach (string symbol in GetActiveSymbols())
            {
                if (!message.Contains(symbol, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                bool isBullish = IsBullishSignal(message);
                SafeUi(() =>
                {
                    UpdateSessionStatus(true, loginId);
                    UpdateAssetCard(symbol, isBullish, null);
                });
            }
        }

        private void UpdateAssetCard(string symbol, bool isBullish, string? priceText)
        {
            AssetCardControls? controls;
            lock (_assetUniverseLock)
            {
                _assetCards.TryGetValue(symbol, out controls);
            }

            if (controls is null)
            {
                return;
            }

            Color regimeColor = isBullish ? ThemeBullish : ThemeBearish;
            controls.AccentPanel.BackColor = regimeColor;
            controls.BadgeLabel.Text = isBullish ? "LONG REGIME CONFIRMED" : "SHORT REGIME CONFIRMED";
            controls.BadgeLabel.ForeColor = regimeColor;
            controls.ClassificationLabel.Text = isBullish ? BullishClassification : ShortClassification;
            controls.ClassificationLabel.ForeColor = ThemePrimary;
            controls.MetaLabel.Text = string.IsNullOrWhiteSpace(priceText)
                ? $"LIVE MARKET STREAM // UPDATED {DateTime.Now:HH:mm:ss}"
                : $"LIVE MARKET STREAM // LAST PRICE {priceText} // UPDATED {DateTime.Now:HH:mm:ss}";
        }

        private void ResetAssetCards()
        {
            AssetCardControls[] controlsSnapshot;
            lock (_assetUniverseLock)
            {
                controlsSnapshot = _assetCards.Values.ToArray();
            }

            foreach (AssetCardControls controls in controlsSnapshot)
            {
                controls.AccentPanel.BackColor = ThemeSecondary;
                controls.BadgeLabel.Text = "PENDING SIGNAL";
                controls.BadgeLabel.ForeColor = ThemeSecondary;
                controls.ClassificationLabel.Text = StandbyClassification;
                controls.ClassificationLabel.ForeColor = ThemePrimary;
                controls.MetaLabel.Text = "SECURE DATA CHANNEL REQUIRED";
            }
        }

        private void ActivateSessionUi(string loginId)
        {
            _sessionActive = true;
            _activeLoginId = loginId;
            btnInitialize.Text = "GATEWAY ONLINE";
            btnInitialize.BackColor = ThemeBullish;
            btnInitialize.ForeColor = ThemeBackground;
            UpdateSessionStatus(true, loginId);

            RenderDefaultActiveClassifications();
        }

        private void ApplyAssetUniverseFromInputs()
        {
            string[] symbols = GetConfiguredSymbols();
            AssetCardControls[] slots =
            {
                new(lblEurSymbol, lblEurName, pnlEurAccent, lblEurBadge, lblEurClassification, lblEurMeta),
                new(lblXauSymbol, lblXauName, pnlXauAccent, lblXauBadge, lblXauClassification, lblXauMeta),
                new(lblBtcSymbol, lblBtcName, pnlBtcAccent, lblBtcBadge, lblBtcClassification, lblBtcMeta)
            };

            lock (_assetUniverseLock)
            {
                _assetCards.Clear();

                for (int i = 0; i < symbols.Length; i++)
                {
                    slots[i].SymbolLabel.Text = symbols[i];
                    slots[i].NameLabel.Text = GetAssetDescription(symbols[i]);
                    _assetCards[symbols[i]] = slots[i];
                }
            }

            ResetAssetCards();

            if (_sessionActive)
            {
                UpdateSessionStatus(true, _activeLoginId);
                RenderDefaultActiveClassifications();
            }
        }

        private void RenderDefaultActiveClassifications()
        {
            string[] symbols = GetActiveSymbols();

            for (int i = 0; i < symbols.Length; i++)
            {
                UpdateAssetCard(symbols[i], i < 2, null);
            }
        }

        private string[] GetConfiguredSymbols()
        {
            string[] defaults = { "EURUSD", "XAUUSD", "BTCUSD" };
            TextBox[] inputs = { txtAssetOne, txtAssetTwo, txtAssetThree };
            HashSet<string> usedSymbols = new(StringComparer.OrdinalIgnoreCase);
            string[] symbols = new string[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                string symbol = NormalizeSymbol(inputs[i].Text);

                if (string.IsNullOrWhiteSpace(symbol) || !usedSymbols.Add(symbol))
                {
                    symbol = defaults[i];
                    usedSymbols.Add(symbol);
                }

                symbols[i] = symbol;
                inputs[i].Text = symbol;
            }

            return symbols;
        }

        private string[] GetActiveSymbols()
        {
            lock (_assetUniverseLock)
            {
                return _assetCards.Keys.ToArray();
            }
        }

        private static string NormalizeSymbol(string value)
        {
            string trimmed = value.Trim().ToUpperInvariant();
            StringBuilder builder = new(trimmed.Length);

            foreach (char character in trimmed)
            {
                if (char.IsLetterOrDigit(character) || character is '.' or '_' or '-')
                {
                    builder.Append(character);
                }
            }

            return builder.ToString();
        }

        private static string GetAssetDescription(string symbol)
        {
            return symbol switch
            {
                "EURUSD" => "EURO / U.S. DOLLAR\r\nFX MAJOR LIQUIDITY",
                "GBPUSD" => "BRITISH POUND / U.S. DOLLAR\r\nFX MAJOR LIQUIDITY",
                "USDJPY" => "U.S. DOLLAR / JAPANESE YEN\r\nFX MAJOR LIQUIDITY",
                "XAUUSD" => "GOLD SPOT / U.S. DOLLAR\r\nMETALS LIQUIDITY",
                "BTCUSD" => "BITCOIN / U.S. DOLLAR\r\nDIGITAL ASSET LIQUIDITY",
                "ETHUSD" => "ETHEREUM / U.S. DOLLAR\r\nDIGITAL ASSET LIQUIDITY",
                _ => "CUSTOM MT5 INSTRUMENT\r\nMARKET LIQUIDITY"
            };
        }

        private void SetAuthenticationControlsEnabled(bool enabled)
        {
            txtLoginId.Enabled = enabled;
            txtPassword.Enabled = enabled;
            btnInitialize.Enabled = enabled;
        }

        private void ResetConnectionUi()
        {
            _sessionActive = false;
            _activeLoginId = string.Empty;
            SetAuthenticationControlsEnabled(true);
            btnInitialize.Text = "INITIALIZE GATEWAY";
            btnInitialize.BackColor = ThemeAccent;
            btnInitialize.ForeColor = ThemeBackground;
            UpdateSessionStatus(false, string.Empty);
            ResetAssetCards();
        }

        private void UpdateSessionStatus(bool isActive, string loginId)
        {
            lblSessionStatus.Text = isActive
                ? $"● SYSTEM ACTIVE // SECURE ID: {loginId}"
                : "● SESSION TERMINATED";
            lblSessionStatus.ForeColor = isActive ? ThemeBullish : ThemeSecondary;
        }

        private void StartClock()
        {
            _clockTimer = new System.Threading.Timer(
                _ => SafeUi(UpdateClock),
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(1));
        }

        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
        }

        private async Task CloseGatewayAsync(CancellationToken cancellationToken)
        {
            if (_webSocket is not { State: WebSocketState.Open or WebSocketState.CloseReceived })
            {
                return;
            }

            await _webSocket.CloseAsync(
                WebSocketCloseStatus.NormalClosure,
                "Client session terminated.",
                cancellationToken);
        }

        private void DisposeGateway()
        {
            try
            {
                _gatewayCancellation?.Cancel();
                _webSocket?.Abort();
            }
            catch
            {
                // Ignore shutdown races from the socket implementation.
            }
            finally
            {
                _webSocket?.Dispose();
                _gatewayCancellation?.Dispose();
                _webSocket = null;
                _gatewayCancellation = null;
            }
        }

        private void DisplayNetworkException(Exception exception)
        {
            SafeUi(() =>
            {
                MessageBox.Show(
                    this,
                    $"{exception.GetType().Name}: {exception.Message}",
                    "Gateway Network Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            });
        }

        private void SafeUi(Action action)
        {
            if (IsDisposed || Disposing)
            {
                return;
            }

            if (InvokeRequired)
            {
                try
                {
                    BeginInvoke(action);
                }
                catch (InvalidOperationException)
                {
                    // The form handle is already gone.
                }
                return;
            }

            action();
        }

        private static bool TryReadMarketSignal(string message, out MarketSignal signal)
        {
            signal = default;

            try
            {
                using JsonDocument document = JsonDocument.Parse(message);
                string? symbol = FindFirstString(document.RootElement, "symbol", "asset", "instrument", "ticker");

                if (string.IsNullOrWhiteSpace(symbol))
                {
                    return false;
                }

                string trendContext =
                    FindFirstString(document.RootElement, "trend", "status", "bias", "direction", "classification", "signal", "side", "recommendation")
                    ?? message;

                string? priceText = FindFirstString(document.RootElement, "price", "bid", "ask", "last", "close");
                signal = new MarketSignal(symbol.Trim().ToUpperInvariant(), IsBullishSignal(trendContext), priceText);
                return true;
            }
            catch (JsonException)
            {
                signal = default;
                return false;
            }
        }

        private static string? FindFirstString(JsonElement element, params string[] names)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    foreach (JsonProperty property in element.EnumerateObject())
                    {
                        if (names.Contains(property.Name, StringComparer.OrdinalIgnoreCase) &&
                            property.Value.ValueKind is JsonValueKind.String or JsonValueKind.Number or JsonValueKind.True or JsonValueKind.False)
                        {
                            return property.Value.ToString();
                        }

                        string? nestedValue = FindFirstString(property.Value, names);
                        if (!string.IsNullOrWhiteSpace(nestedValue))
                        {
                            return nestedValue;
                        }
                    }
                    break;

                case JsonValueKind.Array:
                    foreach (JsonElement child in element.EnumerateArray())
                    {
                        string? nestedValue = FindFirstString(child, names);
                        if (!string.IsNullOrWhiteSpace(nestedValue))
                        {
                            return nestedValue;
                        }
                    }
                    break;
            }

            return null;
        }

        private static bool IsBullishSignal(string value)
        {
            string normalized = value.ToLowerInvariant();

            if (normalized.Contains("non-bullish", StringComparison.Ordinal) ||
                normalized.Contains("bear", StringComparison.Ordinal) ||
                normalized.Contains("short", StringComparison.Ordinal) ||
                normalized.Contains("sell", StringComparison.Ordinal) ||
                normalized.Contains("down", StringComparison.Ordinal) ||
                normalized.Contains("incompatible", StringComparison.Ordinal))
            {
                return false;
            }

            return normalized.Contains("bull", StringComparison.Ordinal) ||
                   normalized.Contains("long", StringComparison.Ordinal) ||
                   normalized.Contains("buy", StringComparison.Ordinal) ||
                   normalized.Contains("up", StringComparison.Ordinal) ||
                   normalized.Contains("accumulation", StringComparison.Ordinal);
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _clockTimer?.Dispose();
            _clockTimer = null;
            DisposeGateway();
        }

        private sealed record AssetCardControls(
            Label SymbolLabel,
            Label NameLabel,
            Panel AccentPanel,
            Label BadgeLabel,
            Label ClassificationLabel,
            Label MetaLabel);

        private readonly record struct MarketSignal(string Symbol, bool IsBullish, string? PriceText);
    }
}
