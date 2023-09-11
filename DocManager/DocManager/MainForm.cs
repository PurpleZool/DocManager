using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using DocManager.Components;

namespace DocManager
{
    public partial class MainForm : Form
    {

        private DocumentHandler docHandler;
        private BindingList<Document> docMirror;
        private int selectedRowIdx;
        Configuration mainConfig;

        #region INIT

        public MainForm()
        {
            InitializeComponent();
            mainConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            docHandler = new DocumentHandler();
            dataGridView1.AutoGenerateColumns = false;
            lstBxOperands.SelectedIndex = 0;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            StartupDefaultPath();
        }

        #endregion

        #region BUTTONS&EVENTS

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblFilePath.Text == string.Empty || lblFilePath.Visible == false)
            {
                MessageBox.Show("Select or drop the file to add", "Unable to add");
            }
            else
            {
                AddDocument(lblFilePath.Text, txtBxTitle.Text, txtBxTags.Text);
                ClearUI();
            }
        }
        private void btnCheckDocs_Click(object sender, EventArgs e)
        {
            docHandler.CheckDocuments();
            ReloadMirror();
            RefreshUI();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;  
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);  
            lblFilePath.Text = files[0];
            txtBxTitle.Text = Path.GetFileNameWithoutExtension(files[0]);
            if(!lblFilePath.Visible) lblFilePath.Visible = true;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //docHandler.Documents = new List<Document>(docMirror);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Any File (*.*)|*.*";
            openFileDialog.Title = "Add document";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblFilePath.Text = openFileDialog.FileName;
                lblFilePath.Visible = true;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                selectedRowIdx = e.RowIndex;

                Point mousePosition = dataGridView1.PointToClient(Cursor.Position);

                gridMenuStrip.Show(dataGridView1, mousePosition);  
            }
        }


        private void btnRefhreshFltr_Click(object sender, EventArgs e)
        {
            chkBoxTags.Checked = false;
            txtBoxTagFltr1.Text = txtBoxTagFltr2.Text = string.Empty;
            ReloadMirror();
            dataGridView1.DataSource = docMirror;
            dataGridView1.Refresh();
        }

        private void btnFilterApply_Click(object sender, EventArgs e)
        {

            docMirror = new BindingList<Document>();
            if (chkBoxTags.Checked == true)
            {
                bool isAnd = true;
                isAnd = lstBxOperands.SelectedIndex == 0;
                docHandler.GetDocumentsByTags(txtBoxTagFltr1.Text.ToUpper(),txtBoxTagFltr2.Text.ToUpper(),isAnd).ForEach(d => docMirror.Add(d));
            }
            dataGridView1.DataSource = docMirror;
            dataGridView1.Refresh();
        }

        #endregion

        #region FORMSTRIP

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "LDM Files (*.ldm)|*.ldm";
            saveFileDialog.Title = "Save .ldm File";
            if(saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    docHandler.Save(saveFileDialog.FileName);
                    MessageBox.Show(string.Format("Succesfully saved in {0}", saveFileDialog.FileName), "Document Save");
                }catch(Exception ex) 
                {
                    MessageBox.Show(string.Format("Unable to save in {0} :: {1}, a new one will be created.", saveFileDialog.FileName, ex.Message),"Document Save");
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "LDM Files (*.ldm)|*.ldm";
            openFileDialog.Title = "Open .ldm File";
            if(openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                this.docHandler.Documents = docHandler.Load(openFileDialog.FileName);
                if (mainConfig.AppSettings.Settings["checkOnLoad"].Value == "1") docHandler.CheckDocuments();
                ReloadMirror();
                RefreshUI();
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPreferences preferences = new FrmPreferences(mainConfig);
            preferences.SaveApply += SaveApplyConfig;
            preferences.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void advancedSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdvancedSearch frmSearch = new FrmAdvancedSearch();
            frmSearch.ShowDialog();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try 
            { 
                docHandler.Save(mainConfig.AppSettings.Settings["defaultPath"].Value);
                MessageBox.Show(string.Format("Succesfully saved in {0}", mainConfig.AppSettings.Settings["defaultPath"].Value),"Document Save");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(string.Format("Unable to save in {0} :: {1}, a new one will be created.", mainConfig.AppSettings.Settings["defaultPath"].Value, ex.Message),"Document Save");
                StartupDefaultPath(true);
            }
        }

        private void saveQuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click_1(sender, e);
            this.Close();

        }
        #endregion

        #region GRIDSTRIP

        private void toolStripMenuItemOpenFolder_Click(object sender, EventArgs e)
        {
            Document currentDoc = docHandler.GetDocumentByIdx(dataGridView1.Rows[selectedRowIdx].Cells[0].Value.ToString());
            if (!Directory.Exists(currentDoc.Directory))
            {
                MessageBox.Show("The folder is not found, likely it has been moved or deleted.", "Folder not found");
            }
            else
            {
                if (File.Exists(currentDoc.PathRaw))
                {
                    Process.Start("explorer.exe", $"/select,\"{currentDoc.PathRaw}\"");
                }
                else 
                {
                    Process.Start("explorer.exe", currentDoc.Directory);
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document currentDoc = docHandler.GetDocumentByIdx(dataGridView1.Rows[selectedRowIdx].Cells[0].Value.ToString());

            if (!File.Exists(currentDoc.PathRaw))
            {
                MessageBox.Show("The file is not found, likely it has been moved or deleted.", "File not found");
            }
            else
            {
                Process.Start("explorer.exe", currentDoc.PathRaw);
            }
        }

        private void toolStripMenuItemCheck_Click(object sender, EventArgs e)
        {
            Document currentDoc = docHandler.GetDocumentByIdx(dataGridView1.Rows[selectedRowIdx].Cells[0].Value.ToString());
            docHandler.CheckDocument(currentDoc);
            RefreshUI();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document currentDoc = docHandler.GetDocumentByIdx(dataGridView1.Rows[selectedRowIdx].Cells[0].Value.ToString());

            if (!File.Exists(currentDoc.PathRaw))
            {
                MessageBox.Show("The file is not found, likely it has been moved or deleted.", "File not found");
            }
            else
            {
                FrmFileDetails details = new FrmFileDetails(currentDoc);
                details.ShowDialog();
            }
        }

        private void updateSignatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The stored signature of the file will be overwriten.\nApply?", "Update Signature", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Document currentDoc = docHandler.GetDocumentByIdx(dataGridView1.Rows[selectedRowIdx].Cells[0].Value.ToString());
                if (File.Exists(currentDoc.PathRaw))
                {
                    currentDoc.Hash = currentDoc.CalculateHash(HashAlgorithmName.SHA256);
                    ReloadMirror();
                    RefreshUI();
                }
                else
                {
                    MessageBox.Show("The file is not found, likely it has been moved or deleted.", "File not found");
                }
            }
        }
        private void copySignatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataGridView1.Rows[selectedRowIdx].Cells[4].Value.ToString());
        }

        #endregion

        #region METHODS
        private void StartupDefaultPath(bool overrideInit = false) 
        {
            
            if (mainConfig.AppSettings.Settings["defaultPath"].Value == "0" && !overrideInit) 
            {
                mainConfig.AppSettings.Settings["defaultPath"].Value = Directory.GetCurrentDirectory() + @"\userDocuments.ldm";
            }        

            if(mainConfig.AppSettings.Settings["autoLoad"].Value == "1") 
            {
                if (File.Exists(mainConfig.AppSettings.Settings["defaultPath"].Value))
                {
                    this.docHandler.Documents = docHandler.Load(mainConfig.AppSettings.Settings["defaultPath"].Value);
                    if (mainConfig.AppSettings.Settings["checkOnLoad"].Value == "1") docHandler.CheckDocuments();
                    ReloadMirror();
                    RefreshUI();
                }
                else 
                {
                    MessageBox.Show(string.Format("Unable load config from {0}. File not found", mainConfig.AppSettings.Settings["defaultPath"].Value), "Unable to auto load documents",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void ClearUI() 
        {
            txtBxTags.Text = txtBxTitle.Text = string.Empty;
            lblFilePath.Visible = false;
        }

        private void RefreshUI() 
        {
            dataGridView1.DataSource = docMirror;
            dataGridView1.Refresh();
        }

        private void ReloadMirror() 
        {
            docMirror = new BindingList<Document>();
            docHandler.Documents.ForEach(d => docMirror.Add(d));
        }

        private void SaveApplyConfig(Configuration newConfig, bool apply) 
        {
            this.mainConfig = newConfig;
            mainConfig.Save(ConfigurationSaveMode.Modified);
            if (apply) ConfigurationManager.RefreshSection("appSettings");
        }

        private void AddDocument(string documentPath, string title, string tagsStr) 
        {
            List<string> tags = ProccessTags(tagsStr);
            docHandler.AddDocument(documentPath, title, tags);
            ReloadMirror();
            RefreshUI();
        }

        private List<string> ProccessTags(string tagStr) 
        {
            if (lblTags.Text == string.Empty)
            {
                return new List<string>();
            }
            return tagStr.Split(',').Select(t => t.Trim().ToUpper()).ToList();
        }

        #endregion

    }
}
