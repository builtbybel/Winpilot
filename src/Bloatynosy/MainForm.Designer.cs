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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblQRInfo = new System.Windows.Forms.Label();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.checkVersion = new System.Windows.Forms.CheckBox();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.lblQRInfo);
            this.pnlMain.Controls.Add(this.picQR);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Controls.Add(this.checkVersion);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(926, 720);
            this.pnlMain.TabIndex = 0;
            // 
            // lblQRInfo
            // 
            this.lblQRInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQRInfo.AutoSize = true;
            this.lblQRInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQRInfo.Location = new System.Drawing.Point(756, 543);
            this.lblQRInfo.Name = "lblQRInfo";
            this.lblQRInfo.Size = new System.Drawing.Size(135, 17);
            this.lblQRInfo.TabIndex = 223;
            this.lblQRInfo.Text = "First steps with the app";
            this.lblQRInfo.Visible = false;
            // 
            // picQR
            // 
            this.picQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picQR.Location = new System.Drawing.Point(756, 562);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(143, 146);
            this.picQR.TabIndex = 222;
            this.picQR.TabStop = false;
            this.picQR.Visible = false;
            this.picQR.MouseEnter += new System.EventHandler(this.picQR_MouseEnter);
            this.picQR.MouseLeave += new System.EventHandler(this.picQR_MouseLeave);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(59, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(104, 26);
            this.lblHeader.TabIndex = 221;
            this.lblHeader.Text = "Dashboard";
            // 
            // checkVersion
            // 
            this.checkVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkVersion.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkVersion.AutoSize = true;
            this.checkVersion.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkVersion.FlatAppearance.BorderSize = 0;
            this.checkVersion.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite;
            this.checkVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkVersion.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F);
            this.checkVersion.ForeColor = System.Drawing.Color.Black;
            this.checkVersion.Location = new System.Drawing.Point(900, 0);
            this.checkVersion.Name = "checkVersion";
            this.checkVersion.Size = new System.Drawing.Size(23, 27);
            this.checkVersion.TabIndex = 216;
            this.checkVersion.Text = "x";
            this.checkVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkVersion.UseVisualStyleBackColor = true;
            this.checkVersion.CheckedChanged += new System.EventHandler(this.checkVersion_CheckedChanged);
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
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.CheckBox checkVersion;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Label lblQRInfo;
    }
}

