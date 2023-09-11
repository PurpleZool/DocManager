using System;
using System.Windows.Forms;
using DocManager.Components;

namespace DocManager
{
    public partial class FrmAdvancedSearch : Form
    {

        private FolderBrowserDialog selection = null;

        FolderBrowserDialog Selection 
        {
            get 
            {
                if (selection == null) 
                {
                    selection = new FolderBrowserDialog();
                }
                return selection;
            }
        }


        public FrmAdvancedSearch()
        {
            InitializeComponent();
            txtBxFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            Selection.SelectedPath = txtBxFolder.Text;
            if(selection.ShowDialog() == DialogResult.OK) 
            {
                txtBxFolder.Text = Selection.SelectedPath;
            }
        }

        private void chkBxHash_CheckedChanged(object sender, EventArgs e)
        {
            txtBxHash.Enabled = chkBxHash.Checked;
        }

        private void chkBxExtension_CheckedChanged(object sender, EventArgs e)
        {
            txtBxExtension.Enabled = chkBxExtension.Checked;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string hash = chkBxHash.Checked ? txtBxHash.Text : string.Empty;
            string extension = chkBxExtension.Checked ? string.Format(".{0}",txtBxExtension.Text.ToLower()) : string.Empty;
            FileFinder finder = new FileFinder(txtBxFolder.Text,hash,extension,chkBxRecursiveSearch.Checked);
            finder.AddFound += InsertItem;
            finder.ErrorMessage += RaiseErrorMessage;
            finder.StartSearch();
        }



        //DELEGATED 
        public void InsertItem(string item) 
        {
            listBox1.Items.Add(item);
        }

        public void RaiseErrorMessage(string message) 
        {
            MessageBox.Show(message, "Searching error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
