namespace Bloatynosy.Views
{
    partial class BloatyPageView
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
            System.Windows.Forms.ToolStripMenuItem menuAppsExport;
            this.listRemove = new System.Windows.Forms.ListBox();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.listApps = new System.Windows.Forms.ListBox();
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.picAppsPoster = new System.Windows.Forms.PictureBox();
            this.lblBloatOpt1 = new System.Windows.Forms.LinkLabel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnMenuGripperBar = new System.Windows.Forms.Button();
            this.contextAppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAppsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInstalled = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblBloatOpt2 = new System.Windows.Forms.LinkLabel();
            this.btnRefresh = new System.Windows.Forms.Button();
            menuAppsExport = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picAppsPoster)).BeginInit();
            this.contextAppMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAppsExport
            // 
            menuAppsExport.Name = "menuAppsExport";
            menuAppsExport.Size = new System.Drawing.Size(236, 26);
            menuAppsExport.Text = "Export bloatware in bin";
            menuAppsExport.Click += new System.EventHandler(this.menuAppsExport_Click);
            // 
            // listRemove
            // 
            this.listRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRemove.BackColor = System.Drawing.Color.White;
            this.listRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRemove.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRemove.FormattingEnabled = true;
            this.listRemove.ItemHeight = 17;
            this.listRemove.Location = new System.Drawing.Point(823, 107);
            this.listRemove.Name = "listRemove";
            this.listRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRemove.Size = new System.Drawing.Size(270, 646);
            this.listRemove.Sorted = true;
            this.listRemove.TabIndex = 13;
            // 
            // rtbStatus
            // 
            this.rtbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbStatus.BackColor = System.Drawing.Color.White;
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatus.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStatus.ForeColor = System.Drawing.Color.Black;
            this.rtbStatus.HideSelection = false;
            this.rtbStatus.Location = new System.Drawing.Point(823, 107);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.ReadOnly = true;
            this.rtbStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbStatus.Size = new System.Drawing.Size(270, 656);
            this.rtbStatus.TabIndex = 139;
            this.rtbStatus.Text = "";
            this.rtbStatus.Visible = false;
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreAll.AutoEllipsis = true;
            this.btnRestoreAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreAll.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreAll.Location = new System.Drawing.Point(449, 493);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(239, 23);
            this.btnRestoreAll.TabIndex = 34;
            this.btnRestoreAll.Text = "<< Restore all";
            this.btnRestoreAll.UseVisualStyleBackColor = true;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.AutoEllipsis = true;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(449, 464);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(239, 23);
            this.btnRestore.TabIndex = 32;
            this.btnRestore.Text = "< Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveAll.AutoEllipsis = true;
            this.btnMoveAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAll.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAll.Location = new System.Drawing.Point(449, 406);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(239, 23);
            this.btnMoveAll.TabIndex = 35;
            this.btnMoveAll.Text = "Move all >>";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.AutoEllipsis = true;
            this.btnMove.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Black;
            this.btnMove.Location = new System.Drawing.Point(449, 377);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(239, 23);
            this.btnMove.TabIndex = 31;
            this.btnMove.Text = "Move >";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.BackColor = System.Drawing.Color.Orchid;
            this.btnUninstall.FlatAppearance.BorderSize = 0;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.ForeColor = System.Drawing.Color.White;
            this.btnUninstall.Location = new System.Drawing.Point(815, 34);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(181, 35);
            this.btnUninstall.TabIndex = 41;
            this.btnUninstall.Text = "Empty bin";
            this.btnUninstall.UseVisualStyleBackColor = false;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(3, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 176;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(294, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(515, 32);
            this.lblHeader.TabIndex = 177;
            this.lblHeader.Text = "BLOAT-E";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listApps
            // 
            this.listApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listApps.BackColor = System.Drawing.Color.White;
            this.listApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listApps.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F);
            this.listApps.FormattingEnabled = true;
            this.listApps.ItemHeight = 17;
            this.listApps.Location = new System.Drawing.Point(44, 99);
            this.listApps.Name = "listApps";
            this.listApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listApps.Size = new System.Drawing.Size(270, 629);
            this.listApps.Sorted = true;
            this.listApps.TabIndex = 13;
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.FlatAppearance.BorderSize = 0;
            this.checkAppsSystem.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAppsSystem.ForeColor = System.Drawing.Color.Black;
            this.checkAppsSystem.Location = new System.Drawing.Point(44, 754);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(135, 21);
            this.checkAppsSystem.TabIndex = 16;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.UseVisualStyleBackColor = true;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // picAppsPoster
            // 
            this.picAppsPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAppsPoster.ErrorImage = null;
            this.picAppsPoster.InitialImage = null;
            this.picAppsPoster.Location = new System.Drawing.Point(320, 136);
            this.picAppsPoster.Name = "picAppsPoster";
            this.picAppsPoster.Size = new System.Drawing.Size(497, 235);
            this.picAppsPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppsPoster.TabIndex = 161;
            this.picAppsPoster.TabStop = false;
            // 
            // lblBloatOpt1
            // 
            this.lblBloatOpt1.ActiveLinkColor = System.Drawing.Color.Violet;
            this.lblBloatOpt1.AutoEllipsis = true;
            this.lblBloatOpt1.AutoSize = true;
            this.lblBloatOpt1.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloatOpt1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblBloatOpt1.LinkColor = System.Drawing.Color.MediumOrchid;
            this.lblBloatOpt1.Location = new System.Drawing.Point(339, 110);
            this.lblBloatOpt1.Name = "lblBloatOpt1";
            this.lblBloatOpt1.Size = new System.Drawing.Size(116, 17);
            this.lblBloatOpt1.TabIndex = 159;
            this.lblBloatOpt1.TabStop = true;
            this.lblBloatOpt1.Text = "Try these bloatware";
            this.lblBloatOpt1.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblBloatOpt1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBloatOpt1_LinkClicked);
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.Gray;
            this.textSearch.Location = new System.Drawing.Point(485, 66);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(149, 25);
            this.textSearch.TabIndex = 181;
            this.textSearch.Text = "Search";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnMenuGripperBar
            // 
            this.btnMenuGripperBar.FlatAppearance.BorderSize = 0;
            this.btnMenuGripperBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMenuGripperBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuGripperBar.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuGripperBar.ForeColor = System.Drawing.Color.Black;
            this.btnMenuGripperBar.Location = new System.Drawing.Point(35, 14);
            this.btnMenuGripperBar.Name = "btnMenuGripperBar";
            this.btnMenuGripperBar.Size = new System.Drawing.Size(42, 38);
            this.btnMenuGripperBar.TabIndex = 184;
            this.btnMenuGripperBar.Text = "...";
            this.btnMenuGripperBar.UseVisualStyleBackColor = true;
            this.btnMenuGripperBar.Click += new System.EventHandler(this.btnMenuGripperBar_Click);
            // 
            // contextAppMenu
            // 
            this.contextAppMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextAppMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F);
            this.contextAppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppsImport,
            menuAppsExport,
            this.menuAppsRemoveAll});
            this.contextAppMenu.Name = "menuMain";
            this.contextAppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextAppMenu.Size = new System.Drawing.Size(237, 104);
            this.contextAppMenu.Text = "Info";
            // 
            // menuAppsImport
            // 
            this.menuAppsImport.Name = "menuAppsImport";
            this.menuAppsImport.Size = new System.Drawing.Size(236, 26);
            this.menuAppsImport.Text = "Import bloatware list";
            this.menuAppsImport.Click += new System.EventHandler(this.menuAppsImport_Click);
            // 
            // menuAppsRemoveAll
            // 
            this.menuAppsRemoveAll.Name = "menuAppsRemoveAll";
            this.menuAppsRemoveAll.Size = new System.Drawing.Size(236, 26);
            this.menuAppsRemoveAll.Text = "Uninstall all apps";
            this.menuAppsRemoveAll.Click += new System.EventHandler(this.menuAppsRemoveAll_Click);
            // 
            // lblInstalled
            // 
            this.lblInstalled.AutoSize = true;
            this.lblInstalled.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstalled.ForeColor = System.Drawing.Color.Black;
            this.lblInstalled.Location = new System.Drawing.Point(41, 70);
            this.lblInstalled.Name = "lblInstalled";
            this.lblInstalled.Size = new System.Drawing.Size(56, 17);
            this.lblInstalled.TabIndex = 185;
            this.lblInstalled.Text = "Installed";
            // 
            // lblBin
            // 
            this.lblBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F);
            this.lblBin.ForeColor = System.Drawing.Color.Black;
            this.lblBin.Location = new System.Drawing.Point(820, 79);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(59, 17);
            this.lblBin.TabIndex = 186;
            this.lblBin.Text = "Trash bin";
            // 
            // lblBloatOpt2
            // 
            this.lblBloatOpt2.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblBloatOpt2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBloatOpt2.AutoEllipsis = true;
            this.lblBloatOpt2.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F);
            this.lblBloatOpt2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblBloatOpt2.LinkColor = System.Drawing.Color.DimGray;
            this.lblBloatOpt2.Location = new System.Drawing.Point(467, 110);
            this.lblBloatOpt2.Name = "lblBloatOpt2";
            this.lblBloatOpt2.Size = new System.Drawing.Size(347, 23);
            this.lblBloatOpt2.TabIndex = 187;
            this.lblBloatOpt2.TabStop = true;
            this.lblBloatOpt2.Text = "Add most hated";
            this.lblBloatOpt2.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblBloatOpt2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBloatOpt2_LinkClicked);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(75, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(42, 38);
            this.btnRefresh.TabIndex = 191;
            this.btnRefresh.Text = "...";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BloatyPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblBloatOpt2);
            this.Controls.Add(this.picAppsPoster);
            this.Controls.Add(this.lblBloatOpt1);
            this.Controls.Add(this.lblBin);
            this.Controls.Add(this.lblInstalled);
            this.Controls.Add(this.listApps);
            this.Controls.Add(this.checkAppsSystem);
            this.Controls.Add(this.btnMenuGripperBar);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.btnRestoreAll);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.listRemove);
            this.Controls.Add(this.rtbStatus);
            this.Name = "BloatyPageView";
            this.Size = new System.Drawing.Size(1107, 805);
            ((System.ComponentModel.ISupportInitialize)(this.picAppsPoster)).EndInit();
            this.contextAppMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listRemove;
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnUninstall;
        public System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox listApps;
        private System.Windows.Forms.CheckBox checkAppsSystem;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.LinkLabel lblBloatOpt1;
        private System.Windows.Forms.Button btnMenuGripperBar;
        private System.Windows.Forms.ContextMenuStrip contextAppMenu;
        private System.Windows.Forms.ToolStripMenuItem menuAppsImport;
        private System.Windows.Forms.ToolStripMenuItem menuAppsRemoveAll;
        private System.Windows.Forms.PictureBox picAppsPoster;
        private System.Windows.Forms.Label lblInstalled;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.LinkLabel lblBloatOpt2;
        private System.Windows.Forms.Button btnRefresh;
    }
}
