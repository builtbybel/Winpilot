namespace Bloatynosy.Views
{
    partial class NosyPageView
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tvwFeatures = new System.Windows.Forms.TreeView();
            this.btnHamburger = new System.Windows.Forms.Button();
            this.contextKebapMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textHeaderAppInfo = new System.Windows.Forms.ToolStripTextBox();
            this.textHeaderExperience = new System.Windows.Forms.ToolStripTextBox();
            this.cbProfiles = new System.Windows.Forms.ToolStripComboBox();
            this.menuLoadProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNotePlugins = new System.Windows.Forms.Button();
            this.contextAppMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAnalyzeThis = new System.Windows.Forms.ToolStripMenuItem();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lnkStatus = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.border = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.contextKebapMenu.SuspendLayout();
            this.contextAppMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwFeatures
            // 
            this.tvwFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwFeatures.BackColor = System.Drawing.Color.White;
            this.tvwFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwFeatures.CheckBoxes = true;
            this.tvwFeatures.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F);
            this.tvwFeatures.ForeColor = System.Drawing.Color.Black;
            this.tvwFeatures.FullRowSelect = true;
            this.tvwFeatures.ItemHeight = 37;
            this.tvwFeatures.LineColor = System.Drawing.Color.DodgerBlue;
            this.tvwFeatures.Location = new System.Drawing.Point(48, 14);
            this.tvwFeatures.Name = "tvwFeatures";
            this.tvwFeatures.ShowLines = false;
            this.tvwFeatures.ShowNodeToolTips = true;
            this.tvwFeatures.ShowRootLines = false;
            this.tvwFeatures.Size = new System.Drawing.Size(195, 692);
            this.tvwFeatures.TabIndex = 169;
            this.tvwFeatures.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwFeatures_AfterCheck);
            this.tvwFeatures.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwFeatures_AfterSelect);
            this.tvwFeatures.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvwFeatures_MouseUp);
            // 
            // btnHamburger
            // 
            this.btnHamburger.FlatAppearance.BorderSize = 0;
            this.btnHamburger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamburger.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHamburger.ForeColor = System.Drawing.Color.Black;
            this.btnHamburger.Location = new System.Drawing.Point(3, 2);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(42, 38);
            this.btnHamburger.TabIndex = 176;
            this.btnHamburger.Text = "...";
            this.btnHamburger.UseVisualStyleBackColor = true;
            this.btnHamburger.Click += new System.EventHandler(this.btnHamburger_Click);
            // 
            // contextKebapMenu
            // 
            this.contextKebapMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextKebapMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextKebapMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textHeaderAppInfo,
            this.textHeaderExperience,
            this.cbProfiles,
            this.menuLoadProfile,
            this.menuExportProfile});
            this.contextKebapMenu.Name = "menuMain";
            this.contextKebapMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextKebapMenu.Size = new System.Drawing.Size(261, 139);
            // 
            // textHeaderAppInfo
            // 
            this.textHeaderAppInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textHeaderAppInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeaderAppInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeaderAppInfo.ForeColor = System.Drawing.Color.Gray;
            this.textHeaderAppInfo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 10);
            this.textHeaderAppInfo.Name = "textHeaderAppInfo";
            this.textHeaderAppInfo.ReadOnly = true;
            this.textHeaderAppInfo.Size = new System.Drawing.Size(200, 18);
            this.textHeaderAppInfo.Text = "App-Settings";
            // 
            // textHeaderExperience
            // 
            this.textHeaderExperience.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textHeaderExperience.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeaderExperience.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeaderExperience.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.textHeaderExperience.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.textHeaderExperience.Name = "textHeaderExperience";
            this.textHeaderExperience.Size = new System.Drawing.Size(200, 16);
            this.textHeaderExperience.Text = "Choose Experience profile";
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
            // btnNotePlugins
            // 
            this.btnNotePlugins.AutoSize = true;
            this.btnNotePlugins.FlatAppearance.BorderSize = 0;
            this.btnNotePlugins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNotePlugins.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.25F);
            this.btnNotePlugins.ForeColor = System.Drawing.Color.DeepPink;
            this.btnNotePlugins.Location = new System.Drawing.Point(3, 44);
            this.btnNotePlugins.Name = "btnNotePlugins";
            this.btnNotePlugins.Size = new System.Drawing.Size(42, 38);
            this.btnNotePlugins.TabIndex = 177;
            this.btnNotePlugins.Text = "...";
            this.btnNotePlugins.UseVisualStyleBackColor = true;
            this.btnNotePlugins.Click += new System.EventHandler(this.btnNotePlugins_Click);
            // 
            // contextAppMenuOptions
            // 
            this.contextAppMenuOptions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextAppMenuOptions.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextAppMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAnalyzeThis});
            this.contextAppMenuOptions.Name = "menuMain";
            this.contextAppMenuOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextAppMenuOptions.Size = new System.Drawing.Size(163, 30);
            // 
            // menuAnalyzeThis
            // 
            this.menuAnalyzeThis.Name = "menuAnalyzeThis";
            this.menuAnalyzeThis.Size = new System.Drawing.Size(162, 26);
            this.menuAnalyzeThis.Text = "Analyze this";
            this.menuAnalyzeThis.Click += new System.EventHandler(this.menuAnalyzeThis_Click);
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.AutoScroll = true;
            this.sc.Panel1.Controls.Add(this.btnAnalyze);
            this.sc.Panel1.Controls.Add(this.tvwFeatures);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.AutoScroll = true;
            this.sc.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.sc.Panel2.Controls.Add(this.lnkStatus);
            this.sc.Panel2.Controls.Add(this.lblHeader);
            this.sc.Panel2.Controls.Add(this.progress);
            this.sc.Panel2.Controls.Add(this.rtbLog);
            this.sc.Panel2.Controls.Add(this.btnApply);
            this.sc.Panel2.Controls.Add(this.btnRestore);
            this.sc.Panel2.Controls.Add(this.border);
            this.sc.Size = new System.Drawing.Size(942, 759);
            this.sc.SplitterDistance = 246;
            this.sc.TabIndex = 208;
            this.sc.TabStop = false;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnalyze.AutoEllipsis = true;
            this.btnAnalyze.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAnalyze.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAnalyze.FlatAppearance.BorderSize = 0;
            this.btnAnalyze.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(48, 705);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAnalyze.Size = new System.Drawing.Size(120, 35);
            this.btnAnalyze.TabIndex = 215;
            this.btnAnalyze.TabStop = false;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lnkStatus
            // 
            this.lnkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStatus.AutoEllipsis = true;
            this.lnkStatus.BackColor = System.Drawing.Color.Transparent;
            this.lnkStatus.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F);
            this.lnkStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkStatus.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkStatus.Location = new System.Drawing.Point(16, 645);
            this.lnkStatus.Name = "lnkStatus";
            this.lnkStatus.Size = new System.Drawing.Size(437, 19);
            this.lnkStatus.TabIndex = 214;
            this.lnkStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStatus_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(14, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(311, 32);
            this.lblHeader.TabIndex = 210;
            this.lblHeader.Text = "Dashboard";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(9, 667);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(427, 5);
            this.progress.TabIndex = 166;
            this.progress.Visible = false;
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.ForeColor = System.Drawing.Color.DimGray;
            this.rtbLog.HideSelection = false;
            this.rtbLog.Location = new System.Drawing.Point(20, 106);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(433, 536);
            this.rtbLog.TabIndex = 138;
            this.rtbLog.Text = "Select all the ways you don\'t plan to use your device to get personalized tip, ad" +
    "s, recommendation within Microsoft expericences. You can always revert these Set" +
    "tings to default.";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnApply.AutoEllipsis = true;
            this.btnApply.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(104, 705);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(120, 35);
            this.btnApply.TabIndex = 27;
            this.btnApply.TabStop = false;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRestore.AutoEllipsis = true;
            this.btnRestore.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(230, 705);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnRestore.Size = new System.Drawing.Size(120, 35);
            this.btnRestore.TabIndex = 178;
            this.btnRestore.TabStop = false;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border.BackColor = System.Drawing.SystemColors.Control;
            this.border.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.border.FlatAppearance.BorderSize = 0;
            this.border.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.border.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.border.Location = new System.Drawing.Point(3, 14);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(462, 677);
            this.border.TabIndex = 204;
            this.border.TabStop = false;
            this.border.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.border.UseVisualStyleBackColor = false;
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.btnNotePlugins);
            this.pnlNav.Controls.Add(this.btnHamburger);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(49, 759);
            this.pnlNav.TabIndex = 209;
            // 
            // NosyPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.sc);
            this.Name = "NosyPageView";
            this.Size = new System.Drawing.Size(942, 759);
            this.contextKebapMenu.ResumeLayout(false);
            this.contextKebapMenu.PerformLayout();
            this.contextAppMenuOptions.ResumeLayout(false);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TreeView tvwFeatures;
        private System.Windows.Forms.Button btnHamburger;
        private System.Windows.Forms.ContextMenuStrip contextKebapMenu;
        private System.Windows.Forms.ToolStripTextBox textHeaderAppInfo;
        private System.Windows.Forms.ToolStripTextBox textHeaderExperience;
        private System.Windows.Forms.ToolStripComboBox cbProfiles;
        private System.Windows.Forms.ToolStripMenuItem menuLoadProfile;
        private System.Windows.Forms.ToolStripMenuItem menuExportProfile;
        private System.Windows.Forms.Button btnNotePlugins;
        private System.Windows.Forms.ContextMenuStrip contextAppMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuAnalyzeThis;
        public System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button border;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.LinkLabel lnkStatus;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}
