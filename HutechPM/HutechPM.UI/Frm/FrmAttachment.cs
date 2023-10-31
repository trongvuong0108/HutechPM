using HutechNote.Data.Services;
using HutechPM.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HutechPM.UI.Frm
{
    public partial class FrmAttachment : Form
    {
        string projectTaskId {  get; set; }
        string projectTaskName { get; set; }
        public FrmAttachment()
        {
            //InitializeComponent();
        }

        public FrmAttachment(string projectTaskName, string projectTaskId)
        {
            InitializeComponent();

            this.projectTaskName = projectTaskName;
            this.projectTaskId = projectTaskId;
        }

        private void FrmAttachment_Load(object sender, EventArgs e)
        {
            listComboBoxTypeAttachment();
            textBoxProjectTaskName.Text = projectTaskName;
        }
        private void listComboBoxTypeAttachment()
        {
            this.comboBoxTypeFile.Items.Clear();
            comboBoxTypeFile.Items.Add("Image");
            comboBoxTypeFile.Items.Add("Video");
            comboBoxTypeFile.Items.Add("Document");
            comboBoxTypeFile.Items.Add("Other");
        }

        private async void linkLabelChooseFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var res = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            FileUploadService fileUpload = new FileUploadService();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Title = "Browse Text Files";
            openFileDialog.ShowDialog();
            foreach (String file in openFileDialog.FileNames)
            {
                res = await fileUpload.uploadFile(file, file);
                MessageBox.Show(res);
            }
            textBoxFileName.Text = res;

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
