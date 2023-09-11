using System;
using System.IO;
using DocManager.Components;
using System.Windows.Forms;

namespace DocManager
{
    public partial class FrmFileDetails : Form
    {

        private Document document;

        public FrmFileDetails()
        {
            InitializeComponent();
        }

        public FrmFileDetails(Document document) : this() 
        {
            this.document = document;
        }

        private void FrmFileDetails_Load(object sender, EventArgs e)
        {
            
            FileInfo documentInfo = new FileInfo(document.PathRaw);

            lblTitle.Text = document.Title;
            lblFilePath.Text = document.PathRaw;
            lblName.Text = document.Name;
            lblLastStatus.Text = document.Status.ToString();
            lblStoredHash.Text = document.Hash;
            lblSize.Text = (documentInfo.Length / 1024 ).ToString(); //inKB
            lblCreation.Text = documentInfo.CreationTime.ToLongDateString();
            lblModified.Text = documentInfo.LastWriteTime.ToLongDateString();
            lblLastAccess.Text = documentInfo.LastAccessTime.ToLongDateString();


        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
