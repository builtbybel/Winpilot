namespace Bloatynosy.Views
{
    partial class WizardPageView
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssist = new System.Windows.Forms.Button();
            this.lnkConfigure = new System.Windows.Forms.LinkLabel();
            this.btnCustomize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(60, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(973, 26);
            this.lblHeader.TabIndex = 180;
            this.lblHeader.Text = "Setup Windows";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 179;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoEllipsis = true;
            this.btnHome.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(42, 82);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(212, 29);
            this.btnHome.TabIndex = 182;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoEllipsis = true;
            this.btnNext.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(42, 168);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(212, 29);
            this.btnNext.TabIndex = 183;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AutoEllipsis = true;
            this.btnPrev.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Location = new System.Drawing.Point(42, 133);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(212, 29);
            this.btnPrev.TabIndex = 184;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // cbTable
            // 
            this.cbTable.BackColor = System.Drawing.Color.White;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTable.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(42, 256);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(212, 25);
            this.cbTable.TabIndex = 185;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // pbView
            // 
            this.pbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbView.BackColor = System.Drawing.Color.Transparent;
            this.pbView.ErrorImage = null;
            this.pbView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbView.InitialImage = null;
            this.pbView.Location = new System.Drawing.Point(272, 42);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(779, 437);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbView.TabIndex = 186;
            this.pbView.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 189;
            this.label1.Text = "Jump to";
            // 
            // btnAssist
            // 
            this.btnAssist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssist.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAssist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssist.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssist.Location = new System.Drawing.Point(289, 447);
            this.btnAssist.Name = "btnAssist";
            this.btnAssist.Size = new System.Drawing.Size(762, 200);
            this.btnAssist.TabIndex = 190;
            this.btnAssist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssist.UseVisualStyleBackColor = true;
            // 
            // lnkConfigure
            // 
            this.lnkConfigure.ActiveLinkColor = System.Drawing.Color.Violet;
            this.lnkConfigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkConfigure.AutoEllipsis = true;
            this.lnkConfigure.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.lnkConfigure.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkConfigure.LinkColor = System.Drawing.Color.MediumOrchid;
            this.lnkConfigure.Location = new System.Drawing.Point(657, 668);
            this.lnkConfigure.Name = "lnkConfigure";
            this.lnkConfigure.Size = new System.Drawing.Size(160, 19);
            this.lnkConfigure.TabIndex = 192;
            this.lnkConfigure.TabStop = true;
            this.lnkConfigure.Text = "Configure settings";
            this.lnkConfigure.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigure_LinkClicked);
            // 
            // btnCustomize
            // 
            this.btnCustomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomize.AutoEllipsis = true;
            this.btnCustomize.BackColor = System.Drawing.Color.Orchid;
            this.btnCustomize.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCustomize.FlatAppearance.BorderSize = 0;
            this.btnCustomize.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomize.ForeColor = System.Drawing.Color.Black;
            this.btnCustomize.Location = new System.Drawing.Point(823, 661);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnCustomize.Size = new System.Drawing.Size(210, 35);
            this.btnCustomize.TabIndex = 218;
            this.btnCustomize.TabStop = false;
            this.btnCustomize.Text = "Customizations available";
            this.btnCustomize.UseVisualStyleBackColor = false;
            this.btnCustomize.Click += new System.EventHandler(this.btnCustomize_Click);
            // 
            // WizardPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.Controls.Add(this.btnCustomize);
            this.Controls.Add(this.lnkConfigure);
            this.Controls.Add(this.btnAssist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbView);
            this.Name = "WizardPageView";
            this.Size = new System.Drawing.Size(1054, 795);
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox cbTable;
        public System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssist;
        private System.Windows.Forms.LinkLabel lnkConfigure;
        private System.Windows.Forms.Button btnCustomize;
    }
}
