
namespace DocManager
{
    partial class FrmPreferences
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
            this.chkBxCheckOnLoad = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.chkBxAutoLoad = new System.Windows.Forms.CheckBox();
            this.lbldefaultFile = new System.Windows.Forms.Label();
            this.lbldefaultPathDescr = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grpBoxStartupPath = new System.Windows.Forms.GroupBox();
            this.txtBxDefaultPath = new System.Windows.Forms.TextBox();
            this.pnlSettings.SuspendLayout();
            this.grpBoxStartupPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBxCheckOnLoad
            // 
            this.chkBxCheckOnLoad.AutoSize = true;
            this.chkBxCheckOnLoad.Location = new System.Drawing.Point(6, 152);
            this.chkBxCheckOnLoad.Name = "chkBxCheckOnLoad";
            this.chkBxCheckOnLoad.Size = new System.Drawing.Size(181, 17);
            this.chkBxCheckOnLoad.TabIndex = 0;
            this.chkBxCheckOnLoad.Text = "Check files integrity after loading.";
            this.chkBxCheckOnLoad.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(158, 196);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(69, 25);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(308, 196);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(69, 25);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSettings.Controls.Add(this.grpBoxStartupPath);
            this.pnlSettings.Controls.Add(this.chkBxCheckOnLoad);
            this.pnlSettings.Location = new System.Drawing.Point(12, 12);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(365, 178);
            this.pnlSettings.TabIndex = 2;
            // 
            // chkBxAutoLoad
            // 
            this.chkBxAutoLoad.AutoSize = true;
            this.chkBxAutoLoad.Location = new System.Drawing.Point(9, 116);
            this.chkBxAutoLoad.Name = "chkBxAutoLoad";
            this.chkBxAutoLoad.Size = new System.Drawing.Size(135, 17);
            this.chkBxAutoLoad.TabIndex = 1;
            this.chkBxAutoLoad.Text = "Load config on startup.";
            this.chkBxAutoLoad.UseVisualStyleBackColor = true;
            // 
            // lbldefaultFile
            // 
            this.lbldefaultFile.AutoSize = true;
            this.lbldefaultFile.Location = new System.Drawing.Point(6, 16);
            this.lbldefaultFile.Name = "lbldefaultFile";
            this.lbldefaultFile.Size = new System.Drawing.Size(100, 13);
            this.lbldefaultFile.TabIndex = 2;
            this.lbldefaultFile.Text = "Default working file:";
            // 
            // lbldefaultPathDescr
            // 
            this.lbldefaultPathDescr.Location = new System.Drawing.Point(6, 80);
            this.lbldefaultPathDescr.Name = "lbldefaultPathDescr";
            this.lbldefaultPathDescr.Size = new System.Drawing.Size(340, 33);
            this.lbldefaultPathDescr.TabIndex = 3;
            this.lbldefaultPathDescr.Text = "This file will be the used to store your document node  by default. Also it can b" +
    "e loaded during the startup checking the next setting.";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(9, 57);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(47, 20);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grpBoxStartupPath
            // 
            this.grpBoxStartupPath.Controls.Add(this.txtBxDefaultPath);
            this.grpBoxStartupPath.Controls.Add(this.btnSelect);
            this.grpBoxStartupPath.Controls.Add(this.chkBxAutoLoad);
            this.grpBoxStartupPath.Controls.Add(this.lbldefaultFile);
            this.grpBoxStartupPath.Controls.Add(this.lbldefaultPathDescr);
            this.grpBoxStartupPath.Location = new System.Drawing.Point(6, 3);
            this.grpBoxStartupPath.Name = "grpBoxStartupPath";
            this.grpBoxStartupPath.Size = new System.Drawing.Size(352, 143);
            this.grpBoxStartupPath.TabIndex = 5;
            this.grpBoxStartupPath.TabStop = false;
            this.grpBoxStartupPath.Text = "Working file";
            // 
            // txtBxDefaultPath
            // 
            this.txtBxDefaultPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxDefaultPath.Location = new System.Drawing.Point(9, 33);
            this.txtBxDefaultPath.Name = "txtBxDefaultPath";
            this.txtBxDefaultPath.ReadOnly = true;
            this.txtBxDefaultPath.Size = new System.Drawing.Size(337, 20);
            this.txtBxDefaultPath.TabIndex = 5;
            // 
            // FrmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 231);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(405, 270);
            this.Name = "FrmPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.FrmPreferences_Load);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.grpBoxStartupPath.ResumeLayout(false);
            this.grpBoxStartupPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBxCheckOnLoad;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.CheckBox chkBxAutoLoad;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lbldefaultPathDescr;
        private System.Windows.Forms.Label lbldefaultFile;
        private System.Windows.Forms.GroupBox grpBoxStartupPath;
        private System.Windows.Forms.TextBox txtBxDefaultPath;
    }
}