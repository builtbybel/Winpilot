namespace BloatyNosy
{
    partial class ModsPageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModsPageView));
            this.contextAppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuModEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnHMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lnkExploreMods = new System.Windows.Forms.LinkLabel();
            this.tabD = new System.Windows.Forms.TabControl();
            this.tabDescription = new System.Windows.Forms.TabPage();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.tabCode = new System.Windows.Forms.TabPage();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.lnkCode = new System.Windows.Forms.LinkLabel();
            this.lnkDesc = new System.Windows.Forms.LinkLabel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnApply = new System.Windows.Forms.Button();
            this.listMods = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contextAppMenu.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabD.SuspendLayout();
            this.tabDescription.SuspendLayout();
            this.tabCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextAppMenu
            // 
            this.contextAppMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextAppMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextAppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModEdit});
            this.contextAppMenu.Name = "menuMain";
            this.contextAppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextAppMenu.Size = new System.Drawing.Size(122, 26);
            this.contextAppMenu.Text = "Info";
            // 
            // menuModEdit
            // 
            this.menuModEdit.Name = "menuModEdit";
            this.menuModEdit.Size = new System.Drawing.Size(121, 22);
            this.menuModEdit.Text = "Edit Mod";
            this.menuModEdit.Click += new System.EventHandler(this.menuModEdit_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.AutoSize = true;
            this.pnlForm.Controls.Add(this.pnlMain);
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1054, 795);
            this.pnlForm.TabIndex = 193;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Controls.Add(this.btnHMenu);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.lnkExploreMods);
            this.pnlMain.Controls.Add(this.tabD);
            this.pnlMain.Controls.Add(this.textSearch);
            this.pnlMain.Controls.Add(this.lnkCode);
            this.pnlMain.Controls.Add(this.lnkDesc);
            this.pnlMain.Controls.Add(this.progress);
            this.pnlMain.Controls.Add(this.btnApply);
            this.pnlMain.Controls.Add(this.listMods);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1054, 795);
            this.pnlMain.TabIndex = 197;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.HotPink;
            this.lblStatus.Location = new System.Drawing.Point(88, 106);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 17);
            this.lblStatus.TabIndex = 206;
            this.lblStatus.Text = "Mods installed";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeader.Location = new System.Drawing.Point(87, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(114, 26);
            this.lblHeader.TabIndex = 204;
            this.lblHeader.Text = "WinModder";
            // 
            // btnHMenu
            // 
            this.btnHMenu.FlatAppearance.BorderSize = 0;
            this.btnHMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnHMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHMenu.ForeColor = System.Drawing.Color.Black;
            this.btnHMenu.Location = new System.Drawing.Point(35, 0);
            this.btnHMenu.Name = "btnHMenu";
            this.btnHMenu.Size = new System.Drawing.Size(42, 38);
            this.btnHMenu.TabIndex = 203;
            this.btnHMenu.Text = "...";
            this.btnHMenu.UseVisualStyleBackColor = true;
            this.btnHMenu.Click += new System.EventHandler(this.btnHMenu_Click);
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
            this.btnBack.TabIndex = 202;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lnkExploreMods
            // 
            this.lnkExploreMods.ActiveLinkColor = System.Drawing.Color.DeepPink;
            this.lnkExploreMods.AutoSize = true;
            this.lnkExploreMods.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkExploreMods.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkExploreMods.LinkColor = System.Drawing.Color.HotPink;
            this.lnkExploreMods.Location = new System.Drawing.Point(229, 4);
            this.lnkExploreMods.Name = "lnkExploreMods";
            this.lnkExploreMods.Size = new System.Drawing.Size(129, 26);
            this.lnkExploreMods.TabIndex = 201;
            this.lnkExploreMods.TabStop = true;
            this.lnkExploreMods.Text = "Explore Mods";
            this.lnkExploreMods.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExploreMods_LinkClicked);
            // 
            // tabD
            // 
            this.tabD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabD.Controls.Add(this.tabDescription);
            this.tabD.Controls.Add(this.tabCode);
            this.tabD.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabD.Location = new System.Drawing.Point(92, 562);
            this.tabD.Name = "tabD";
            this.tabD.SelectedIndex = 0;
            this.tabD.Size = new System.Drawing.Size(857, 171);
            this.tabD.TabIndex = 194;
            // 
            // tabDescription
            // 
            this.tabDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tabDescription.Controls.Add(this.rtbDesc);
            this.tabDescription.Location = new System.Drawing.Point(4, 24);
            this.tabDescription.Name = "tabDescription";
            this.tabDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tabDescription.Size = new System.Drawing.Size(849, 143);
            this.tabDescription.TabIndex = 0;
            this.tabDescription.Text = "Description";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDesc.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDesc.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbDesc.Location = new System.Drawing.Point(17, 17);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ReadOnly = true;
            this.rtbDesc.Size = new System.Drawing.Size(819, 120);
            this.rtbDesc.TabIndex = 11;
            this.rtbDesc.Text = resources.GetString("rtbDesc.Text");
            this.rtbDesc.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbDesc_LinkClicked);
            // 
            // tabCode
            // 
            this.tabCode.BackColor = System.Drawing.SystemColors.Control;
            this.tabCode.Controls.Add(this.rtbCode);
            this.tabCode.Location = new System.Drawing.Point(4, 24);
            this.tabCode.Name = "tabCode";
            this.tabCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabCode.Size = new System.Drawing.Size(849, 143);
            this.tabCode.TabIndex = 1;
            this.tabCode.Text = "Code";
            // 
            // rtbCode
            // 
            this.rtbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCode.BackColor = System.Drawing.SystemColors.Control;
            this.rtbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCode.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCode.ForeColor = System.Drawing.Color.Gray;
            this.rtbCode.Location = new System.Drawing.Point(17, 17);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.ReadOnly = true;
            this.rtbCode.Size = new System.Drawing.Size(826, 120);
            this.rtbCode.TabIndex = 12;
            this.rtbCode.Text = "#Follow this project on GitHub.\nStart-Process https://github.com/builtbybel/Deblo" +
    "os\n";
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.Gray;
            this.textSearch.Location = new System.Drawing.Point(485, 60);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(122, 23);
            this.textSearch.TabIndex = 199;
            this.textSearch.Text = "Search...";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // lnkCode
            // 
            this.lnkCode.ActiveLinkColor = System.Drawing.Color.DeepPink;
            this.lnkCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkCode.AutoSize = true;
            this.lnkCode.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCode.LinkColor = System.Drawing.Color.HotPink;
            this.lnkCode.Location = new System.Drawing.Point(172, 531);
            this.lnkCode.Name = "lnkCode";
            this.lnkCode.Size = new System.Drawing.Size(38, 17);
            this.lnkCode.TabIndex = 198;
            this.lnkCode.TabStop = true;
            this.lnkCode.Text = "Code";
            this.lnkCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCode_LinkClicked);
            // 
            // lnkDesc
            // 
            this.lnkDesc.ActiveLinkColor = System.Drawing.Color.DeepPink;
            this.lnkDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkDesc.AutoSize = true;
            this.lnkDesc.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDesc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDesc.LinkColor = System.Drawing.Color.HotPink;
            this.lnkDesc.Location = new System.Drawing.Point(91, 531);
            this.lnkDesc.Name = "lnkDesc";
            this.lnkDesc.Size = new System.Drawing.Size(71, 17);
            this.lnkDesc.TabIndex = 197;
            this.lnkDesc.TabStop = true;
            this.lnkDesc.Text = "Description";
            this.lnkDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDesc_LinkClicked);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(92, 129);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(857, 5);
            this.progress.TabIndex = 196;
            this.progress.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(96, 752);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // listMods
            // 
            this.listMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMods.BackColor = System.Drawing.SystemColors.Control;
            this.listMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMods.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMods.FormattingEnabled = true;
            this.listMods.Location = new System.Drawing.Point(92, 140);
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(857, 342);
            this.listMods.TabIndex = 195;
            this.listMods.SelectedIndexChanged += new System.EventHandler(this.listMods_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(870, 752);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ModsPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlForm);
            this.Name = "ModsPageView";
            this.Size = new System.Drawing.Size(1054, 795);
            this.contextAppMenu.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tabD.ResumeLayout(false);
            this.tabDescription.ResumeLayout(false);
            this.tabCode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextAppMenu;
        private System.Windows.Forms.ToolStripMenuItem menuModEdit;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TabControl tabD;
        private System.Windows.Forms.TabPage tabDescription;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.TabPage tabCode;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.LinkLabel lnkCode;
        private System.Windows.Forms.LinkLabel lnkDesc;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckedListBox listMods;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnHMenu;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.LinkLabel lnkExploreMods;
        private System.Windows.Forms.Label lblStatus;
    }
}
