
namespace DocManager
{
    partial class FrmAdvancedSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxFolder = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.chkBxHash = new System.Windows.Forms.CheckBox();
            this.txtBxHash = new System.Windows.Forms.TextBox();
            this.chkBxExtension = new System.Windows.Forms.CheckBox();
            this.txtBxExtension = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chkBxRecursiveSearch = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxFolder
            // 
            this.txtBxFolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBxFolder.Location = new System.Drawing.Point(12, 37);
            this.txtBxFolder.Name = "txtBxFolder";
            this.txtBxFolder.ReadOnly = true;
            this.txtBxFolder.Size = new System.Drawing.Size(270, 20);
            this.txtBxFolder.TabIndex = 0;
            // 
            // btnFolder
            // 
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFolder.Location = new System.Drawing.Point(280, 37);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(80, 20);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Select folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // chkBxHash
            // 
            this.chkBxHash.AutoSize = true;
            this.chkBxHash.Location = new System.Drawing.Point(12, 90);
            this.chkBxHash.Name = "chkBxHash";
            this.chkBxHash.Size = new System.Drawing.Size(74, 17);
            this.chkBxHash.TabIndex = 2;
            this.chkBxHash.Text = "Signature:";
            this.chkBxHash.UseVisualStyleBackColor = true;
            this.chkBxHash.CheckedChanged += new System.EventHandler(this.chkBxHash_CheckedChanged);
            // 
            // txtBxHash
            // 
            this.txtBxHash.Enabled = false;
            this.txtBxHash.Location = new System.Drawing.Point(93, 87);
            this.txtBxHash.Name = "txtBxHash";
            this.txtBxHash.Size = new System.Drawing.Size(268, 20);
            this.txtBxHash.TabIndex = 3;
            // 
            // chkBxExtension
            // 
            this.chkBxExtension.AutoSize = true;
            this.chkBxExtension.Location = new System.Drawing.Point(12, 116);
            this.chkBxExtension.Name = "chkBxExtension";
            this.chkBxExtension.Size = new System.Drawing.Size(75, 17);
            this.chkBxExtension.TabIndex = 2;
            this.chkBxExtension.Text = "Extension:";
            this.chkBxExtension.UseVisualStyleBackColor = true;
            this.chkBxExtension.CheckedChanged += new System.EventHandler(this.chkBxExtension_CheckedChanged);
            // 
            // txtBxExtension
            // 
            this.txtBxExtension.Enabled = false;
            this.txtBxExtension.Location = new System.Drawing.Point(93, 114);
            this.txtBxExtension.Name = "txtBxExtension";
            this.txtBxExtension.Size = new System.Drawing.Size(268, 20);
            this.txtBxExtension.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 174);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 251);
            this.listBox1.TabIndex = 4;
            // 
            // chkBxRecursiveSearch
            // 
            this.chkBxRecursiveSearch.AutoSize = true;
            this.chkBxRecursiveSearch.Location = new System.Drawing.Point(12, 63);
            this.chkBxRecursiveSearch.Name = "chkBxRecursiveSearch";
            this.chkBxRecursiveSearch.Size = new System.Drawing.Size(177, 17);
            this.chkBxRecursiveSearch.TabIndex = 6;
            this.chkBxRecursiveSearch.Text = "Search in folders and subfolders";
            this.chkBxRecursiveSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmAdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 437);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkBxRecursiveSearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBxExtension);
            this.Controls.Add(this.chkBxExtension);
            this.Controls.Add(this.txtBxHash);
            this.Controls.Add(this.chkBxHash);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtBxFolder);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 476);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 476);
            this.Name = "FrmAdvancedSearch";
            this.Text = "Advanced Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.CheckBox chkBxHash;
        private System.Windows.Forms.TextBox txtBxHash;
        private System.Windows.Forms.CheckBox chkBxExtension;
        private System.Windows.Forms.TextBox txtBxExtension;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chkBxRecursiveSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}