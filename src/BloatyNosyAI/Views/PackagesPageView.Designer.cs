namespace Bloatynosy.Views
{
    partial class PackagesPageView
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
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.listLocal = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.lblRemote = new System.Windows.Forms.Label();
            this.listRemote = new System.Windows.Forms.ListBox();
            this.richStatus = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.btnInstall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.AutoEllipsis = true;
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveAll.Location = new System.Drawing.Point(436, 405);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(239, 23);
            this.btnRemoveAll.TabIndex = 45;
            this.btnRemoveAll.Text = "<< Remove all";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // listLocal
            // 
            this.listLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLocal.BackColor = System.Drawing.Color.White;
            this.listLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLocal.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLocal.FormattingEnabled = true;
            this.listLocal.ItemHeight = 17;
            this.listLocal.Location = new System.Drawing.Point(823, 107);
            this.listLocal.Name = "listLocal";
            this.listLocal.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listLocal.Size = new System.Drawing.Size(270, 646);
            this.listLocal.Sorted = true;
            this.listLocal.TabIndex = 13;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoEllipsis = true;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(436, 376);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(239, 23);
            this.btnRemove.TabIndex = 43;
            this.btnRemove.Text = "< Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAll.AutoEllipsis = true;
            this.btnAddAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.ForeColor = System.Drawing.Color.Black;
            this.btnAddAll.Location = new System.Drawing.Point(436, 293);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(239, 23);
            this.btnAddAll.TabIndex = 46;
            this.btnAddAll.Text = "Add all >>";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(436, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(239, 23);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add >";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(3, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 177;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.textSearch.TabIndex = 180;
            this.textSearch.Text = "Search";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // lblRemote
            // 
            this.lblRemote.AutoSize = true;
            this.lblRemote.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F);
            this.lblRemote.ForeColor = System.Drawing.Color.Black;
            this.lblRemote.Location = new System.Drawing.Point(42, 70);
            this.lblRemote.Name = "lblRemote";
            this.lblRemote.Size = new System.Drawing.Size(54, 17);
            this.lblRemote.TabIndex = 186;
            this.lblRemote.Text = "Remote";
            // 
            // listRemote
            // 
            this.listRemote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listRemote.BackColor = System.Drawing.Color.White;
            this.listRemote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRemote.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRemote.FormattingEnabled = true;
            this.listRemote.ItemHeight = 17;
            this.listRemote.Location = new System.Drawing.Point(44, 99);
            this.listRemote.Name = "listRemote";
            this.listRemote.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRemote.Size = new System.Drawing.Size(270, 629);
            this.listRemote.Sorted = true;
            this.listRemote.TabIndex = 13;
            // 
            // richStatus
            // 
            this.richStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richStatus.BackColor = System.Drawing.Color.White;
            this.richStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richStatus.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richStatus.ForeColor = System.Drawing.Color.Black;
            this.richStatus.HideSelection = false;
            this.richStatus.Location = new System.Drawing.Point(823, 107);
            this.richStatus.Name = "richStatus";
            this.richStatus.ReadOnly = true;
            this.richStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richStatus.Size = new System.Drawing.Size(270, 646);
            this.richStatus.TabIndex = 140;
            this.richStatus.Text = "";
            this.richStatus.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(286, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(523, 32);
            this.lblHeader.TabIndex = 188;
            this.lblHeader.Text = "Packages";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F);
            this.lblLocal.ForeColor = System.Drawing.Color.Black;
            this.lblLocal.Location = new System.Drawing.Point(820, 79);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(38, 17);
            this.lblLocal.TabIndex = 189;
            this.lblLocal.Text = "Local";
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.BackColor = System.Drawing.Color.Orchid;
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.ForeColor = System.Drawing.Color.White;
            this.btnInstall.Location = new System.Drawing.Point(815, 34);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(181, 35);
            this.btnInstall.TabIndex = 191;
            this.btnInstall.Text = "Install packages";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // PackagesPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.listRemote);
            this.Controls.Add(this.lblRemote);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.richStatus);
            this.Controls.Add(this.listLocal);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnRemoveAll);
            this.Name = "PackagesPageView";
            this.Size = new System.Drawing.Size(1107, 805);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.ListBox listLocal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label lblRemote;
        private System.Windows.Forms.ListBox listRemote;
        public System.Windows.Forms.RichTextBox richStatus;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Button btnInstall;
    }
}
