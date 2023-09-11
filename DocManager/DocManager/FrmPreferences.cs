using System;
using System.Configuration;
using System.Windows.Forms;

namespace DocManager
{
    public partial class FrmPreferences : Form
    {

        Configuration usedConfig;

        public delegate void ConfigurationHandler(Configuration config, bool apply);
        public event ConfigurationHandler SaveApply;

        private bool CheckOnLoad { get { return usedConfig.AppSettings.Settings["checkOnLoad"].Value == "1"; } }
        private bool AutoLoad { get { return usedConfig.AppSettings.Settings["autoLoad"].Value == "1"; } }
        private string DefaultPath { get { return usedConfig.AppSettings.Settings["defaultPath"].Value; } }

        
        
        public FrmPreferences(Configuration usedConfig)
        {
            InitializeComponent();
            this.usedConfig = usedConfig;
        }
        private void FrmPreferences_Load(object sender, EventArgs e)
        {
            chkBxCheckOnLoad.Checked = CheckOnLoad;
            chkBxAutoLoad.Checked = AutoLoad;
            txtBxDefaultPath.Text = DefaultPath;
        }
        private void SaveApplyConfig(bool apply) 
        {

            usedConfig.AppSettings.Settings["checkOnLoad"].Value = chkBxCheckOnLoad.Checked ? "1" : "0";
            usedConfig.AppSettings.Settings["autoLoad"].Value = chkBxAutoLoad.Checked ? "1" : "0";
            usedConfig.AppSettings.Settings["defaultPath"].Value = txtBxDefaultPath.Text;

            SaveApply?.Invoke(usedConfig,apply);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            SaveApplyConfig(false);
            this.Close();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            SaveApplyConfig(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(txtBxDefaultPath.Text);
            saveFileDialog.Filter = "LDM Files (*.ldm)|*.ldm";
            saveFileDialog.Title = "Set default .ldm File";
            if(saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                txtBxDefaultPath.Text = saveFileDialog.FileName;
            }
        }
    }
}
