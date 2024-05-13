namespace Views
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
            this.linkAppInfo = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.linkFollow = new System.Windows.Forms.LinkLabel();
            this.lblDev = new System.Windows.Forms.Label();
            this.linkCreditsAppIcon = new System.Windows.Forms.LinkLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLicensesClippit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkAppInfo
            // 
            this.linkAppInfo.AutoEllipsis = true;
            this.linkAppInfo.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F);
            this.linkAppInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAppInfo.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkAppInfo.Location = new System.Drawing.Point(35, 108);
            this.linkAppInfo.Name = "linkAppInfo";
            this.linkAppInfo.Size = new System.Drawing.Size(315, 24);
            this.linkAppInfo.TabIndex = 6;
            this.linkAppInfo.TabStop = true;
            this.linkAppInfo.Text = "More infos about this app";
            this.linkAppInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkAppInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAppInfos_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVersion.Location = new System.Drawing.Point(20, 52);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(53, 17);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "Version";
            // 
            // linkFollow
            // 
            this.linkFollow.AutoEllipsis = true;
            this.linkFollow.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFollow.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkFollow.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.linkFollow.Location = new System.Drawing.Point(35, 135);
            this.linkFollow.Name = "linkFollow";
            this.linkFollow.Size = new System.Drawing.Size(315, 24);
            this.linkFollow.TabIndex = 9;
            this.linkFollow.TabStop = true;
            this.linkFollow.Text = "Follow on GitHub";
            this.linkFollow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkFollow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFollow_LinkClicked);
            // 
            // lblDev
            // 
            this.lblDev.AutoEllipsis = true;
            this.lblDev.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDev.Location = new System.Drawing.Point(35, 80);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(315, 24);
            this.lblDev.TabIndex = 10;
            this.lblDev.Text = "A Belim app creation © 2024";
            this.lblDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkCreditsAppIcon
            // 
            this.linkCreditsAppIcon.AutoEllipsis = true;
            this.linkCreditsAppIcon.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCreditsAppIcon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCreditsAppIcon.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkCreditsAppIcon.Location = new System.Drawing.Point(35, 199);
            this.linkCreditsAppIcon.Name = "linkCreditsAppIcon";
            this.linkCreditsAppIcon.Size = new System.Drawing.Size(315, 24);
            this.linkCreditsAppIcon.TabIndex = 11;
            this.linkCreditsAppIcon.TabStop = true;
            this.linkCreditsAppIcon.Text = "Icon credits go to at Firecube";
            this.linkCreditsAppIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkCreditsAppIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreditsAppIcon_LinkClicked);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 25);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSettings.Location = new System.Drawing.Point(41, 3);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(109, 17);
            this.lblSettings.TabIndex = 13;
            this.lblSettings.Text = "App Information";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Third-party licenses";
            // 
            // linkLicensesClippit
            // 
            this.linkLicensesClippit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLicensesClippit.AutoEllipsis = true;
            this.linkLicensesClippit.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLicensesClippit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLicensesClippit.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLicensesClippit.Location = new System.Drawing.Point(35, 232);
            this.linkLicensesClippit.Name = "linkLicensesClippit";
            this.linkLicensesClippit.Size = new System.Drawing.Size(315, 33);
            this.linkLicensesClippit.TabIndex = 15;
            this.linkLicensesClippit.TabStop = true;
            this.linkLicensesClippit.Text = "Clippit is a registered trademark of © Microsoft Corporation.";
            this.linkLicensesClippit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLicensesClippit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLicensesClippit_LinkClicked);
            // 
            // SettingsPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.linkLicensesClippit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.linkCreditsAppIcon);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.linkFollow);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.linkAppInfo);
            this.Name = "SettingsPageView";
            this.Size = new System.Drawing.Size(350, 643);
            this.Load += new System.EventHandler(this.SettingsPageView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkAppInfo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linkFollow;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.LinkLabel linkCreditsAppIcon;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLicensesClippit;
    }
}
