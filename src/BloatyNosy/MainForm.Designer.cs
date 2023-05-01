namespace BloatyNosy
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblAppOptionsFix = new System.Windows.Forms.Label();
            this.lnkRunSetup = new System.Windows.Forms.LinkLabel();
            this.btnAppOptions = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKebapMenu = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lblTools = new System.Windows.Forms.Label();
            this.cmbTools = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tvwFeatures = new System.Windows.Forms.TreeView();
            this.contextKebapMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textHeader = new System.Windows.Forms.ToolStripTextBox();
            this.menuAdvanced = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIgnoreLowLevelI = new System.Windows.Forms.ToolStripMenuItem();
            this.cbProfiles = new System.Windows.Forms.ToolStripComboBox();
            this.menuLoadProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.textExplanation = new System.Windows.Forms.ToolStripTextBox();
            this.textExplanationIssue = new System.Windows.Forms.ToolStripTextBox();
            this.textExplanationOK = new System.Windows.Forms.ToolStripTextBox();
            this.contextAppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuFix = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFixInfo = new System.Windows.Forms.ToolStripTextBox();
            this.menuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRestoreInfo = new System.Windows.Forms.ToolStripTextBox();
            this.contextAppMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAppConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForm.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.contextKebapMenu.SuspendLayout();
            this.contextAppMenu.SuspendLayout();
            this.contextAppMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.Controls.Add(this.pnlMain);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(430, 616);
            this.pnlForm.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.lblOS);
            this.pnlMain.Controls.Add(this.lblAppOptionsFix);
            this.pnlMain.Controls.Add(this.lnkRunSetup);
            this.pnlMain.Controls.Add(this.btnAppOptions);
            this.pnlMain.Controls.Add(this.btnSettings);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnKebapMenu);
            this.pnlMain.Controls.Add(this.btnAnalyze);
            this.pnlMain.Controls.Add(this.lnkSubHeader);
            this.pnlMain.Controls.Add(this.progress);
            this.pnlMain.Controls.Add(this.lblTools);
            this.pnlMain.Controls.Add(this.cmbTools);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Controls.Add(this.rtbLog);
            this.pnlMain.Controls.Add(this.tvwFeatures);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(430, 616);
            this.pnlMain.TabIndex = 0;
            // 
            // lblOS
            // 
            this.lblOS.AutoEllipsis = true;
            this.lblOS.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblOS.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.ForeColor = System.Drawing.Color.White;
            this.lblOS.Location = new System.Drawing.Point(119, 220);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(177, 16);
            this.lblOS.TabIndex = 181;
            this.lblOS.Text = "Windows 11 ";
            this.lblOS.Click += new System.EventHandler(this.lblOS_Click);
            // 
            // lblAppOptionsFix
            // 
            this.lblAppOptionsFix.AutoSize = true;
            this.lblAppOptionsFix.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppOptionsFix.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppOptionsFix.ForeColor = System.Drawing.Color.White;
            this.lblAppOptionsFix.Location = new System.Drawing.Point(312, 219);
            this.lblAppOptionsFix.Name = "lblAppOptionsFix";
            this.lblAppOptionsFix.Size = new System.Drawing.Size(25, 17);
            this.lblAppOptionsFix.TabIndex = 180;
            this.lblAppOptionsFix.Text = "Fix";
            this.lblAppOptionsFix.Click += new System.EventHandler(this.lblAppOptionsFix_Click);
            // 
            // lnkRunSetup
            // 
            this.lnkRunSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRunSetup.AutoSize = true;
            this.lnkRunSetup.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRunSetup.Location = new System.Drawing.Point(70, 597);
            this.lnkRunSetup.Name = "lnkRunSetup";
            this.lnkRunSetup.Size = new System.Drawing.Size(229, 15);
            this.lnkRunSetup.TabIndex = 179;
            this.lnkRunSetup.TabStop = true;
            this.lnkRunSetup.Text = "I want to set up Windows 11 for the first time...";
            this.lnkRunSetup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRunSetup_LinkClicked);
            // 
            // btnAppOptions
            // 
            this.btnAppOptions.AutoEllipsis = true;
            this.btnAppOptions.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAppOptions.FlatAppearance.BorderSize = 0;
            this.btnAppOptions.Font = new System.Drawing.Font("Segoe Fluent Icons", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppOptions.ForeColor = System.Drawing.Color.White;
            this.btnAppOptions.Location = new System.Drawing.Point(302, 207);
            this.btnAppOptions.Name = "btnAppOptions";
            this.btnAppOptions.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAppOptions.Size = new System.Drawing.Size(62, 42);
            this.btnAppOptions.TabIndex = 178;
            this.btnAppOptions.Text = "...";
            this.btnAppOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppOptions.UseVisualStyleBackColor = false;
            this.btnAppOptions.Click += new System.EventHandler(this.btnAppOptions_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnSettings.Location = new System.Drawing.Point(376, 554);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(42, 38);
            this.btnSettings.TabIndex = 177;
            this.btnSettings.Text = "...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 36);
            this.label1.TabIndex = 176;
            this.label1.Text = "Boost your PC\'s performance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnKebapMenu
            // 
            this.btnKebapMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKebapMenu.FlatAppearance.BorderSize = 0;
            this.btnKebapMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKebapMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKebapMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKebapMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKebapMenu.Location = new System.Drawing.Point(381, 0);
            this.btnKebapMenu.Name = "btnKebapMenu";
            this.btnKebapMenu.Size = new System.Drawing.Size(42, 47);
            this.btnKebapMenu.TabIndex = 175;
            this.btnKebapMenu.Text = "...";
            this.btnKebapMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKebapMenu.UseVisualStyleBackColor = true;
            this.btnKebapMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.AutoEllipsis = true;
            this.btnAnalyze.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAnalyze.FlatAppearance.BorderSize = 0;
            this.btnAnalyze.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(23, 207);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAnalyze.Size = new System.Drawing.Size(286, 42);
            this.btnAnalyze.TabIndex = 27;
            this.btnAnalyze.Text = "Analyze ";
            this.btnAnalyze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.ForeColor = System.Drawing.Color.Black;
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkSubHeader.Location = new System.Drawing.Point(12, 494);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(400, 38);
            this.lnkSubHeader.TabIndex = 171;
            this.lnkSubHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubHeader_LinkClicked);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(9, 285);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(409, 5);
            this.progress.TabIndex = 166;
            this.progress.Visible = false;
            // 
            // lblTools
            // 
            this.lblTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTools.AutoSize = true;
            this.lblTools.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTools.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTools.Location = new System.Drawing.Point(32, 561);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(35, 15);
            this.lblTools.TabIndex = 25;
            this.lblTools.Text = "NEW!";
            // 
            // cmbTools
            // 
            this.cmbTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTools.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTools.DropDownHeight = 200;
            this.cmbTools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTools.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbTools.FormattingEnabled = true;
            this.cmbTools.IntegralHeight = false;
            this.cmbTools.ItemHeight = 21;
            this.cmbTools.Location = new System.Drawing.Point(75, 553);
            this.cmbTools.Name = "cmbTools";
            this.cmbTools.Size = new System.Drawing.Size(150, 29);
            this.cmbTools.TabIndex = 19;
            this.cmbTools.SelectedIndexChanged += new System.EventHandler(this.cmbTools_SelectedIndexChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeader.Location = new System.Drawing.Point(18, 112);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(346, 70);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Text = "Windows 11 is too bloaty && nosy and has some annoying features that just need to" +
    " go. This app will scan your system and inform you which features it likes or di" +
    "slikes in your configuration.";
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbLog.HideSelection = false;
            this.rtbLog.Location = new System.Drawing.Point(9, 296);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(414, 175);
            this.rtbLog.TabIndex = 138;
            this.rtbLog.Text = "";
            this.rtbLog.Visible = false;
            this.rtbLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richLog_LinkClicked);
            // 
            // tvwFeatures
            // 
            this.tvwFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwFeatures.BackColor = System.Drawing.Color.White;
            this.tvwFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwFeatures.CheckBoxes = true;
            this.tvwFeatures.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwFeatures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tvwFeatures.FullRowSelect = true;
            this.tvwFeatures.ItemHeight = 30;
            this.tvwFeatures.LineColor = System.Drawing.Color.HotPink;
            this.tvwFeatures.Location = new System.Drawing.Point(9, 296);
            this.tvwFeatures.Name = "tvwFeatures";
            this.tvwFeatures.ShowLines = false;
            this.tvwFeatures.ShowNodeToolTips = true;
            this.tvwFeatures.ShowRootLines = false;
            this.tvwFeatures.Size = new System.Drawing.Size(414, 175);
            this.tvwFeatures.TabIndex = 168;
            this.tvwFeatures.Visible = false;
            this.tvwFeatures.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeFeatures_AfterCheck);
            this.tvwFeatures.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvwFeatures_MouseUp);
            // 
            // contextKebapMenu
            // 
            this.contextKebapMenu.BackColor = System.Drawing.Color.White;
            this.contextKebapMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextKebapMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textHeader,
            this.menuAdvanced,
            this.menuIgnoreLowLevelI,
            this.cbProfiles,
            this.menuLoadProfile,
            this.menuExportProfile,
            this.toolStripSeparator1,
            this.textExplanation,
            this.textExplanationIssue,
            this.textExplanationOK});
            this.contextKebapMenu.Name = "menuMain";
            this.contextKebapMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextKebapMenu.Size = new System.Drawing.Size(261, 251);
            // 
            // textHeader
            // 
            this.textHeader.BackColor = System.Drawing.Color.White;
            this.textHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeader.ForeColor = System.Drawing.Color.Gray;
            this.textHeader.Margin = new System.Windows.Forms.Padding(5, 5, 0, 10);
            this.textHeader.Name = "textHeader";
            this.textHeader.ReadOnly = true;
            this.textHeader.Size = new System.Drawing.Size(100, 18);
            this.textHeader.Text = "App-Info";
            // 
            // menuAdvanced
            // 
            this.menuAdvanced.Name = "menuAdvanced";
            this.menuAdvanced.Size = new System.Drawing.Size(260, 26);
            this.menuAdvanced.Text = "Advanced mode";
            this.menuAdvanced.Click += new System.EventHandler(this.menuAdvanced_Click);
            // 
            // menuIgnoreLowLevelI
            // 
            this.menuIgnoreLowLevelI.Name = "menuIgnoreLowLevelI";
            this.menuIgnoreLowLevelI.Size = new System.Drawing.Size(260, 26);
            this.menuIgnoreLowLevelI.Text = "Ignore minor issues";
            this.menuIgnoreLowLevelI.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuIgnoreLowLevelI.Click += new System.EventHandler(this.menuIgnoreLowLevelP_Click);
            // 
            // cbProfiles
            // 
            this.cbProfiles.AutoToolTip = true;
            this.cbProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbProfiles.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(200, 25);
            // 
            // menuLoadProfile
            // 
            this.menuLoadProfile.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLoadProfile.Name = "menuLoadProfile";
            this.menuLoadProfile.Size = new System.Drawing.Size(260, 26);
            this.menuLoadProfile.Text = "Load profile";
            this.menuLoadProfile.Click += new System.EventHandler(this.menuLoadProfile_Click);
            // 
            // menuExportProfile
            // 
            this.menuExportProfile.Name = "menuExportProfile";
            this.menuExportProfile.Size = new System.Drawing.Size(260, 26);
            this.menuExportProfile.Text = "Export profile";
            this.menuExportProfile.Click += new System.EventHandler(this.menuExportProfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // textExplanation
            // 
            this.textExplanation.BackColor = System.Drawing.Color.White;
            this.textExplanation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textExplanation.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExplanation.Margin = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.textExplanation.Name = "textExplanation";
            this.textExplanation.ReadOnly = true;
            this.textExplanation.Size = new System.Drawing.Size(100, 26);
            this.textExplanation.Text = "Explanation";
            // 
            // textExplanationIssue
            // 
            this.textExplanationIssue.BackColor = System.Drawing.Color.MediumVioletRed;
            this.textExplanationIssue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textExplanationIssue.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExplanationIssue.ForeColor = System.Drawing.Color.Transparent;
            this.textExplanationIssue.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textExplanationIssue.Name = "textExplanationIssue";
            this.textExplanationIssue.ReadOnly = true;
            this.textExplanationIssue.Size = new System.Drawing.Size(190, 15);
            this.textExplanationIssue.Text = "Color indicates a issue";
            // 
            // textExplanationOK
            // 
            this.textExplanationOK.BackColor = System.Drawing.Color.DarkGray;
            this.textExplanationOK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textExplanationOK.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExplanationOK.Margin = new System.Windows.Forms.Padding(5, 1, 1, 10);
            this.textExplanationOK.Name = "textExplanationOK";
            this.textExplanationOK.ReadOnly = true;
            this.textExplanationOK.Size = new System.Drawing.Size(190, 15);
            this.textExplanationOK.Text = "Color indicates that no action is needed";
            // 
            // contextAppMenu
            // 
            this.contextAppMenu.BackColor = System.Drawing.Color.White;
            this.contextAppMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextAppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFix,
            this.menuFixInfo,
            this.menuRestore,
            this.menuRestoreInfo});
            this.contextAppMenu.Name = "menuMain";
            this.contextAppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextAppMenu.Size = new System.Drawing.Size(361, 104);
            // 
            // menuFix
            // 
            this.menuFix.Name = "menuFix";
            this.menuFix.Size = new System.Drawing.Size(360, 32);
            this.menuFix.Text = "Apply fixes";
            this.menuFix.Click += new System.EventHandler(this.menuFix_Click);
            // 
            // menuFixInfo
            // 
            this.menuFixInfo.BackColor = System.Drawing.Color.White;
            this.menuFixInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuFixInfo.Enabled = false;
            this.menuFixInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFixInfo.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.menuFixInfo.Name = "menuFixInfo";
            this.menuFixInfo.Size = new System.Drawing.Size(300, 16);
            this.menuFixInfo.Text = "This will fix all found and selected problems";
            // 
            // menuRestore
            // 
            this.menuRestore.Name = "menuRestore";
            this.menuRestore.Size = new System.Drawing.Size(360, 32);
            this.menuRestore.Text = "Restore default state";
            this.menuRestore.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuRestore.Click += new System.EventHandler(this.menuRestore_Click);
            // 
            // menuRestoreInfo
            // 
            this.menuRestoreInfo.BackColor = System.Drawing.Color.White;
            this.menuRestoreInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuRestoreInfo.Enabled = false;
            this.menuRestoreInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRestoreInfo.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.menuRestoreInfo.Name = "menuRestoreInfo";
            this.menuRestoreInfo.Size = new System.Drawing.Size(300, 16);
            this.menuRestoreInfo.Text = "This will restore the default settings  ";
            // 
            // contextAppMenuOptions
            // 
            this.contextAppMenuOptions.BackColor = System.Drawing.SystemColors.Control;
            this.contextAppMenuOptions.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextAppMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppConfigure});
            this.contextAppMenuOptions.Name = "menuMain";
            this.contextAppMenuOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextAppMenuOptions.Size = new System.Drawing.Size(208, 30);
            // 
            // menuAppConfigure
            // 
            this.menuAppConfigure.Name = "menuAppConfigure";
            this.menuAppConfigure.Size = new System.Drawing.Size(207, 26);
            this.menuAppConfigure.Text = "Configure this app";
            this.menuAppConfigure.Click += new System.EventHandler(this.menuAppConfigure_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 616);
            this.Controls.Add(this.pnlForm);
            this.MinimumSize = new System.Drawing.Size(446, 655);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloatyNosy";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlForm.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.contextKebapMenu.ResumeLayout(false);
            this.contextKebapMenu.PerformLayout();
            this.contextAppMenu.ResumeLayout(false);
            this.contextAppMenu.PerformLayout();
            this.contextAppMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.ComboBox cmbTools;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.TreeView tvwFeatures;
        private System.Windows.Forms.Button btnKebapMenu;
        private System.Windows.Forms.ContextMenuStrip contextKebapMenu;
        private System.Windows.Forms.ToolStripMenuItem menuAdvanced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripMenuItem menuIgnoreLowLevelI;
        private System.Windows.Forms.Button btnAppOptions;
        private System.Windows.Forms.ContextMenuStrip contextAppMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFix;
        private System.Windows.Forms.ToolStripTextBox menuFixInfo;
        private System.Windows.Forms.ToolStripMenuItem menuRestore;
        private System.Windows.Forms.ToolStripTextBox menuRestoreInfo;
        private System.Windows.Forms.ToolStripMenuItem menuLoadProfile;
        private System.Windows.Forms.LinkLabel lnkRunSetup;
        private System.Windows.Forms.ToolStripMenuItem menuExportProfile;
        private System.Windows.Forms.ContextMenuStrip contextAppMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuAppConfigure;
        private System.Windows.Forms.Label lblAppOptionsFix;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox textExplanationIssue;
        private System.Windows.Forms.ToolStripTextBox textExplanationOK;
        private System.Windows.Forms.ToolStripComboBox cbProfiles;
        private System.Windows.Forms.ToolStripTextBox textHeader;
        private System.Windows.Forms.ToolStripTextBox textExplanation;
        private System.Windows.Forms.Label lblOS;
    }
}

