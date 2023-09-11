
namespace DocManager
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpBxMain = new System.Windows.Forms.GroupBox();
            this.btnCheckDocs = new System.Windows.Forms.Button();
            this.lblTags = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBxTags = new System.Windows.Forms.TextBox();
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.gridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSignatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnRefhreshFltr = new System.Windows.Forms.Button();
            this.btnFilterApply = new System.Windows.Forms.Button();
            this.lstBxOperands = new System.Windows.Forms.ListBox();
            this.txtBoxTagFltr2 = new System.Windows.Forms.TextBox();
            this.txtBoxTagFltr1 = new System.Windows.Forms.TextBox();
            this.chkBoxTags = new System.Windows.Forms.CheckBox();
            this.copySignatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpBxMain.SuspendLayout();
            this.gridMenuStrip.SuspendLayout();
            this.grpBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdx,
            this.colTitle,
            this.colTags,
            this.colPath,
            this.colHash,
            this.colStatus});
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // colIdx
            // 
            this.colIdx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIdx.DataPropertyName = "Idx";
            this.colIdx.HeaderText = "Idx";
            this.colIdx.Name = "colIdx";
            this.colIdx.ReadOnly = true;
            this.colIdx.Width = 30;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.FillWeight = 64.1438F;
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colTags
            // 
            this.colTags.DataPropertyName = "TagString";
            this.colTags.FillWeight = 64.1438F;
            this.colTags.HeaderText = "Tags";
            this.colTags.Name = "colTags";
            this.colTags.ReadOnly = true;
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "PathRaw";
            this.colPath.FillWeight = 64.1438F;
            this.colPath.HeaderText = "File Path";
            this.colPath.Name = "colPath";
            this.colPath.ReadOnly = true;
            // 
            // colHash
            // 
            this.colHash.DataPropertyName = "Hash";
            this.colHash.FillWeight = 64.1438F;
            this.colHash.HeaderText = "Signature";
            this.colHash.Name = "colHash";
            this.colHash.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 120;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Document";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedSearchToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveQuitToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // advancedSearchToolStripMenuItem
            // 
            this.advancedSearchToolStripMenuItem.Name = "advancedSearchToolStripMenuItem";
            this.advancedSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.advancedSearchToolStripMenuItem.Text = "Advanced Search...";
            this.advancedSearchToolStripMenuItem.Click += new System.EventHandler(this.advancedSearchToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveQuitToolStripMenuItem
            // 
            this.saveQuitToolStripMenuItem.Name = "saveQuitToolStripMenuItem";
            this.saveQuitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveQuitToolStripMenuItem.Text = "Save && Quit";
            this.saveQuitToolStripMenuItem.Click += new System.EventHandler(this.saveQuitToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // grpBxMain
            // 
            this.grpBxMain.Controls.Add(this.btnCheckDocs);
            this.grpBxMain.Controls.Add(this.lblTags);
            this.grpBxMain.Controls.Add(this.label2);
            this.grpBxMain.Controls.Add(this.lblFilePath);
            this.grpBxMain.Controls.Add(this.lblPath);
            this.grpBxMain.Controls.Add(this.btnSearch);
            this.grpBxMain.Controls.Add(this.txtBxTags);
            this.grpBxMain.Controls.Add(this.txtBxTitle);
            this.grpBxMain.Controls.Add(this.btnAdd);
            this.grpBxMain.Location = new System.Drawing.Point(12, 27);
            this.grpBxMain.Name = "grpBxMain";
            this.grpBxMain.Size = new System.Drawing.Size(339, 162);
            this.grpBxMain.TabIndex = 3;
            this.grpBxMain.TabStop = false;
            // 
            // btnCheckDocs
            // 
            this.btnCheckDocs.Location = new System.Drawing.Point(131, 121);
            this.btnCheckDocs.Name = "btnCheckDocs";
            this.btnCheckDocs.Size = new System.Drawing.Size(116, 35);
            this.btnCheckDocs.TabIndex = 4;
            this.btnCheckDocs.Text = "Check Documents";
            this.btnCheckDocs.UseVisualStyleBackColor = true;
            this.btnCheckDocs.Click += new System.EventHandler(this.btnCheckDocs_Click);
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(2, 45);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(34, 13);
            this.lblTags.TabIndex = 4;
            this.lblTags.Text = "Tags:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(44, 67);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(39, 13);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "lblPath";
            this.lblFilePath.Visible = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 67);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(271, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBxTags
            // 
            this.txtBxTags.Location = new System.Drawing.Point(34, 42);
            this.txtBxTags.Name = "txtBxTags";
            this.txtBxTags.Size = new System.Drawing.Size(240, 20);
            this.txtBxTags.TabIndex = 2;
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.Location = new System.Drawing.Point(34, 13);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.Size = new System.Drawing.Size(240, 20);
            this.txtBxTitle.TabIndex = 0;
            // 
            // gridMenuStrip
            // 
            this.gridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySignatureToolStripMenuItem,
            this.toolStripMenuItemCheck,
            this.toolStripMenuItemOpenFolder,
            this.openFileToolStripMenuItem,
            this.updateSignatureToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.gridMenuStrip.Name = "gridMenuStrip";
            this.gridMenuStrip.Size = new System.Drawing.Size(181, 158);
            // 
            // toolStripMenuItemCheck
            // 
            this.toolStripMenuItemCheck.Name = "toolStripMenuItemCheck";
            this.toolStripMenuItemCheck.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemCheck.Text = "Check Document";
            this.toolStripMenuItemCheck.Click += new System.EventHandler(this.toolStripMenuItemCheck_Click);
            // 
            // toolStripMenuItemOpenFolder
            // 
            this.toolStripMenuItemOpenFolder.Name = "toolStripMenuItemOpenFolder";
            this.toolStripMenuItemOpenFolder.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemOpenFolder.Text = "Open Folder";
            this.toolStripMenuItemOpenFolder.Click += new System.EventHandler(this.toolStripMenuItemOpenFolder_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // updateSignatureToolStripMenuItem
            // 
            this.updateSignatureToolStripMenuItem.Name = "updateSignatureToolStripMenuItem";
            this.updateSignatureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSignatureToolStripMenuItem.Text = "Update Signature";
            this.updateSignatureToolStripMenuItem.Click += new System.EventHandler(this.updateSignatureToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detailsToolStripMenuItem.Text = "Details...";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // grpBoxFilter
            // 
            this.grpBoxFilter.Controls.Add(this.btnRefhreshFltr);
            this.grpBoxFilter.Controls.Add(this.btnFilterApply);
            this.grpBoxFilter.Controls.Add(this.lstBxOperands);
            this.grpBoxFilter.Controls.Add(this.txtBoxTagFltr2);
            this.grpBoxFilter.Controls.Add(this.txtBoxTagFltr1);
            this.grpBoxFilter.Controls.Add(this.chkBoxTags);
            this.grpBoxFilter.Location = new System.Drawing.Point(357, 27);
            this.grpBoxFilter.Name = "grpBoxFilter";
            this.grpBoxFilter.Size = new System.Drawing.Size(431, 162);
            this.grpBoxFilter.TabIndex = 4;
            this.grpBoxFilter.TabStop = false;
            this.grpBoxFilter.Text = "Search Filters";
            // 
            // btnRefhreshFltr
            // 
            this.btnRefhreshFltr.Location = new System.Drawing.Point(128, 121);
            this.btnRefhreshFltr.Name = "btnRefhreshFltr";
            this.btnRefhreshFltr.Size = new System.Drawing.Size(116, 35);
            this.btnRefhreshFltr.TabIndex = 3;
            this.btnRefhreshFltr.Text = "Refresh";
            this.btnRefhreshFltr.UseVisualStyleBackColor = true;
            this.btnRefhreshFltr.Click += new System.EventHandler(this.btnRefhreshFltr_Click);
            // 
            // btnFilterApply
            // 
            this.btnFilterApply.Location = new System.Drawing.Point(6, 121);
            this.btnFilterApply.Name = "btnFilterApply";
            this.btnFilterApply.Size = new System.Drawing.Size(116, 35);
            this.btnFilterApply.TabIndex = 3;
            this.btnFilterApply.Text = "Search";
            this.btnFilterApply.UseVisualStyleBackColor = true;
            this.btnFilterApply.Click += new System.EventHandler(this.btnFilterApply_Click);
            // 
            // lstBxOperands
            // 
            this.lstBxOperands.FormattingEnabled = true;
            this.lstBxOperands.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.lstBxOperands.Location = new System.Drawing.Point(200, 16);
            this.lstBxOperands.Name = "lstBxOperands";
            this.lstBxOperands.Size = new System.Drawing.Size(83, 17);
            this.lstBxOperands.TabIndex = 2;
            // 
            // txtBoxTagFltr2
            // 
            this.txtBoxTagFltr2.Location = new System.Drawing.Point(289, 15);
            this.txtBoxTagFltr2.Name = "txtBoxTagFltr2";
            this.txtBoxTagFltr2.Size = new System.Drawing.Size(136, 20);
            this.txtBoxTagFltr2.TabIndex = 1;
            // 
            // txtBoxTagFltr1
            // 
            this.txtBoxTagFltr1.Location = new System.Drawing.Point(58, 15);
            this.txtBoxTagFltr1.Name = "txtBoxTagFltr1";
            this.txtBoxTagFltr1.Size = new System.Drawing.Size(136, 20);
            this.txtBoxTagFltr1.TabIndex = 1;
            // 
            // chkBoxTags
            // 
            this.chkBoxTags.AutoSize = true;
            this.chkBoxTags.Location = new System.Drawing.Point(6, 17);
            this.chkBoxTags.Name = "chkBoxTags";
            this.chkBoxTags.Size = new System.Drawing.Size(56, 17);
            this.chkBoxTags.TabIndex = 0;
            this.chkBoxTags.Text = "Tags: ";
            this.chkBoxTags.UseVisualStyleBackColor = true;
            // 
            // copySignatureToolStripMenuItem
            // 
            this.copySignatureToolStripMenuItem.Name = "copySignatureToolStripMenuItem";
            this.copySignatureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copySignatureToolStripMenuItem.Text = "Copy Signature";
            this.copySignatureToolStripMenuItem.Click += new System.EventHandler(this.copySignatureToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxFilter);
            this.Controls.Add(this.grpBxMain);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 1200);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "DocManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxMain.ResumeLayout(false);
            this.grpBxMain.PerformLayout();
            this.gridMenuStrip.ResumeLayout(false);
            this.grpBoxFilter.ResumeLayout(false);
            this.grpBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBxMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.TextBox txtBxTags;
        private System.Windows.Forms.Button btnCheckDocs;
        private System.Windows.Forms.ContextMenuStrip gridMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCheck;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxFilter;
        private System.Windows.Forms.Button btnRefhreshFltr;
        private System.Windows.Forms.Button btnFilterApply;
        private System.Windows.Forms.ListBox lstBxOperands;
        private System.Windows.Forms.TextBox txtBoxTagFltr2;
        private System.Windows.Forms.TextBox txtBoxTagFltr1;
        private System.Windows.Forms.CheckBox chkBoxTags;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveQuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSignatureToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.ToolStripMenuItem copySignatureToolStripMenuItem;
    }
}

