namespace Bloatynosy
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnMenuChevronDown = new System.Windows.Forms.Button();
            this.pnlNavRight = new System.Windows.Forms.Panel();
            this.btnAppBloatpilot = new System.Windows.Forms.Button();
            this.checkVersion = new System.Windows.Forms.CheckBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRightSettings = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkIgnoreLowIssues = new System.Windows.Forms.CheckBox();
            this.lnkStargazers = new System.Windows.Forms.LinkLabel();
            this.btnGithub = new System.Windows.Forms.Button();
            this._lblAboutInfo = new System.Windows.Forms.Label();
            this.lnkURLTwitter = new System.Windows.Forms.LinkLabel();
            this.lnkURLReddit = new System.Windows.Forms.LinkLabel();
            this.lnkURLDev = new System.Windows.Forms.LinkLabel();
            this.lnkURLPayPal = new System.Windows.Forms.LinkLabel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuChevron = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWizardInfo = new System.Windows.Forms.ToolStripTextBox();
            this.menuPackages = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackagesInfo = new System.Windows.Forms.ToolStripTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlNavRight.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRightSettings.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.contextMenuChevron.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.btnMenuChevronDown);
            this.pnlMain.Controls.Add(this.pnlNavRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(926, 720);
            this.pnlMain.TabIndex = 0;
            // 
            // btnMenuChevronDown
            // 
            this.btnMenuChevronDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuChevronDown.FlatAppearance.BorderSize = 0;
            this.btnMenuChevronDown.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuChevronDown.ForeColor = System.Drawing.Color.Black;
            this.btnMenuChevronDown.Location = new System.Drawing.Point(536, 25);
            this.btnMenuChevronDown.Name = "btnMenuChevronDown";
            this.btnMenuChevronDown.Size = new System.Drawing.Size(157, 32);
            this.btnMenuChevronDown.TabIndex = 219;
            this.btnMenuChevronDown.Text = "+ Toggle App";
            this.btnMenuChevronDown.UseVisualStyleBackColor = true;
            this.btnMenuChevronDown.Click += new System.EventHandler(this.btnMenuChevronDown_Click);
            // 
            // pnlNavRight
            // 
            this.pnlNavRight.Controls.Add(this.btnAppBloatpilot);
            this.pnlNavRight.Controls.Add(this.checkVersion);
            this.pnlNavRight.Controls.Add(this.pnlRight);
            this.pnlNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNavRight.Location = new System.Drawing.Point(699, 0);
            this.pnlNavRight.Name = "pnlNavRight";
            this.pnlNavRight.Size = new System.Drawing.Size(227, 720);
            this.pnlNavRight.TabIndex = 218;
            // 
            // btnAppBloatpilot
            // 
            this.btnAppBloatpilot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppBloatpilot.AutoEllipsis = true;
            this.btnAppBloatpilot.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAppBloatpilot.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAppBloatpilot.FlatAppearance.BorderSize = 0;
            this.btnAppBloatpilot.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppBloatpilot.ForeColor = System.Drawing.Color.White;
            this.btnAppBloatpilot.Location = new System.Drawing.Point(54, 668);
            this.btnAppBloatpilot.Name = "btnAppBloatpilot";
            this.btnAppBloatpilot.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAppBloatpilot.Size = new System.Drawing.Size(120, 35);
            this.btnAppBloatpilot.TabIndex = 217;
            this.btnAppBloatpilot.TabStop = false;
            this.btnAppBloatpilot.Text = "Bloatpilot";
            this.btnAppBloatpilot.UseVisualStyleBackColor = false;
            this.btnAppBloatpilot.Click += new System.EventHandler(this.btnAppBloatpilot_Click);
            // 
            // checkVersion
            // 
            this.checkVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkVersion.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkVersion.AutoSize = true;
            this.checkVersion.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkVersion.FlatAppearance.BorderSize = 0;
            this.checkVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkVersion.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F);
            this.checkVersion.ForeColor = System.Drawing.Color.Black;
            this.checkVersion.Location = new System.Drawing.Point(193, 0);
            this.checkVersion.Name = "checkVersion";
            this.checkVersion.Size = new System.Drawing.Size(23, 27);
            this.checkVersion.TabIndex = 216;
            this.checkVersion.Text = "x";
            this.checkVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkVersion.UseVisualStyleBackColor = true;
            this.checkVersion.CheckedChanged += new System.EventHandler(this.checkVersion_CheckedChanged);
            // 
            // pnlRight
            // 
            this.pnlRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRight.AutoScroll = true;
            this.pnlRight.Controls.Add(this.pnlRightSettings);
            this.pnlRight.Controls.Add(this.lnkStargazers);
            this.pnlRight.Controls.Add(this.btnGithub);
            this.pnlRight.Controls.Add(this._lblAboutInfo);
            this.pnlRight.Controls.Add(this.lnkURLTwitter);
            this.pnlRight.Controls.Add(this.lnkURLReddit);
            this.pnlRight.Controls.Add(this.lnkURLDev);
            this.pnlRight.Controls.Add(this.lnkURLPayPal);
            this.pnlRight.Location = new System.Drawing.Point(12, 33);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(203, 328);
            this.pnlRight.TabIndex = 214;
            // 
            // pnlRightSettings
            // 
            this.pnlRightSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightSettings.AutoScroll = true;
            this.pnlRightSettings.Controls.Add(this.label1);
            this.pnlRightSettings.Controls.Add(this.checkIgnoreLowIssues);
            this.pnlRightSettings.Location = new System.Drawing.Point(3, 194);
            this.pnlRightSettings.Name = "pnlRightSettings";
            this.pnlRightSettings.Size = new System.Drawing.Size(203, 135);
            this.pnlRightSettings.TabIndex = 215;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 11.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 197;
            this.label1.Text = "Settings";
            // 
            // checkIgnoreLowIssues
            // 
            this.checkIgnoreLowIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIgnoreLowIssues.AutoEllipsis = true;
            this.checkIgnoreLowIssues.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkIgnoreLowIssues.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.checkIgnoreLowIssues.FlatAppearance.BorderSize = 0;
            this.checkIgnoreLowIssues.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 10.75F);
            this.checkIgnoreLowIssues.ForeColor = System.Drawing.Color.Black;
            this.checkIgnoreLowIssues.Location = new System.Drawing.Point(16, 54);
            this.checkIgnoreLowIssues.Name = "checkIgnoreLowIssues";
            this.checkIgnoreLowIssues.Size = new System.Drawing.Size(157, 24);
            this.checkIgnoreLowIssues.TabIndex = 211;
            this.checkIgnoreLowIssues.Text = "Ignore minor issues";
            this.checkIgnoreLowIssues.UseVisualStyleBackColor = true;
            this.checkIgnoreLowIssues.CheckedChanged += new System.EventHandler(this.checkIgnoreLowIssues_CheckedChanged);
            // 
            // lnkStargazers
            // 
            this.lnkStargazers.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkStargazers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStargazers.AutoEllipsis = true;
            this.lnkStargazers.AutoSize = true;
            this.lnkStargazers.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold);
            this.lnkStargazers.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkStargazers.LinkColor = System.Drawing.Color.Black;
            this.lnkStargazers.Location = new System.Drawing.Point(13, 141);
            this.lnkStargazers.Name = "lnkStargazers";
            this.lnkStargazers.Size = new System.Drawing.Size(105, 17);
            this.lnkStargazers.TabIndex = 217;
            this.lnkStargazers.TabStop = true;
            this.lnkStargazers.Text = "We love Github...";
            this.lnkStargazers.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkStargazers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStargazers_LinkClicked);
            // 
            // btnGithub
            // 
            this.btnGithub.AutoEllipsis = true;
            this.btnGithub.BackColor = System.Drawing.Color.Transparent;
            this.btnGithub.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGithub.FlatAppearance.BorderSize = 0;
            this.btnGithub.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGithub.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnGithub.Location = new System.Drawing.Point(25, 161);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnGithub.Size = new System.Drawing.Size(101, 27);
            this.btnGithub.TabIndex = 206;
            this.btnGithub.TabStop = false;
            this.btnGithub.Text = "Follow";
            this.btnGithub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // _lblAboutInfo
            // 
            this._lblAboutInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblAboutInfo.AutoEllipsis = true;
            this._lblAboutInfo.AutoSize = true;
            this._lblAboutInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 11.75F);
            this._lblAboutInfo.ForeColor = System.Drawing.Color.Black;
            this._lblAboutInfo.Location = new System.Drawing.Point(13, 22);
            this._lblAboutInfo.Name = "_lblAboutInfo";
            this._lblAboutInfo.Size = new System.Drawing.Size(111, 21);
            this._lblAboutInfo.TabIndex = 197;
            this._lblAboutInfo.Text = "About this App";
            // 
            // lnkURLTwitter
            // 
            this.lnkURLTwitter.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkURLTwitter.AutoEllipsis = true;
            this.lnkURLTwitter.AutoSize = true;
            this.lnkURLTwitter.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkURLTwitter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkURLTwitter.LinkColor = System.Drawing.Color.DimGray;
            this.lnkURLTwitter.Location = new System.Drawing.Point(13, 71);
            this.lnkURLTwitter.Name = "lnkURLTwitter";
            this.lnkURLTwitter.Size = new System.Drawing.Size(126, 17);
            this.lnkURLTwitter.TabIndex = 199;
            this.lnkURLTwitter.TabStop = true;
            this.lnkURLTwitter.Text = "Follow dev on Twitter";
            this.lnkURLTwitter.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkURLTwitter_LinkClicked);
            // 
            // lnkURLReddit
            // 
            this.lnkURLReddit.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLReddit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkURLReddit.AutoEllipsis = true;
            this.lnkURLReddit.AutoSize = true;
            this.lnkURLReddit.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkURLReddit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkURLReddit.LinkColor = System.Drawing.Color.DimGray;
            this.lnkURLReddit.Location = new System.Drawing.Point(14, 107);
            this.lnkURLReddit.Name = "lnkURLReddit";
            this.lnkURLReddit.Size = new System.Drawing.Size(41, 17);
            this.lnkURLReddit.TabIndex = 201;
            this.lnkURLReddit.TabStop = true;
            this.lnkURLReddit.Text = "r/help";
            this.tt.SetToolTip(this.lnkURLReddit, "Get help on Reddit");
            this.lnkURLReddit.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLReddit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkURLReddit_LinkClicked);
            // 
            // lnkURLDev
            // 
            this.lnkURLDev.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkURLDev.AutoEllipsis = true;
            this.lnkURLDev.AutoSize = true;
            this.lnkURLDev.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkURLDev.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkURLDev.LinkColor = System.Drawing.Color.DimGray;
            this.lnkURLDev.Location = new System.Drawing.Point(13, 52);
            this.lnkURLDev.Name = "lnkURLDev";
            this.lnkURLDev.Size = new System.Drawing.Size(100, 17);
            this.lnkURLDev.TabIndex = 198;
            this.lnkURLDev.TabStop = true;
            this.lnkURLDev.Text = "Dev @Builtbybel";
            this.lnkURLDev.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLDev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkURLDev_LinkClicked);
            // 
            // lnkURLPayPal
            // 
            this.lnkURLPayPal.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLPayPal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkURLPayPal.AutoEllipsis = true;
            this.lnkURLPayPal.AutoSize = true;
            this.lnkURLPayPal.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkURLPayPal.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkURLPayPal.LinkColor = System.Drawing.Color.DimGray;
            this.lnkURLPayPal.Location = new System.Drawing.Point(14, 89);
            this.lnkURLPayPal.Name = "lnkURLPayPal";
            this.lnkURLPayPal.Size = new System.Drawing.Size(48, 17);
            this.lnkURLPayPal.TabIndex = 200;
            this.lnkURLPayPal.TabStop = true;
            this.lnkURLPayPal.Text = "Donate";
            this.lnkURLPayPal.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLPayPal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkURLPayPal_LinkClicked);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.pnlMain);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(926, 720);
            this.pnlForm.TabIndex = 2;
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            this.tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // contextMenuChevron
            // 
            this.contextMenuChevron.BackColor = System.Drawing.Color.White;
            this.contextMenuChevron.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuChevron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWizard,
            this.menuWizardInfo,
            this.menuPackages,
            this.menuPackagesInfo});
            this.contextMenuChevron.Name = "menuMain";
            this.contextMenuChevron.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuChevron.Size = new System.Drawing.Size(361, 92);
            // 
            // menuWizard
            // 
            this.menuWizard.Font = new System.Drawing.Font("Segoe UI Variable Text", 12.75F);
            this.menuWizard.Name = "menuWizard";
            this.menuWizard.Size = new System.Drawing.Size(360, 26);
            this.menuWizard.Text = "Get started";
            this.menuWizard.Click += new System.EventHandler(this.menuWizard_Click);
            // 
            // menuWizardInfo
            // 
            this.menuWizardInfo.BackColor = System.Drawing.Color.White;
            this.menuWizardInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuWizardInfo.Enabled = false;
            this.menuWizardInfo.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuWizardInfo.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.menuWizardInfo.Name = "menuWizardInfo";
            this.menuWizardInfo.Size = new System.Drawing.Size(300, 16);
            this.menuWizardInfo.Text = "Get to know Windows 11 step by step";
            // 
            // menuPackages
            // 
            this.menuPackages.Font = new System.Drawing.Font("Segoe UI Variable Text", 12.75F);
            this.menuPackages.Name = "menuPackages";
            this.menuPackages.Size = new System.Drawing.Size(360, 26);
            this.menuPackages.Text = "Install packages";
            this.menuPackages.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuPackages.Click += new System.EventHandler(this.menuPackages_Click);
            // 
            // menuPackagesInfo
            // 
            this.menuPackagesInfo.BackColor = System.Drawing.Color.White;
            this.menuPackagesInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuPackagesInfo.Enabled = false;
            this.menuPackagesInfo.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.menuPackagesInfo.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.menuPackagesInfo.Name = "menuPackagesInfo";
            this.menuPackagesInfo.Size = new System.Drawing.Size(300, 16);
            this.menuPackagesInfo.Text = "Install nifty Software packages";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 720);
            this.Controls.Add(this.pnlForm);
            this.MinimumSize = new System.Drawing.Size(942, 523);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloatynosy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlMain.ResumeLayout(false);
            this.pnlNavRight.ResumeLayout(false);
            this.pnlNavRight.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlRightSettings.ResumeLayout(false);
            this.pnlRightSettings.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.contextMenuChevron.ResumeLayout(false);
            this.contextMenuChevron.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label _lblAboutInfo;
        private System.Windows.Forms.LinkLabel lnkURLTwitter;
        private System.Windows.Forms.LinkLabel lnkURLDev;
        private System.Windows.Forms.LinkLabel lnkURLPayPal;
        private System.Windows.Forms.LinkLabel lnkURLReddit;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.CheckBox checkIgnoreLowIssues;
        private System.Windows.Forms.Panel pnlRightSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.CheckBox checkVersion;
        private System.Windows.Forms.Button btnAppBloatpilot;
        private System.Windows.Forms.Panel pnlNavRight;
        private System.Windows.Forms.Button btnMenuChevronDown;
        private System.Windows.Forms.ContextMenuStrip contextMenuChevron;
        private System.Windows.Forms.ToolStripMenuItem menuWizard;
        private System.Windows.Forms.ToolStripTextBox menuWizardInfo;
        private System.Windows.Forms.ToolStripMenuItem menuPackages;
        private System.Windows.Forms.ToolStripTextBox menuPackagesInfo;
        private System.Windows.Forms.LinkLabel lnkStargazers;
    }
}

