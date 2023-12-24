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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NosyPageView));
            this.tvwFeatures = new System.Windows.Forms.TreeView();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.checkLoadPlugins = new ToggleSwitch();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.lnkAppBloatpilot = new System.Windows.Forms.LinkLabel();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.tvwFeaturesBin = new System.Windows.Forms.TreeView();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lnkStatus = new System.Windows.Forms.LinkLabel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnMenuGripperBar = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textHeaderApp = new System.Windows.Forms.ToolStripTextBox();
            this.textHeaderExperience = new System.Windows.Forms.ToolStripTextBox();
            this.cbProfiles = new System.Windows.Forms.ToolStripComboBox();
            this.menuLoadProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportProfile = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwFeatures
            // 
            this.tvwFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwFeatures.BackColor = System.Drawing.Color.White;
            this.tvwFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwFeatures.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwFeatures.ForeColor = System.Drawing.Color.Black;
            this.tvwFeatures.FullRowSelect = true;
            this.tvwFeatures.ItemHeight = 37;
            this.tvwFeatures.LineColor = System.Drawing.Color.DodgerBlue;
            this.tvwFeatures.Location = new System.Drawing.Point(55, 66);
            this.tvwFeatures.Name = "tvwFeatures";
            this.tvwFeatures.ShowLines = false;
            this.tvwFeatures.ShowNodeToolTips = true;
            this.tvwFeatures.ShowRootLines = false;
            this.tvwFeatures.Size = new System.Drawing.Size(254, 623);
            this.tvwFeatures.TabIndex = 169;
            this.tvwFeatures.TabStop = false;
            this.tvwFeatures.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwFeatures_AfterCheck);
            this.tvwFeatures.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwFeatures_AfterSelect);
            this.tvwFeatures.DoubleClick += new System.EventHandler(this.tvwFeatures_DoubleClick);
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
            this.sc.Panel1.Controls.Add(this.label1);
            this.sc.Panel1.Controls.Add(this.checkLoadPlugins);
            this.sc.Panel1.Controls.Add(this.btnLoadProfile);
            this.sc.Panel1.Controls.Add(this.btnRemoveAll);
            this.sc.Panel1.Controls.Add(this.btnRemove);
            this.sc.Panel1.Controls.Add(this.tvwFeatures);
            this.sc.Panel1.Controls.Add(this.btnAdd);
            this.sc.Panel1.Controls.Add(this.btnAddAll);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.AutoScroll = true;
            this.sc.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.sc.Panel2.Controls.Add(this.lnkAppBloatpilot);
            this.sc.Panel2.Controls.Add(this.btnAnalyze);
            this.sc.Panel2.Controls.Add(this.tvwFeaturesBin);
            this.sc.Panel2.Controls.Add(this.progress);
            this.sc.Panel2.Controls.Add(this.lnkStatus);
            this.sc.Panel2.Controls.Add(this.btnRestore);
            this.sc.Panel2.Controls.Add(this.btnApply);
            this.sc.Panel2.Controls.Add(this.rtbLog);
            this.sc.Size = new System.Drawing.Size(942, 759);
            this.sc.SplitterDistance = 360;
            this.sc.TabIndex = 208;
            this.sc.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 10F);
            this.label1.Location = new System.Drawing.Point(114, 701);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 222;
            this.label1.Text = "Plugin access";
            // 
            // checkLoadPlugins
            // 
            this.checkLoadPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkLoadPlugins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkLoadPlugins.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLoadPlugins.ForeColor = System.Drawing.Color.DeepPink;
            this.checkLoadPlugins.Location = new System.Drawing.Point(55, 695);
            this.checkLoadPlugins.Name = "checkLoadPlugins";
            this.checkLoadPlugins.Padding = new System.Windows.Forms.Padding(6);
            this.checkLoadPlugins.Size = new System.Drawing.Size(53, 30);
            this.checkLoadPlugins.TabIndex = 220;
            this.checkLoadPlugins.Text = "Load Plugin-Powered Enhancements";
            this.checkLoadPlugins.UseVisualStyleBackColor = true;
            this.checkLoadPlugins.CheckedChanged += new System.EventHandler(this.checkLoadPlugins_CheckedChanged);
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLoadProfile.AutoEllipsis = true;
            this.btnLoadProfile.FlatAppearance.BorderSize = 0;
            this.btnLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoadProfile.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProfile.ForeColor = System.Drawing.Color.Black;
            this.btnLoadProfile.Location = new System.Drawing.Point(315, 336);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(42, 23);
            this.btnLoadProfile.TabIndex = 221;
            this.tt.SetToolTip(this.btnLoadProfile, "Load profile");
            this.btnLoadProfile.UseVisualStyleBackColor = true;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnLoadProfile_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveAll.AutoEllipsis = true;
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveAll.Location = new System.Drawing.Point(315, 281);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(42, 23);
            this.btnRemoveAll.TabIndex = 218;
            this.tt.SetToolTip(this.btnRemoveAll, "Remove all");
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.AutoEllipsis = true;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(315, 194);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(42, 23);
            this.btnRemove.TabIndex = 217;
            this.tt.SetToolTip(this.btnRemove, "Remove");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(315, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 23);
            this.btnAdd.TabIndex = 216;
            this.tt.SetToolTip(this.btnAdd, "Add");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddAll.AutoEllipsis = true;
            this.btnAddAll.FlatAppearance.BorderSize = 0;
            this.btnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddAll.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.ForeColor = System.Drawing.Color.Black;
            this.btnAddAll.Location = new System.Drawing.Point(315, 252);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(42, 23);
            this.btnAddAll.TabIndex = 219;
            this.tt.SetToolTip(this.btnAddAll, "Add all");
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // lnkAppBloatpilot
            // 
            this.lnkAppBloatpilot.ActiveLinkColor = System.Drawing.Color.HotPink;
            this.lnkAppBloatpilot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAppBloatpilot.AutoEllipsis = true;
            this.lnkAppBloatpilot.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAppBloatpilot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAppBloatpilot.LinkColor = System.Drawing.Color.MediumOrchid;
            this.lnkAppBloatpilot.Location = new System.Drawing.Point(351, 376);
            this.lnkAppBloatpilot.Name = "lnkAppBloatpilot";
            this.lnkAppBloatpilot.Size = new System.Drawing.Size(133, 21);
            this.lnkAppBloatpilot.TabIndex = 219;
            this.lnkAppBloatpilot.TabStop = true;
            this.lnkAppBloatpilot.Text = "Switch to BLOAT-E";
            this.tt.SetToolTip(this.lnkAppBloatpilot, "BLOAT-E integration in Bloatynosy is the next-level debloating tool");
            this.lnkAppBloatpilot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAppBloatpilot_LinkClicked);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.AutoEllipsis = true;
            this.btnAnalyze.BackColor = System.Drawing.Color.Orchid;
            this.btnAnalyze.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAnalyze.FlatAppearance.BorderSize = 0;
            this.btnAnalyze.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(317, 336);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAnalyze.Size = new System.Drawing.Size(184, 37);
            this.btnAnalyze.TabIndex = 215;
            this.btnAnalyze.TabStop = false;
            this.btnAnalyze.Text = "+ Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // tvwFeaturesBin
            // 
            this.tvwFeaturesBin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwFeaturesBin.BackColor = System.Drawing.Color.White;
            this.tvwFeaturesBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwFeaturesBin.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F);
            this.tvwFeaturesBin.ForeColor = System.Drawing.Color.Black;
            this.tvwFeaturesBin.FullRowSelect = true;
            this.tvwFeaturesBin.ItemHeight = 37;
            this.tvwFeaturesBin.LineColor = System.Drawing.Color.DodgerBlue;
            this.tvwFeaturesBin.Location = new System.Drawing.Point(3, 66);
            this.tvwFeaturesBin.Name = "tvwFeaturesBin";
            this.tvwFeaturesBin.ShowLines = false;
            this.tvwFeaturesBin.ShowNodeToolTips = true;
            this.tvwFeaturesBin.ShowRootLines = false;
            this.tvwFeaturesBin.Size = new System.Drawing.Size(254, 623);
            this.tvwFeaturesBin.TabIndex = 215;
            this.tvwFeaturesBin.DoubleClick += new System.EventHandler(this.tvwFeaturesBin_DoubleClick);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(3, 710);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(254, 5);
            this.progress.TabIndex = 166;
            this.progress.Visible = false;
            // 
            // lnkStatus
            // 
            this.lnkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStatus.AutoEllipsis = true;
            this.lnkStatus.BackColor = System.Drawing.Color.Transparent;
            this.lnkStatus.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F);
            this.lnkStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkStatus.LinkColor = System.Drawing.Color.Black;
            this.lnkStatus.Location = new System.Drawing.Point(3, 690);
            this.lnkStatus.Name = "lnkStatus";
            this.lnkStatus.Size = new System.Drawing.Size(254, 19);
            this.lnkStatus.TabIndex = 214;
            this.lnkStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStatus_LinkClicked);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestore.AutoEllipsis = true;
            this.btnRestore.BackColor = System.Drawing.Color.White;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F);
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(126, 715);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnRestore.Size = new System.Drawing.Size(117, 34);
            this.btnRestore.TabIndex = 178;
            this.btnRestore.TabStop = false;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.AutoEllipsis = true;
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F);
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(3, 715);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(117, 34);
            this.btnApply.TabIndex = 27;
            this.btnApply.TabStop = false;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.ForeColor = System.Drawing.Color.DimGray;
            this.rtbLog.HideSelection = false;
            this.rtbLog.Location = new System.Drawing.Point(269, 66);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(292, 264);
            this.rtbLog.TabIndex = 138;
            this.rtbLog.Text = resources.GetString("rtbLog.Text");
            // 
            // btnMenuGripperBar
            // 
            this.btnMenuGripperBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuGripperBar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMenuGripperBar.FlatAppearance.BorderSize = 0;
            this.btnMenuGripperBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnMenuGripperBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuGripperBar.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F);
            this.btnMenuGripperBar.ForeColor = System.Drawing.Color.DeepPink;
            this.btnMenuGripperBar.Location = new System.Drawing.Point(5, 265);
            this.btnMenuGripperBar.Name = "btnMenuGripperBar";
            this.btnMenuGripperBar.Size = new System.Drawing.Size(43, 39);
            this.btnMenuGripperBar.TabIndex = 220;
            this.btnMenuGripperBar.Text = "|";
            this.tt.SetToolTip(this.btnMenuGripperBar, "Settings");
            this.btnMenuGripperBar.UseVisualStyleBackColor = false;
            this.btnMenuGripperBar.Click += new System.EventHandler(this.btnMenuGripperBar_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.btnMenuGripperBar);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(49, 759);
            this.pnlNav.TabIndex = 209;
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textHeaderApp,
            this.textHeaderExperience,
            this.cbProfiles,
            this.menuLoadProfile,
            this.menuExportProfile});
            this.contextMenu.Name = "menuMain";
            this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenu.Size = new System.Drawing.Size(261, 148);
            // 
            // textHeaderApp
            // 
            this.textHeaderApp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textHeaderApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeaderApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeaderApp.ForeColor = System.Drawing.Color.Gray;
            this.textHeaderApp.Margin = new System.Windows.Forms.Padding(1, 1, 1, 10);
            this.textHeaderApp.Name = "textHeaderApp";
            this.textHeaderApp.Size = new System.Drawing.Size(100, 16);
            this.textHeaderApp.Text = "Profiles";
            // 
            // textHeaderExperience
            // 
            this.textHeaderExperience.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textHeaderExperience.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeaderExperience.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textHeaderExperience.ForeColor = System.Drawing.Color.Orchid;
            this.textHeaderExperience.Name = "textHeaderExperience";
            this.textHeaderExperience.Size = new System.Drawing.Size(200, 16);
            this.textHeaderExperience.Text = "Choose Experience profile";
            // 
            // cbProfiles
            // 
            this.cbProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbProfiles.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(200, 25);
            // 
            // menuLoadProfile
            // 
            this.menuLoadProfile.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.menuLoadProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuLoadProfile.Name = "menuLoadProfile";
            this.menuLoadProfile.Size = new System.Drawing.Size(260, 24);
            this.menuLoadProfile.Text = "Load Profile";
            this.menuLoadProfile.Click += new System.EventHandler(this.menuLoadProfile_Click);
            // 
            // menuExportProfile
            // 
            this.menuExportProfile.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.menuExportProfile.Name = "menuExportProfile";
            this.menuExportProfile.Size = new System.Drawing.Size(260, 24);
            this.menuExportProfile.Text = "Export Profile";
            this.menuExportProfile.Click += new System.EventHandler(this.menuExportProfile_Click);
            // 
            // NosyPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.sc);
            this.Name = "NosyPageView";
            this.Size = new System.Drawing.Size(942, 759);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.contextMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TreeView tvwFeatures;
        public System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.LinkLabel lnkStatus;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.RichTextBox rtbLog;
        internal System.Windows.Forms.TreeView tvwFeaturesBin;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel lnkAppBloatpilot;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripTextBox textHeaderApp;
        private System.Windows.Forms.Button btnMenuGripperBar;
        private System.Windows.Forms.ToolStripTextBox textHeaderExperience;
        private System.Windows.Forms.ToolStripComboBox cbProfiles;
        private System.Windows.Forms.ToolStripMenuItem menuLoadProfile;
        private System.Windows.Forms.ToolStripMenuItem menuExportProfile;
        private System.Windows.Forms.Button btnLoadProfile;
        private ToggleSwitch checkLoadPlugins;
        private System.Windows.Forms.Label label1;
    }
}
