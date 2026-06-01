namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private static readonly Color ThemeBackground = ColorTranslator.FromHtml("#0B0B0D");
        private static readonly Color ThemeGraphite = ColorTranslator.FromHtml("#141417");
        private static readonly Color ThemeInput = ColorTranslator.FromHtml("#0F0F12");
        private static readonly Color ThemePrimary = ColorTranslator.FromHtml("#F3F4F6");
        private static readonly Color ThemeSecondary = ColorTranslator.FromHtml("#71717A");
        private static readonly Color ThemeAccent = ColorTranslator.FromHtml("#06B6D4");
        private static readonly Color ThemeBullish = ColorTranslator.FromHtml("#10B981");
        private static readonly Color ThemeBearish = ColorTranslator.FromHtml("#EF4444");

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            rootLayout = new Panel();
            authenticationPanel = new Panel();
            authContentPanel = new Panel();
            lblSecureAccess = new Label();
            lblAuthTitle = new Label();
            lblAuthSubtitle = new Label();
            lblLogin = new Label();
            pnlLoginInput = new Panel();
            txtLoginId = new TextBox();
            lblPassword = new Label();
            pnlPasswordInput = new Panel();
            txtPassword = new TextBox();
            lblAssetUniverse = new Label();
            lblAssetUniverseHint = new Label();
            pnlAssetOneInput = new Panel();
            txtAssetOne = new TextBox();
            pnlAssetTwoInput = new Panel();
            txtAssetTwo = new TextBox();
            pnlAssetThreeInput = new Panel();
            txtAssetThree = new TextBox();
            btnUpdateAssets = new Button();
            btnInitialize = new Button();
            pnlAuthFooter = new Panel();
            lblAuthFooter = new Label();
            mainPanel = new Panel();
            headerPanel = new Panel();
            lblDashboardKicker = new Label();
            lblDashboardTitle = new Label();
            lblDashboardSubtitle = new Label();
            assetGrid = new TableLayoutPanel();
            pnlEurCard = new Panel();
            pnlEurAccent = new Panel();
            lblEurSymbol = new Label();
            lblEurName = new Label();
            lblEurBadge = new Label();
            lblEurClassification = new Label();
            lblEurMeta = new Label();
            pnlXauCard = new Panel();
            pnlXauAccent = new Panel();
            lblXauSymbol = new Label();
            lblXauName = new Label();
            lblXauBadge = new Label();
            lblXauClassification = new Label();
            lblXauMeta = new Label();
            pnlBtcCard = new Panel();
            pnlBtcAccent = new Panel();
            lblBtcSymbol = new Label();
            lblBtcName = new Label();
            lblBtcBadge = new Label();
            lblBtcClassification = new Label();
            lblBtcMeta = new Label();
            footerPanel = new Panel();
            lblClock = new Label();
            lblSessionStatus = new Label();
            rootLayout.SuspendLayout();
            authenticationPanel.SuspendLayout();
            authContentPanel.SuspendLayout();
            pnlLoginInput.SuspendLayout();
            pnlPasswordInput.SuspendLayout();
            pnlAssetOneInput.SuspendLayout();
            pnlAssetTwoInput.SuspendLayout();
            pnlAssetThreeInput.SuspendLayout();
            pnlAuthFooter.SuspendLayout();
            mainPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            assetGrid.SuspendLayout();
            pnlEurCard.SuspendLayout();
            pnlXauCard.SuspendLayout();
            pnlBtcCard.SuspendLayout();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.BackColor = ThemeBackground;
            rootLayout.Controls.Add(mainPanel);
            rootLayout.Controls.Add(authenticationPanel);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(24);
            rootLayout.Size = new Size(1240, 760);
            rootLayout.TabIndex = 0;
            // 
            // authenticationPanel
            // 
            authenticationPanel.BackColor = ThemeGraphite;
            authenticationPanel.Controls.Add(authContentPanel);
            authenticationPanel.Dock = DockStyle.Left;
            authenticationPanel.Location = new Point(24, 24);
            authenticationPanel.Name = "authenticationPanel";
            authenticationPanel.Padding = new Padding(24);
            authenticationPanel.Size = new Size(344, 712);
            authenticationPanel.TabIndex = 0;
            // 
            // authContentPanel
            // 
            authContentPanel.BackColor = ThemeGraphite;
            authContentPanel.Controls.Add(pnlAuthFooter);
            authContentPanel.Controls.Add(btnInitialize);
            authContentPanel.Controls.Add(btnUpdateAssets);
            authContentPanel.Controls.Add(pnlAssetThreeInput);
            authContentPanel.Controls.Add(pnlAssetTwoInput);
            authContentPanel.Controls.Add(pnlAssetOneInput);
            authContentPanel.Controls.Add(lblAssetUniverseHint);
            authContentPanel.Controls.Add(lblAssetUniverse);
            authContentPanel.Controls.Add(pnlPasswordInput);
            authContentPanel.Controls.Add(lblPassword);
            authContentPanel.Controls.Add(pnlLoginInput);
            authContentPanel.Controls.Add(lblLogin);
            authContentPanel.Controls.Add(lblAuthSubtitle);
            authContentPanel.Controls.Add(lblAuthTitle);
            authContentPanel.Controls.Add(lblSecureAccess);
            authContentPanel.Dock = DockStyle.Fill;
            authContentPanel.Location = new Point(24, 24);
            authContentPanel.Name = "authContentPanel";
            authContentPanel.Size = new Size(296, 664);
            authContentPanel.TabIndex = 0;
            // 
            // lblSecureAccess
            // 
            lblSecureAccess.AutoSize = true;
            lblSecureAccess.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblSecureAccess.ForeColor = ThemeAccent;
            lblSecureAccess.Location = new Point(0, 4);
            lblSecureAccess.Name = "lblSecureAccess";
            lblSecureAccess.Size = new Size(135, 13);
            lblSecureAccess.TabIndex = 0;
            lblSecureAccess.Text = "SECURE ACCESS LAYER";
            // 
            // lblAuthTitle
            // 
            lblAuthTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblAuthTitle.ForeColor = ThemePrimary;
            lblAuthTitle.Location = new Point(0, 34);
            lblAuthTitle.Name = "lblAuthTitle";
            lblAuthTitle.Size = new Size(276, 82);
            lblAuthTitle.TabIndex = 1;
            lblAuthTitle.Text = "MT5 Gateway Authentication";
            // 
            // lblAuthSubtitle
            // 
            lblAuthSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblAuthSubtitle.ForeColor = ThemeSecondary;
            lblAuthSubtitle.Location = new Point(0, 122);
            lblAuthSubtitle.Name = "lblAuthSubtitle";
            lblAuthSubtitle.Size = new Size(276, 48);
            lblAuthSubtitle.TabIndex = 2;
            lblAuthSubtitle.Text = "Initialize a secured local WebSocket bridge before institutional market stream analysis begins.";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblLogin.ForeColor = ThemeSecondary;
            lblLogin.Location = new Point(0, 204);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(76, 13);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "MT5 LOGIN ID";
            // 
            // pnlLoginInput
            // 
            pnlLoginInput.BackColor = ThemeInput;
            pnlLoginInput.Controls.Add(txtLoginId);
            pnlLoginInput.Location = new Point(0, 224);
            pnlLoginInput.Name = "pnlLoginInput";
            pnlLoginInput.Padding = new Padding(12, 8, 12, 0);
            pnlLoginInput.Size = new Size(296, 42);
            pnlLoginInput.TabIndex = 4;
            // 
            // txtLoginId
            // 
            txtLoginId.BackColor = ThemeInput;
            txtLoginId.BorderStyle = BorderStyle.None;
            txtLoginId.Dock = DockStyle.Fill;
            txtLoginId.Font = new Font("Segoe UI", 10F);
            txtLoginId.ForeColor = ThemePrimary;
            txtLoginId.Location = new Point(12, 8);
            txtLoginId.Name = "txtLoginId";
            txtLoginId.PlaceholderText = "Enter institutional account ID";
            txtLoginId.Size = new Size(272, 18);
            txtLoginId.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPassword.ForeColor = ThemeSecondary;
            lblPassword.Location = new Point(0, 286);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 13);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "PASSWORD";
            // 
            // pnlPasswordInput
            // 
            pnlPasswordInput.BackColor = ThemeInput;
            pnlPasswordInput.Controls.Add(txtPassword);
            pnlPasswordInput.Location = new Point(0, 306);
            pnlPasswordInput.Name = "pnlPasswordInput";
            pnlPasswordInput.Padding = new Padding(12, 8, 12, 0);
            pnlPasswordInput.Size = new Size(296, 42);
            pnlPasswordInput.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = ThemeInput;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = ThemePrimary;
            txtPassword.Location = new Point(12, 8);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter secure password";
            txtPassword.Size = new Size(272, 18);
            txtPassword.TabIndex = 0;
            // 
            // lblAssetUniverse
            // 
            lblAssetUniverse.AutoSize = true;
            lblAssetUniverse.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAssetUniverse.ForeColor = ThemeAccent;
            lblAssetUniverse.Location = new Point(0, 374);
            lblAssetUniverse.Name = "lblAssetUniverse";
            lblAssetUniverse.Size = new Size(93, 13);
            lblAssetUniverse.TabIndex = 7;
            lblAssetUniverse.Text = "ASSET UNIVERSE";
            // 
            // lblAssetUniverseHint
            // 
            lblAssetUniverseHint.Font = new Font("Segoe UI", 8.25F);
            lblAssetUniverseHint.ForeColor = ThemeSecondary;
            lblAssetUniverseHint.Location = new Point(0, 394);
            lblAssetUniverseHint.Name = "lblAssetUniverseHint";
            lblAssetUniverseHint.Size = new Size(296, 18);
            lblAssetUniverseHint.TabIndex = 8;
            lblAssetUniverseHint.Text = "Define three MT5 symbols for classification.";
            // 
            // pnlAssetOneInput
            // 
            pnlAssetOneInput.BackColor = ThemeInput;
            pnlAssetOneInput.Controls.Add(txtAssetOne);
            pnlAssetOneInput.Location = new Point(0, 424);
            pnlAssetOneInput.Name = "pnlAssetOneInput";
            pnlAssetOneInput.Padding = new Padding(10, 8, 10, 0);
            pnlAssetOneInput.Size = new Size(90, 38);
            pnlAssetOneInput.TabIndex = 9;
            // 
            // txtAssetOne
            // 
            txtAssetOne.BackColor = ThemeInput;
            txtAssetOne.BorderStyle = BorderStyle.None;
            txtAssetOne.CharacterCasing = CharacterCasing.Upper;
            txtAssetOne.Dock = DockStyle.Fill;
            txtAssetOne.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            txtAssetOne.ForeColor = ThemePrimary;
            txtAssetOne.Location = new Point(10, 8);
            txtAssetOne.MaxLength = 16;
            txtAssetOne.Name = "txtAssetOne";
            txtAssetOne.Size = new Size(70, 17);
            txtAssetOne.TabIndex = 0;
            txtAssetOne.Text = "EURUSD";
            txtAssetOne.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlAssetTwoInput
            // 
            pnlAssetTwoInput.BackColor = ThemeInput;
            pnlAssetTwoInput.Controls.Add(txtAssetTwo);
            pnlAssetTwoInput.Location = new Point(103, 424);
            pnlAssetTwoInput.Name = "pnlAssetTwoInput";
            pnlAssetTwoInput.Padding = new Padding(10, 8, 10, 0);
            pnlAssetTwoInput.Size = new Size(90, 38);
            pnlAssetTwoInput.TabIndex = 10;
            // 
            // txtAssetTwo
            // 
            txtAssetTwo.BackColor = ThemeInput;
            txtAssetTwo.BorderStyle = BorderStyle.None;
            txtAssetTwo.CharacterCasing = CharacterCasing.Upper;
            txtAssetTwo.Dock = DockStyle.Fill;
            txtAssetTwo.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            txtAssetTwo.ForeColor = ThemePrimary;
            txtAssetTwo.Location = new Point(10, 8);
            txtAssetTwo.MaxLength = 16;
            txtAssetTwo.Name = "txtAssetTwo";
            txtAssetTwo.Size = new Size(70, 17);
            txtAssetTwo.TabIndex = 0;
            txtAssetTwo.Text = "XAUUSD";
            txtAssetTwo.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlAssetThreeInput
            // 
            pnlAssetThreeInput.BackColor = ThemeInput;
            pnlAssetThreeInput.Controls.Add(txtAssetThree);
            pnlAssetThreeInput.Location = new Point(206, 424);
            pnlAssetThreeInput.Name = "pnlAssetThreeInput";
            pnlAssetThreeInput.Padding = new Padding(10, 8, 10, 0);
            pnlAssetThreeInput.Size = new Size(90, 38);
            pnlAssetThreeInput.TabIndex = 11;
            // 
            // txtAssetThree
            // 
            txtAssetThree.BackColor = ThemeInput;
            txtAssetThree.BorderStyle = BorderStyle.None;
            txtAssetThree.CharacterCasing = CharacterCasing.Upper;
            txtAssetThree.Dock = DockStyle.Fill;
            txtAssetThree.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            txtAssetThree.ForeColor = ThemePrimary;
            txtAssetThree.Location = new Point(10, 8);
            txtAssetThree.MaxLength = 16;
            txtAssetThree.Name = "txtAssetThree";
            txtAssetThree.Size = new Size(70, 17);
            txtAssetThree.TabIndex = 0;
            txtAssetThree.Text = "BTCUSD";
            txtAssetThree.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUpdateAssets
            // 
            btnUpdateAssets.BackColor = ThemeGraphite;
            btnUpdateAssets.Cursor = Cursors.Hand;
            btnUpdateAssets.FlatAppearance.BorderColor = ThemeAccent;
            btnUpdateAssets.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 145, 178);
            btnUpdateAssets.FlatAppearance.MouseOverBackColor = ThemeInput;
            btnUpdateAssets.FlatStyle = FlatStyle.Flat;
            btnUpdateAssets.Font = new Font("Segoe UI Semibold", 8.75F, FontStyle.Bold);
            btnUpdateAssets.ForeColor = ThemeAccent;
            btnUpdateAssets.Location = new Point(0, 476);
            btnUpdateAssets.Name = "btnUpdateAssets";
            btnUpdateAssets.Size = new Size(296, 38);
            btnUpdateAssets.TabIndex = 12;
            btnUpdateAssets.Text = "UPDATE SYMBOLS";
            btnUpdateAssets.UseVisualStyleBackColor = false;
            btnUpdateAssets.Click += BtnUpdateAssets_Click;
            // 
            // btnInitialize
            // 
            btnInitialize.BackColor = ThemeAccent;
            btnInitialize.Cursor = Cursors.Hand;
            btnInitialize.FlatAppearance.BorderSize = 0;
            btnInitialize.FlatAppearance.MouseDownBackColor = ThemeBullish;
            btnInitialize.FlatAppearance.MouseOverBackColor = Color.FromArgb(8, 145, 178);
            btnInitialize.FlatStyle = FlatStyle.Flat;
            btnInitialize.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnInitialize.ForeColor = ThemeBackground;
            btnInitialize.Location = new Point(0, 536);
            btnInitialize.Name = "btnInitialize";
            btnInitialize.Size = new Size(296, 48);
            btnInitialize.TabIndex = 13;
            btnInitialize.Text = "INITIALIZE GATEWAY";
            btnInitialize.UseVisualStyleBackColor = false;
            btnInitialize.Click += BtnInitialize_Click;
            // 
            // pnlAuthFooter
            // 
            pnlAuthFooter.BackColor = ThemeGraphite;
            pnlAuthFooter.Controls.Add(lblAuthFooter);
            pnlAuthFooter.Dock = DockStyle.Bottom;
            pnlAuthFooter.Location = new Point(0, 590);
            pnlAuthFooter.Name = "pnlAuthFooter";
            pnlAuthFooter.Size = new Size(296, 74);
            pnlAuthFooter.TabIndex = 10;
            // 
            // lblAuthFooter
            // 
            lblAuthFooter.Dock = DockStyle.Fill;
            lblAuthFooter.Font = new Font("Segoe UI", 8.25F);
            lblAuthFooter.ForeColor = ThemeSecondary;
            lblAuthFooter.Location = new Point(0, 0);
            lblAuthFooter.Name = "lblAuthFooter";
            lblAuthFooter.Size = new Size(296, 74);
            lblAuthFooter.TabIndex = 0;
            lblAuthFooter.Text = "LOCAL EXECUTION NODE\r\nENCRYPTED SESSION CONTEXT\r\nREAL-TIME CLASSIFICATION READY";
            lblAuthFooter.TextAlign = ContentAlignment.BottomLeft;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = ThemeBackground;
            mainPanel.Controls.Add(assetGrid);
            mainPanel.Controls.Add(footerPanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(368, 24);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(28, 0, 0, 0);
            mainPanel.Size = new Size(848, 712);
            mainPanel.TabIndex = 1;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = ThemeBackground;
            headerPanel.Controls.Add(lblDashboardSubtitle);
            headerPanel.Controls.Add(lblDashboardTitle);
            headerPanel.Controls.Add(lblDashboardKicker);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(28, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(820, 132);
            headerPanel.TabIndex = 0;
            // 
            // lblDashboardKicker
            // 
            lblDashboardKicker.AutoSize = true;
            lblDashboardKicker.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblDashboardKicker.ForeColor = ThemeAccent;
            lblDashboardKicker.Location = new Point(0, 2);
            lblDashboardKicker.Name = "lblDashboardKicker";
            lblDashboardKicker.Size = new Size(205, 13);
            lblDashboardKicker.TabIndex = 0;
            lblDashboardKicker.Text = "INSTITUTIONAL MARKET INTELLIGENCE";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            lblDashboardTitle.ForeColor = ThemePrimary;
            lblDashboardTitle.Location = new Point(-2, 27);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(760, 48);
            lblDashboardTitle.TabIndex = 1;
            lblDashboardTitle.Text = "Trend Classifier for MT5";
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.Font = new Font("Segoe UI", 10F);
            lblDashboardSubtitle.ForeColor = ThemeSecondary;
            lblDashboardSubtitle.Location = new Point(2, 84);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(760, 38);
            lblDashboardSubtitle.TabIndex = 2;
            lblDashboardSubtitle.Text = "High-conviction structural classification across FX, metals, and digital asset liquidity regimes.";
            // 
            // assetGrid
            // 
            assetGrid.BackColor = ThemeBackground;
            assetGrid.ColumnCount = 3;
            assetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            assetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            assetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            assetGrid.Controls.Add(pnlEurCard, 0, 0);
            assetGrid.Controls.Add(pnlXauCard, 1, 0);
            assetGrid.Controls.Add(pnlBtcCard, 2, 0);
            assetGrid.Dock = DockStyle.Fill;
            assetGrid.Location = new Point(28, 132);
            assetGrid.Name = "assetGrid";
            assetGrid.Padding = new Padding(0, 28, 0, 28);
            assetGrid.RowCount = 1;
            assetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            assetGrid.Size = new Size(820, 516);
            assetGrid.TabIndex = 1;
            // 
            // pnlEurCard
            // 
            pnlEurCard.BackColor = ThemeGraphite;
            pnlEurCard.Controls.Add(lblEurMeta);
            pnlEurCard.Controls.Add(lblEurClassification);
            pnlEurCard.Controls.Add(lblEurBadge);
            pnlEurCard.Controls.Add(lblEurName);
            pnlEurCard.Controls.Add(lblEurSymbol);
            pnlEurCard.Controls.Add(pnlEurAccent);
            pnlEurCard.Dock = DockStyle.Fill;
            pnlEurCard.Location = new Point(0, 28);
            pnlEurCard.Margin = new Padding(0, 0, 14, 0);
            pnlEurCard.Name = "pnlEurCard";
            pnlEurCard.Padding = new Padding(22);
            pnlEurCard.Size = new Size(259, 460);
            pnlEurCard.TabIndex = 0;
            // 
            // pnlEurAccent
            // 
            pnlEurAccent.BackColor = ThemeSecondary;
            pnlEurAccent.Dock = DockStyle.Top;
            pnlEurAccent.Location = new Point(22, 22);
            pnlEurAccent.Name = "pnlEurAccent";
            pnlEurAccent.Size = new Size(215, 3);
            pnlEurAccent.TabIndex = 0;
            // 
            // lblEurSymbol
            // 
            lblEurSymbol.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblEurSymbol.ForeColor = ThemePrimary;
            lblEurSymbol.Location = new Point(18, 48);
            lblEurSymbol.Name = "lblEurSymbol";
            lblEurSymbol.Size = new Size(205, 48);
            lblEurSymbol.TabIndex = 1;
            lblEurSymbol.Text = "EURUSD";
            // 
            // lblEurName
            // 
            lblEurName.Font = new Font("Segoe UI", 8.75F);
            lblEurName.ForeColor = ThemeSecondary;
            lblEurName.Location = new Point(22, 98);
            lblEurName.Name = "lblEurName";
            lblEurName.Size = new Size(204, 32);
            lblEurName.TabIndex = 2;
            lblEurName.Text = "EURO / U.S. DOLLAR\r\nFX MAJOR LIQUIDITY";
            // 
            // lblEurBadge
            // 
            lblEurBadge.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblEurBadge.ForeColor = ThemeSecondary;
            lblEurBadge.Location = new Point(22, 162);
            lblEurBadge.Name = "lblEurBadge";
            lblEurBadge.Size = new Size(204, 18);
            lblEurBadge.TabIndex = 3;
            lblEurBadge.Text = "PENDING SIGNAL";
            // 
            // lblEurClassification
            // 
            lblEurClassification.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEurClassification.ForeColor = ThemePrimary;
            lblEurClassification.Location = new Point(22, 196);
            lblEurClassification.Name = "lblEurClassification";
            lblEurClassification.Size = new Size(204, 116);
            lblEurClassification.TabIndex = 4;
            lblEurClassification.Text = "GATEWAY STANDBY / MARKET STREAM NOT YET AUTHORIZED";
            // 
            // lblEurMeta
            // 
            lblEurMeta.Dock = DockStyle.Bottom;
            lblEurMeta.Font = new Font("Segoe UI", 8.25F);
            lblEurMeta.ForeColor = ThemeSecondary;
            lblEurMeta.Location = new Point(22, 392);
            lblEurMeta.Name = "lblEurMeta";
            lblEurMeta.Size = new Size(215, 46);
            lblEurMeta.TabIndex = 5;
            lblEurMeta.Text = "SECURE DATA CHANNEL REQUIRED";
            lblEurMeta.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlXauCard
            // 
            pnlXauCard.BackColor = ThemeGraphite;
            pnlXauCard.Controls.Add(lblXauMeta);
            pnlXauCard.Controls.Add(lblXauClassification);
            pnlXauCard.Controls.Add(lblXauBadge);
            pnlXauCard.Controls.Add(lblXauName);
            pnlXauCard.Controls.Add(lblXauSymbol);
            pnlXauCard.Controls.Add(pnlXauAccent);
            pnlXauCard.Dock = DockStyle.Fill;
            pnlXauCard.Location = new Point(273, 28);
            pnlXauCard.Margin = new Padding(0, 0, 14, 0);
            pnlXauCard.Name = "pnlXauCard";
            pnlXauCard.Padding = new Padding(22);
            pnlXauCard.Size = new Size(259, 460);
            pnlXauCard.TabIndex = 1;
            // 
            // pnlXauAccent
            // 
            pnlXauAccent.BackColor = ThemeSecondary;
            pnlXauAccent.Dock = DockStyle.Top;
            pnlXauAccent.Location = new Point(22, 22);
            pnlXauAccent.Name = "pnlXauAccent";
            pnlXauAccent.Size = new Size(215, 3);
            pnlXauAccent.TabIndex = 0;
            // 
            // lblXauSymbol
            // 
            lblXauSymbol.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblXauSymbol.ForeColor = ThemePrimary;
            lblXauSymbol.Location = new Point(18, 48);
            lblXauSymbol.Name = "lblXauSymbol";
            lblXauSymbol.Size = new Size(205, 48);
            lblXauSymbol.TabIndex = 1;
            lblXauSymbol.Text = "XAUUSD";
            // 
            // lblXauName
            // 
            lblXauName.Font = new Font("Segoe UI", 8.75F);
            lblXauName.ForeColor = ThemeSecondary;
            lblXauName.Location = new Point(22, 98);
            lblXauName.Name = "lblXauName";
            lblXauName.Size = new Size(204, 32);
            lblXauName.TabIndex = 2;
            lblXauName.Text = "GOLD SPOT / U.S. DOLLAR\r\nMETALS LIQUIDITY";
            // 
            // lblXauBadge
            // 
            lblXauBadge.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblXauBadge.ForeColor = ThemeSecondary;
            lblXauBadge.Location = new Point(22, 162);
            lblXauBadge.Name = "lblXauBadge";
            lblXauBadge.Size = new Size(204, 18);
            lblXauBadge.TabIndex = 3;
            lblXauBadge.Text = "PENDING SIGNAL";
            // 
            // lblXauClassification
            // 
            lblXauClassification.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblXauClassification.ForeColor = ThemePrimary;
            lblXauClassification.Location = new Point(22, 196);
            lblXauClassification.Name = "lblXauClassification";
            lblXauClassification.Size = new Size(204, 116);
            lblXauClassification.TabIndex = 4;
            lblXauClassification.Text = "GATEWAY STANDBY / MARKET STREAM NOT YET AUTHORIZED";
            // 
            // lblXauMeta
            // 
            lblXauMeta.Dock = DockStyle.Bottom;
            lblXauMeta.Font = new Font("Segoe UI", 8.25F);
            lblXauMeta.ForeColor = ThemeSecondary;
            lblXauMeta.Location = new Point(22, 392);
            lblXauMeta.Name = "lblXauMeta";
            lblXauMeta.Size = new Size(215, 46);
            lblXauMeta.TabIndex = 5;
            lblXauMeta.Text = "SECURE DATA CHANNEL REQUIRED";
            lblXauMeta.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlBtcCard
            // 
            pnlBtcCard.BackColor = ThemeGraphite;
            pnlBtcCard.Controls.Add(lblBtcMeta);
            pnlBtcCard.Controls.Add(lblBtcClassification);
            pnlBtcCard.Controls.Add(lblBtcBadge);
            pnlBtcCard.Controls.Add(lblBtcName);
            pnlBtcCard.Controls.Add(lblBtcSymbol);
            pnlBtcCard.Controls.Add(pnlBtcAccent);
            pnlBtcCard.Dock = DockStyle.Fill;
            pnlBtcCard.Location = new Point(546, 28);
            pnlBtcCard.Margin = new Padding(0);
            pnlBtcCard.Name = "pnlBtcCard";
            pnlBtcCard.Padding = new Padding(22);
            pnlBtcCard.Size = new Size(274, 460);
            pnlBtcCard.TabIndex = 2;
            // 
            // pnlBtcAccent
            // 
            pnlBtcAccent.BackColor = ThemeSecondary;
            pnlBtcAccent.Dock = DockStyle.Top;
            pnlBtcAccent.Location = new Point(22, 22);
            pnlBtcAccent.Name = "pnlBtcAccent";
            pnlBtcAccent.Size = new Size(230, 3);
            pnlBtcAccent.TabIndex = 0;
            // 
            // lblBtcSymbol
            // 
            lblBtcSymbol.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblBtcSymbol.ForeColor = ThemePrimary;
            lblBtcSymbol.Location = new Point(18, 48);
            lblBtcSymbol.Name = "lblBtcSymbol";
            lblBtcSymbol.Size = new Size(220, 48);
            lblBtcSymbol.TabIndex = 1;
            lblBtcSymbol.Text = "BTCUSD";
            // 
            // lblBtcName
            // 
            lblBtcName.Font = new Font("Segoe UI", 8.75F);
            lblBtcName.ForeColor = ThemeSecondary;
            lblBtcName.Location = new Point(22, 98);
            lblBtcName.Name = "lblBtcName";
            lblBtcName.Size = new Size(220, 32);
            lblBtcName.TabIndex = 2;
            lblBtcName.Text = "BITCOIN / U.S. DOLLAR\r\nDIGITAL ASSET LIQUIDITY";
            // 
            // lblBtcBadge
            // 
            lblBtcBadge.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblBtcBadge.ForeColor = ThemeSecondary;
            lblBtcBadge.Location = new Point(22, 162);
            lblBtcBadge.Name = "lblBtcBadge";
            lblBtcBadge.Size = new Size(220, 18);
            lblBtcBadge.TabIndex = 3;
            lblBtcBadge.Text = "PENDING SIGNAL";
            // 
            // lblBtcClassification
            // 
            lblBtcClassification.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblBtcClassification.ForeColor = ThemePrimary;
            lblBtcClassification.Location = new Point(22, 196);
            lblBtcClassification.Name = "lblBtcClassification";
            lblBtcClassification.Size = new Size(220, 116);
            lblBtcClassification.TabIndex = 4;
            lblBtcClassification.Text = "GATEWAY STANDBY / MARKET STREAM NOT YET AUTHORIZED";
            // 
            // lblBtcMeta
            // 
            lblBtcMeta.Dock = DockStyle.Bottom;
            lblBtcMeta.Font = new Font("Segoe UI", 8.25F);
            lblBtcMeta.ForeColor = ThemeSecondary;
            lblBtcMeta.Location = new Point(22, 392);
            lblBtcMeta.Name = "lblBtcMeta";
            lblBtcMeta.Size = new Size(230, 46);
            lblBtcMeta.TabIndex = 5;
            lblBtcMeta.Text = "SECURE DATA CHANNEL REQUIRED";
            lblBtcMeta.TextAlign = ContentAlignment.BottomLeft;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = ThemeBackground;
            footerPanel.Controls.Add(lblSessionStatus);
            footerPanel.Controls.Add(lblClock);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(28, 648);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(820, 64);
            footerPanel.TabIndex = 2;
            // 
            // lblClock
            // 
            lblClock.Dock = DockStyle.Right;
            lblClock.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            lblClock.ForeColor = ThemePrimary;
            lblClock.Location = new Point(700, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(120, 64);
            lblClock.TabIndex = 0;
            lblClock.Text = "00:00:00";
            lblClock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSessionStatus
            // 
            lblSessionStatus.Dock = DockStyle.Right;
            lblSessionStatus.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblSessionStatus.ForeColor = ThemeSecondary;
            lblSessionStatus.Location = new Point(340, 0);
            lblSessionStatus.Name = "lblSessionStatus";
            lblSessionStatus.Size = new Size(360, 64);
            lblSessionStatus.TabIndex = 1;
            lblSessionStatus.Text = "● SESSION TERMINATED";
            lblSessionStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = ThemeBackground;
            ClientSize = new Size(1240, 760);
            Controls.Add(rootLayout);
            Font = new Font("Segoe UI", 9F);
            ForeColor = ThemePrimary;
            MinimumSize = new Size(1120, 680);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Institutional Market Intelligence & Trend Classifier for MT5";
            FormClosing += Form1_FormClosing;
            rootLayout.ResumeLayout(false);
            authenticationPanel.ResumeLayout(false);
            authContentPanel.ResumeLayout(false);
            authContentPanel.PerformLayout();
            pnlLoginInput.ResumeLayout(false);
            pnlLoginInput.PerformLayout();
            pnlPasswordInput.ResumeLayout(false);
            pnlPasswordInput.PerformLayout();
            pnlAssetOneInput.ResumeLayout(false);
            pnlAssetOneInput.PerformLayout();
            pnlAssetTwoInput.ResumeLayout(false);
            pnlAssetTwoInput.PerformLayout();
            pnlAssetThreeInput.ResumeLayout(false);
            pnlAssetThreeInput.PerformLayout();
            pnlAuthFooter.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            assetGrid.ResumeLayout(false);
            pnlEurCard.ResumeLayout(false);
            pnlXauCard.ResumeLayout(false);
            pnlBtcCard.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel rootLayout;
        private Panel authenticationPanel;
        private Panel authContentPanel;
        private Label lblSecureAccess;
        private Label lblAuthTitle;
        private Label lblAuthSubtitle;
        private Label lblLogin;
        private Panel pnlLoginInput;
        private TextBox txtLoginId;
        private Label lblPassword;
        private Panel pnlPasswordInput;
        private TextBox txtPassword;
        private Label lblAssetUniverse;
        private Label lblAssetUniverseHint;
        private Panel pnlAssetOneInput;
        private TextBox txtAssetOne;
        private Panel pnlAssetTwoInput;
        private TextBox txtAssetTwo;
        private Panel pnlAssetThreeInput;
        private TextBox txtAssetThree;
        private Button btnUpdateAssets;
        private Button btnInitialize;
        private Panel pnlAuthFooter;
        private Label lblAuthFooter;
        private Panel mainPanel;
        private Panel headerPanel;
        private Label lblDashboardKicker;
        private Label lblDashboardTitle;
        private Label lblDashboardSubtitle;
        private TableLayoutPanel assetGrid;
        private Panel pnlEurCard;
        private Panel pnlEurAccent;
        private Label lblEurSymbol;
        private Label lblEurName;
        private Label lblEurBadge;
        private Label lblEurClassification;
        private Label lblEurMeta;
        private Panel pnlXauCard;
        private Panel pnlXauAccent;
        private Label lblXauSymbol;
        private Label lblXauName;
        private Label lblXauBadge;
        private Label lblXauClassification;
        private Label lblXauMeta;
        private Panel pnlBtcCard;
        private Panel pnlBtcAccent;
        private Label lblBtcSymbol;
        private Label lblBtcName;
        private Label lblBtcBadge;
        private Label lblBtcClassification;
        private Label lblBtcMeta;
        private Panel footerPanel;
        private Label lblClock;
        private Label lblSessionStatus;
    }
}
