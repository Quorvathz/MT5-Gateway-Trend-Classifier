<div align="center">

Topics: metatrader5, mql5, market-regime, expert-advisor, mql4, metatrader, forex-trading, indicators, technical-analysis, market-analysis, trend-analysis, market-structure, forex-analysis, mt4, mt5, trading-bot, mt5-trend-classifier, market-regime-detector, mt5-gateway-dashboard

# Institutional Market Trend Classifier

**A terminal-grade .NET WinForms dashboard that classifies live market structure across selected MT5 instruments. It combines secure gateway authentication, configurable asset universe inputs, and bold classification cards for bullish, bearish, long, and short market regimes.**

<br>

[![Stars](https://img.shields.io/badge/Stars-Repository-00D4AA?style=for-the-badge)](https://github.com/your-username/volume-profile-mt5/stargazers)
[![Forks](https://img.shields.io/badge/Forks-Community-4D9FFF?style=for-the-badge)](https://github.com/your-username/volume-profile-mt5/network)
[![Issues](https://img.shields.io/badge/Issues-Tracker-FF4D6A?style=for-the-badge)](https://github.com/your-username/volume-profile-mt5/issues)
[![Platform](https://img.shields.io/badge/Platform-MetaTrader%205-00D4AA?style=for-the-badge)](https://www.metatrader5.com)
[![License](https://img.shields.io/badge/License-MIT-4D9FFF?style=for-the-badge)](LICENSE)
</div>

---

## Screenshot

<img width="1229" height="785" alt="Screenshot_2" src="https://github.com/user-attachments/assets/457ccb75-62f5-4322-9c4e-79dded91cc0d" />

---

## 🎬 Demo

<div align="center">

<img src="https://i.imgur.com/utOhm6Z.gif" alt="Demo">

</div>





---

## Why This Project

Trading operators often need a quick answer: which assets are aligned for long exposure, which ones are aligned for short exposure, and which streams are still waiting for confirmation. **Institutional Market Trend Classifier** turns that idea into a focused desktop terminal.

It is designed for:

- MT5 market intelligence dashboards
- Trend regime classification demos
- Forex, metals, and crypto analysis tools
- WebSocket market stream prototypes
- Professional WinForms UI showcases

---

## What It Does

| Module | Description |
|---|---|
| Secure Access Layer | Starts an authenticated local gateway session |
| Asset Universe Inputs | Lets the operator define three active MT5 symbols |
| Classification Cards | Shows regime state for each selected asset |
| Market Stream Parser | Reads JSON or text-based trend payloads |
| Session Status | Displays active gateway identity and live clock |
| Fallback Rendering | Keeps classification cards active even without a running bridge |

---

## Feature Highlights

| Feature | Detail |
|---|---|
| Institutional Dark Theme | Graphite panels, cyan accents, and high contrast classification text |
| Configurable Symbols | Replace default EURUSD, XAUUSD, and BTCUSD with custom MT5 instruments |
| Gateway Authentication | Sends login ID, password, requested symbols, and client identity |
| Smart Text Parsing | Detects bullish, long, buy, bearish, short, sell, and incompatible language |
| JSON Search | Recursively scans nested payloads for symbol, trend, bias, direction, signal, side, and price |
| Session Lifecycle | Cleans up timers and WebSocket resources on form close |

---

## Classification Logic

```text
Market message
   |
   v
Find symbol + trend context
   |
   +-- bull / long / buy / up / accumulation
   |       -> LONG REGIME CONFIRMED
   |
   +-- bear / short / sell / down / incompatible
           -> SHORT REGIME CONFIRMED
```

The default card labels are built around fast operator reading:

```text
LONG  -> OPTIMAL ACCUMULATION ZONE / LONG ENTRY SECURE
SHORT -> BULLISH INCOMPATIBLE / STRUCTURE ALIGNED FOR SHORT EXPOSURE
WAIT  -> GATEWAY STANDBY / MARKET STREAM NOT YET AUTHORIZED
```

---

## Gateway Payload

Example JSON payload:

```json
{
  "symbol": "BTCUSD",
  "classification": "bullish accumulation",
  "price": "68250.00"
}
```

The parser also accepts nested objects and common property names:

```text
symbol, asset, instrument, ticker
trend, status, bias, direction, classification, signal, side, recommendation
price, bid, ask, last, close
```

---

## Quick Start

**Requirements:**

- Windows 10 or Windows 11
- .NET 8 SDK
- Visual Studio 2022

```bash
git clone https://github.com/your-username/institutional-market-trend-classifier.git
cd institutional-market-trend-classifier
```

Open `WinFormsApp3.slnx` in Visual Studio and press **F5**.

---

## How to Use

1. Launch the application.
2. Enter an MT5 login ID and password.
3. Set three symbols in the asset universe fields.
4. Click **UPDATE ASSET UNIVERSE** when symbols change.
5. Click **INITIALIZE GATEWAY**.
6. Feed JSON or text signals into the local bridge.
7. Watch each card classify the current market regime.

---

## Roadmap

- [x] Secure gateway panel
- [x] Three-asset classification grid
- [x] Recursive JSON signal parser
- [x] Custom symbol inputs
- [ ] Add confidence percentage per card
- [ ] Add historical classification timeline
- [ ] Add exportable session logs
- [ ] Add advanced MT5 bridge guide

---

## License

MIT

---

<div align="center">

Institutional Market Trend Classifier - Secure MT5 Market Regime Dashboard

</div>
