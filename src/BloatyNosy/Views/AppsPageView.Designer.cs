namespace BloatyNosy
{
    partial class AppsPageView
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
            this.btnAppOptions = new System.Windows.Forms.Button();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.listApps = new System.Windows.Forms.ListBox();
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.groupBin = new System.Windows.Forms.GroupBox();
            this.picAppsPoster = new System.Windows.Forms.PictureBox();
            this.lblAppsBinOptions = new System.Windows.Forms.LinkLabel();
            this.groupInstalled = new System.Windows.Forms.GroupBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnHMenu = new System.Windows.Forms.Button();
            this.contextAppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAppsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAppMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAppsCommunity = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsHallOfShame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            menuAppsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppsPoster)).BeginInit();
            this.groupInstalled.SuspendLayout();
            this.contextAppMenu.SuspendLayout();
            this.contextAppMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAppsExport
            // 
            menuAppsExport.Name = "menuAppsExport";
            menuAppsExport.Size = new System.Drawing.Size(193, 22);
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
            this.listRemove.Location = new System.Drawing.Point(11, 36);
            this.listRemove.Name = "listRemove";
            this.listRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRemove.Size = new System.Drawing.Size(394, 595);
            this.listRemove.Sorted = true;
            this.listRemove.TabIndex = 13;
            // 
            // rtbStatus
            // 
            this.rtbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbStatus.BackColor = System.Drawing.Color.White;
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatus.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStatus.ForeColor = System.Drawing.Color.Black;
            this.rtbStatus.HideSelection = false;
            this.rtbStatus.Location = new System.Drawing.Point(11, 66);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.ReadOnly = true;
            this.rtbStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbStatus.Size = new System.Drawing.Size(393, 570);
            this.rtbStatus.TabIndex = 139;
            this.rtbStatus.Text = "";
            this.rtbStatus.Visible = false;
            // 
            // btnAppOptions
            // 
            this.btnAppOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppOptions.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAppOptions.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnAppOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppOptions.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppOptions.ForeColor = System.Drawing.Color.White;
            this.btnAppOptions.Location = new System.Drawing.Point(977, 49);
            this.btnAppOptions.Name = "btnAppOptions";
            this.btnAppOptions.Size = new System.Drawing.Size(31, 30);
            this.btnAppOptions.TabIndex = 38;
            this.btnAppOptions.Text = "...";
            this.btnAppOptions.UseVisualStyleBackColor = false;
            this.btnAppOptions.Click += new System.EventHandler(this.btnAppOptions_Click);
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreAll.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreAll.Location = new System.Drawing.Point(482, 313);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(89, 23);
            this.btnRestoreAll.TabIndex = 34;
            this.btnRestoreAll.Text = "<< Restore all";
            this.btnRestoreAll.UseVisualStyleBackColor = true;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(482, 342);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(89, 23);
            this.btnRestore.TabIndex = 32;
            this.btnRestore.Text = "< Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAll.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAll.Location = new System.Drawing.Point(482, 201);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(89, 23);
            this.btnMoveAll.TabIndex = 35;
            this.btnMoveAll.Text = "Move all >>";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Black;
            this.btnMove.Location = new System.Drawing.Point(482, 230);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(89, 23);
            this.btnMove.TabIndex = 31;
            this.btnMove.Text = "Move >";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnUninstall.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.ForeColor = System.Drawing.Color.White;
            this.btnUninstall.Location = new System.Drawing.Point(797, 49);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(181, 30);
            this.btnUninstall.TabIndex = 41;
            this.btnUninstall.Text = "Empty bin and remove apps";
            this.btnUninstall.UseVisualStyleBackColor = false;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
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
            this.btnBack.TabIndex = 176;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeader.Location = new System.Drawing.Point(80, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(960, 32);
            this.lblHeader.TabIndex = 177;
            this.lblHeader.Text = "AppyTrash";
            // 
            // listApps
            // 
            this.listApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listApps.BackColor = System.Drawing.Color.White;
            this.listApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listApps.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listApps.FormattingEnabled = true;
            this.listApps.ItemHeight = 17;
            this.listApps.Location = new System.Drawing.Point(11, 36);
            this.listApps.Name = "listApps";
            this.listApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listApps.Size = new System.Drawing.Size(394, 595);
            this.listApps.Sorted = true;
            this.listApps.TabIndex = 13;
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.FlatAppearance.BorderSize = 0;
            this.checkAppsSystem.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAppsSystem.ForeColor = System.Drawing.Color.DeepPink;
            this.checkAppsSystem.Location = new System.Drawing.Point(35, 744);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(135, 21);
            this.checkAppsSystem.TabIndex = 16;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.UseVisualStyleBackColor = true;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // groupBin
            // 
            this.groupBin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBin.Controls.Add(this.picAppsPoster);
            this.groupBin.Controls.Add(this.rtbStatus);
            this.groupBin.Controls.Add(this.lblAppsBinOptions);
            this.groupBin.Controls.Add(this.listRemove);
            this.groupBin.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBin.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBin.Location = new System.Drawing.Point(609, 82);
            this.groupBin.Name = "groupBin";
            this.groupBin.Size = new System.Drawing.Size(411, 648);
            this.groupBin.TabIndex = 39;
            this.groupBin.TabStop = false;
            this.groupBin.Text = "Recycle bin";
            // 
            // picAppsPoster
            // 
            this.picAppsPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAppsPoster.ErrorImage = null;
            this.picAppsPoster.InitialImage = null;
            this.picAppsPoster.Location = new System.Drawing.Point(38, 105);
            this.picAppsPoster.Name = "picAppsPoster";
            this.picAppsPoster.Size = new System.Drawing.Size(331, 454);
            this.picAppsPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppsPoster.TabIndex = 161;
            this.picAppsPoster.TabStop = false;
            this.picAppsPoster.Visible = false;
            // 
            // lblAppsBinOptions
            // 
            this.lblAppsBinOptions.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppsBinOptions.AutoEllipsis = true;
            this.lblAppsBinOptions.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsBinOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAppsBinOptions.LinkColor = System.Drawing.Color.Gray;
            this.lblAppsBinOptions.Location = new System.Drawing.Point(8, 36);
            this.lblAppsBinOptions.Name = "lblAppsBinOptions";
            this.lblAppsBinOptions.Size = new System.Drawing.Size(361, 16);
            this.lblAppsBinOptions.TabIndex = 159;
            this.lblAppsBinOptions.TabStop = true;
            this.lblAppsBinOptions.Text = "Move the apps you want to uninstall here or import via file.";
            this.lblAppsBinOptions.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppsBinOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAppsBinOptions_LinkClicked);
            // 
            // groupInstalled
            // 
            this.groupInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInstalled.Controls.Add(this.listApps);
            this.groupInstalled.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInstalled.ForeColor = System.Drawing.Color.Violet;
            this.groupInstalled.Location = new System.Drawing.Point(28, 82);
            this.groupInstalled.Name = "groupInstalled";
            this.groupInstalled.Size = new System.Drawing.Size(411, 648);
            this.groupInstalled.TabIndex = 40;
            this.groupInstalled.TabStop = false;
            this.groupInstalled.Text = "Installed apps";
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.Gray;
            this.textSearch.Location = new System.Drawing.Point(469, 29);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(122, 23);
            this.textSearch.TabIndex = 181;
            this.textSearch.Text = "Search...";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
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
            this.btnHMenu.TabIndex = 184;
            this.btnHMenu.Text = "...";
            this.btnHMenu.UseVisualStyleBackColor = true;
            this.btnHMenu.Click += new System.EventHandler(this.btnHMenu_Click);
            // 
            // contextAppMenu
            // 
            this.contextAppMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextAppMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextAppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppsImport,
            menuAppsExport,
            this.menuAppsRemoveAll});
            this.contextAppMenu.Name = "menuMain";
            this.contextAppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextAppMenu.Size = new System.Drawing.Size(194, 70);
            this.contextAppMenu.Text = "Info";
            // 
            // menuAppsImport
            // 
            this.menuAppsImport.Name = "menuAppsImport";
            this.menuAppsImport.Size = new System.Drawing.Size(193, 22);
            this.menuAppsImport.Text = "Import bloatware list";
            this.menuAppsImport.Click += new System.EventHandler(this.menuAppsImport_Click);
            // 
            // menuAppsRemoveAll
            // 
            this.menuAppsRemoveAll.Name = "menuAppsRemoveAll";
            this.menuAppsRemoveAll.Size = new System.Drawing.Size(193, 22);
            this.menuAppsRemoveAll.Text = "Uninstall all apps";
            this.menuAppsRemoveAll.Click += new System.EventHandler(this.menuAppsRemoveAll_Click);
            // 
            // contextAppMenuOptions
            // 
            this.contextAppMenuOptions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextAppMenuOptions.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextAppMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppsCommunity,
            this.menuAppsHallOfShame,
            this.toolStripSeparator2,
            this.menuRefresh});
            this.contextAppMenuOptions.Name = "menuMain";
            this.contextAppMenuOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextAppMenuOptions.Size = new System.Drawing.Size(368, 76);
            this.contextAppMenuOptions.Text = "Info";
            // 
            // menuAppsCommunity
            // 
            this.menuAppsCommunity.Name = "menuAppsCommunity";
            this.menuAppsCommunity.Size = new System.Drawing.Size(367, 22);
            this.menuAppsCommunity.Text = "Add bloatware rated by community to recycle bin";
            this.menuAppsCommunity.Click += new System.EventHandler(this.menuAppsCommunity_Click);
            // 
            // menuAppsHallOfShame
            // 
            this.menuAppsHallOfShame.Name = "menuAppsHallOfShame";
            this.menuAppsHallOfShame.Size = new System.Drawing.Size(367, 22);
            this.menuAppsHallOfShame.Text = "Add the 10 most hated apps of Windows 11 to recycle bin";
            this.menuAppsHallOfShame.Click += new System.EventHandler(this.menuAppsHallOfShame_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(364, 6);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(367, 22);
            this.menuRefresh.Text = "Refresh";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // AppsPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkAppsSystem);
            this.Controls.Add(this.btnHMenu);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.groupBin);
            this.Controls.Add(this.btnAppOptions);
            this.Controls.Add(this.btnRestoreAll);
            this.Controls.Add(this.groupInstalled);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.btnMove);
            this.Name = "AppsPageView";
            this.Size = new System.Drawing.Size(1054, 795);
            this.groupBin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAppsPoster)).EndInit();
            this.groupInstalled.ResumeLayout(false);
            this.contextAppMenu.ResumeLayout(false);
            this.contextAppMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listRemove;
        private System.Windows.Forms.Button btnAppOptions;
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
        private System.Windows.Forms.GroupBox groupBin;
        private System.Windows.Forms.GroupBox groupInstalled;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.LinkLabel lblAppsBinOptions;
        private System.Windows.Forms.Button btnHMenu;
        private System.Windows.Forms.ContextMenuStrip contextAppMenu;
        private System.Windows.Forms.ToolStripMenuItem menuAppsImport;
        private System.Windows.Forms.ToolStripMenuItem menuAppsRemoveAll;
        private System.Windows.Forms.ContextMenuStrip contextAppMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuAppsCommunity;
        private System.Windows.Forms.ToolStripMenuItem menuAppsHallOfShame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.PictureBox picAppsPoster;
    }
}
