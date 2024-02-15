namespace Bloatynosy.Views
{
    partial class SettingsPageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPageView));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnGithub = new System.Windows.Forms.Button();
            this.lnkStargazers = new System.Windows.Forms.LinkLabel();
            this.lnkVoting = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditBloatESignature = new System.Windows.Forms.Button();
            this.btnOpenProfilesDir = new System.Windows.Forms.Button();
            this.btnOpenPluginsDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnURLDonate = new System.Windows.Forms.Button();
            this.btnAppPackages = new System.Windows.Forms.Button();
            this.btnAppWizard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkURLTwitter = new System.Windows.Forms.LinkLabel();
            this.lnkURLHelp = new System.Windows.Forms.LinkLabel();
            this.lnkURLDev = new System.Windows.Forms.LinkLabel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnBack.Location = new System.Drawing.Point(3, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 177;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.Location = new System.Drawing.Point(277, 46);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(323, 36);
            this.lblHeader.TabIndex = 222;
            this.lblHeader.Text = "Settings";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.AutoScroll = true;
            this.pnlMain.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.pnlMain.Controls.Add(this.btnGithub);
            this.pnlMain.Controls.Add(this.lnkStargazers);
            this.pnlMain.Controls.Add(this.lnkVoting);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.btnEditBloatESignature);
            this.pnlMain.Controls.Add(this.btnOpenProfilesDir);
            this.pnlMain.Controls.Add(this.btnOpenPluginsDir);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.btnURLDonate);
            this.pnlMain.Controls.Add(this.btnAppPackages);
            this.pnlMain.Controls.Add(this.btnAppWizard);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Controls.Add(this.lnkURLTwitter);
            this.pnlMain.Controls.Add(this.lnkURLHelp);
            this.pnlMain.Controls.Add(this.lnkURLDev);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(942, 759);
            this.pnlMain.TabIndex = 223;
            // 
            // btnGithub
            // 
            this.btnGithub.AutoSize = true;
            this.btnGithub.BackColor = System.Drawing.Color.Transparent;
            this.btnGithub.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGithub.FlatAppearance.BorderSize = 0;
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F);
            this.btnGithub.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnGithub.Image = ((System.Drawing.Image)(resources.GetObject("btnGithub.Image")));
            this.btnGithub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGithub.Location = new System.Drawing.Point(397, 527);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnGithub.Size = new System.Drawing.Size(106, 30);
            this.btnGithub.TabIndex = 233;
            this.btnGithub.TabStop = false;
            this.btnGithub.Text = "Github";
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // lnkStargazers
            // 
            this.lnkStargazers.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkStargazers.AutoEllipsis = true;
            this.lnkStargazers.BackColor = System.Drawing.Color.Transparent;
            this.lnkStargazers.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkStargazers.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkStargazers.LinkColor = System.Drawing.Color.Black;
            this.lnkStargazers.Location = new System.Drawing.Point(509, 536);
            this.lnkStargazers.Name = "lnkStargazers";
            this.lnkStargazers.Size = new System.Drawing.Size(105, 17);
            this.lnkStargazers.TabIndex = 234;
            this.lnkStargazers.TabStop = true;
            this.lnkStargazers.Text = "Error fetching Github stargazers";
            this.lnkStargazers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkStargazers.Visible = false;
            this.lnkStargazers.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkStargazers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStargazers_LinkClicked);
            // 
            // lnkVoting
            // 
            this.lnkVoting.AutoEllipsis = true;
            this.lnkVoting.BackColor = System.Drawing.Color.MistyRose;
            this.lnkVoting.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkVoting.Location = new System.Drawing.Point(607, 7);
            this.lnkVoting.Name = "lnkVoting";
            this.lnkVoting.Size = new System.Drawing.Size(217, 23);
            this.lnkVoting.TabIndex = 232;
            this.lnkVoting.TabStop = true;
            this.lnkVoting.Text = "https://www.builtbybel.com/blog/bloatynosy-is-now-x";
            this.lnkVoting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVoting_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(773, 30);
            this.label3.TabIndex = 231;
            this.label3.Text = "Vote here for a name change from Bloatynosy to Appstrip or?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditBloatESignature
            // 
            this.btnEditBloatESignature.AutoEllipsis = true;
            this.btnEditBloatESignature.BackColor = System.Drawing.Color.GhostWhite;
            this.btnEditBloatESignature.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnEditBloatESignature.FlatAppearance.BorderSize = 0;
            this.btnEditBloatESignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBloatESignature.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBloatESignature.ForeColor = System.Drawing.Color.Black;
            this.btnEditBloatESignature.Location = new System.Drawing.Point(277, 279);
            this.btnEditBloatESignature.Name = "btnEditBloatESignature";
            this.btnEditBloatESignature.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnEditBloatESignature.Size = new System.Drawing.Size(323, 26);
            this.btnEditBloatESignature.TabIndex = 230;
            this.btnEditBloatESignature.TabStop = false;
            this.btnEditBloatESignature.Text = "Edit BLOAT-E signature";
            this.btnEditBloatESignature.UseVisualStyleBackColor = false;
            this.btnEditBloatESignature.Click += new System.EventHandler(this.btnEditBloatESignature_Click);
            // 
            // btnOpenProfilesDir
            // 
            this.btnOpenProfilesDir.AutoEllipsis = true;
            this.btnOpenProfilesDir.BackColor = System.Drawing.Color.GhostWhite;
            this.btnOpenProfilesDir.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnOpenProfilesDir.FlatAppearance.BorderSize = 0;
            this.btnOpenProfilesDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenProfilesDir.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProfilesDir.ForeColor = System.Drawing.Color.Black;
            this.btnOpenProfilesDir.Location = new System.Drawing.Point(277, 247);
            this.btnOpenProfilesDir.Name = "btnOpenProfilesDir";
            this.btnOpenProfilesDir.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnOpenProfilesDir.Size = new System.Drawing.Size(323, 26);
            this.btnOpenProfilesDir.TabIndex = 229;
            this.btnOpenProfilesDir.TabStop = false;
            this.btnOpenProfilesDir.Text = "Open profiles directory";
            this.btnOpenProfilesDir.UseVisualStyleBackColor = false;
            this.btnOpenProfilesDir.Click += new System.EventHandler(this.btnOpenProfilesDir_Click);
            // 
            // btnOpenPluginsDir
            // 
            this.btnOpenPluginsDir.AutoEllipsis = true;
            this.btnOpenPluginsDir.BackColor = System.Drawing.Color.GhostWhite;
            this.btnOpenPluginsDir.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnOpenPluginsDir.FlatAppearance.BorderSize = 0;
            this.btnOpenPluginsDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPluginsDir.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPluginsDir.ForeColor = System.Drawing.Color.Black;
            this.btnOpenPluginsDir.Location = new System.Drawing.Point(277, 217);
            this.btnOpenPluginsDir.Name = "btnOpenPluginsDir";
            this.btnOpenPluginsDir.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnOpenPluginsDir.Size = new System.Drawing.Size(323, 26);
            this.btnOpenPluginsDir.TabIndex = 228;
            this.btnOpenPluginsDir.TabStop = false;
            this.btnOpenPluginsDir.Text = "Open plugins directory";
            this.btnOpenPluginsDir.UseVisualStyleBackColor = false;
            this.btnOpenPluginsDir.Click += new System.EventHandler(this.btnOpenPluginsDir_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.25F);
            this.label2.Location = new System.Drawing.Point(170, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(654, 65);
            this.label2.TabIndex = 227;
            this.label2.Text = "Enhance your Windows 11 experience with a dedicated app designed to strip away un" +
    "wanted features.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnURLDonate
            // 
            this.btnURLDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnURLDonate.BackColor = System.Drawing.Color.Orange;
            this.btnURLDonate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnURLDonate.FlatAppearance.BorderSize = 4;
            this.btnURLDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnURLDonate.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnURLDonate.Location = new System.Drawing.Point(795, 716);
            this.btnURLDonate.Name = "btnURLDonate";
            this.btnURLDonate.Size = new System.Drawing.Size(112, 40);
            this.btnURLDonate.TabIndex = 226;
            this.btnURLDonate.Text = "Donate";
            this.btnURLDonate.UseVisualStyleBackColor = false;
            this.btnURLDonate.Click += new System.EventHandler(this.btnURLDonate_Click);
            // 
            // btnAppPackages
            // 
            this.btnAppPackages.AutoEllipsis = true;
            this.btnAppPackages.BackColor = System.Drawing.Color.Plum;
            this.btnAppPackages.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAppPackages.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppPackages.ForeColor = System.Drawing.Color.Black;
            this.btnAppPackages.Location = new System.Drawing.Point(277, 148);
            this.btnAppPackages.Name = "btnAppPackages";
            this.btnAppPackages.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAppPackages.Size = new System.Drawing.Size(323, 37);
            this.btnAppPackages.TabIndex = 225;
            this.btnAppPackages.TabStop = false;
            this.btnAppPackages.Text = "Install packages";
            this.btnAppPackages.UseVisualStyleBackColor = false;
            this.btnAppPackages.Click += new System.EventHandler(this.btnAppPackages_Click);
            // 
            // btnAppWizard
            // 
            this.btnAppWizard.AutoEllipsis = true;
            this.btnAppWizard.BackColor = System.Drawing.Color.Plum;
            this.btnAppWizard.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAppWizard.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppWizard.ForeColor = System.Drawing.Color.Black;
            this.btnAppWizard.Location = new System.Drawing.Point(277, 105);
            this.btnAppWizard.Name = "btnAppWizard";
            this.btnAppWizard.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAppWizard.Size = new System.Drawing.Size(323, 37);
            this.btnAppWizard.TabIndex = 224;
            this.btnAppWizard.TabStop = false;
            this.btnAppWizard.Text = "Run Wizard";
            this.btnAppWizard.UseVisualStyleBackColor = false;
            this.btnAppWizard.Click += new System.EventHandler(this.btnAppWizard_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(277, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 36);
            this.label1.TabIndex = 223;
            this.label1.Text = "About";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnkURLTwitter
            // 
            this.lnkURLTwitter.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLTwitter.AutoEllipsis = true;
            this.lnkURLTwitter.AutoSize = true;
            this.lnkURLTwitter.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkURLTwitter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkURLTwitter.LinkColor = System.Drawing.Color.DimGray;
            this.lnkURLTwitter.Location = new System.Drawing.Point(394, 661);
            this.lnkURLTwitter.Name = "lnkURLTwitter";
            this.lnkURLTwitter.Size = new System.Drawing.Size(126, 17);
            this.lnkURLTwitter.TabIndex = 199;
            this.lnkURLTwitter.TabStop = true;
            this.lnkURLTwitter.Text = "Follow dev on Twitter";
            this.lnkURLTwitter.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkURLTwitter_LinkClicked);
            // 
            // lnkURLHelp
            // 
            this.lnkURLHelp.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLHelp.AutoEllipsis = true;
            this.lnkURLHelp.AutoSize = true;
            this.lnkURLHelp.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkURLHelp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkURLHelp.LinkColor = System.Drawing.Color.DimGray;
            this.lnkURLHelp.Location = new System.Drawing.Point(395, 680);
            this.lnkURLHelp.Name = "lnkURLHelp";
            this.lnkURLHelp.Size = new System.Drawing.Size(41, 17);
            this.lnkURLHelp.TabIndex = 201;
            this.lnkURLHelp.TabStop = true;
            this.lnkURLHelp.Text = "r/help";
            this.lnkURLHelp.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkURLHelp_LinkClicked);
            // 
            // lnkURLDev
            // 
            this.lnkURLDev.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLDev.AutoEllipsis = true;
            this.lnkURLDev.AutoSize = true;
            this.lnkURLDev.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkURLDev.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkURLDev.LinkColor = System.Drawing.Color.DimGray;
            this.lnkURLDev.Location = new System.Drawing.Point(394, 642);
            this.lnkURLDev.Name = "lnkURLDev";
            this.lnkURLDev.Size = new System.Drawing.Size(100, 17);
            this.lnkURLDev.TabIndex = 198;
            this.lnkURLDev.TabStop = true;
            this.lnkURLDev.Text = "Dev @Builtbybel";
            this.lnkURLDev.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkURLDev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkURLDev_LinkClicked);
            // 
            // SettingsPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pnlMain);
            this.Name = "SettingsPageView";
            this.Size = new System.Drawing.Size(942, 759);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.LinkLabel lnkURLTwitter;
        private System.Windows.Forms.LinkLabel lnkURLHelp;
        private System.Windows.Forms.LinkLabel lnkURLDev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppPackages;
        private System.Windows.Forms.Button btnAppWizard;
        private System.Windows.Forms.Button btnURLDonate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenPluginsDir;
        private System.Windows.Forms.Button btnOpenProfilesDir;
        private System.Windows.Forms.Button btnEditBloatESignature;
        private System.Windows.Forms.LinkLabel lnkVoting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.LinkLabel lnkStargazers;
    }
}
