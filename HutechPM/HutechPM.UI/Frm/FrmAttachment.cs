using HutechNote.Data.Services;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectAttachmentData;
using HutechPM.Data.Data.ProjectTaskData;
using HutechPM.Data.Entities;
using HutechPM.UI.FRM;
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
        string projectTaskId { get; set; }
        string projectTaskName { get; set; }
        private readonly ProjectAttachmentService projectAttachmentService;
        private readonly ProjectTaskService projectTaskService;
        private readonly HutechNoteDbContext _dbContext;
        private readonly FrmLoader frmLoader;
        public FrmAttachment()
        {
            //InitializeComponent();
        }

        public FrmAttachment(string projectTaskName, string projectTaskId)
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            projectAttachmentService = new ProjectAttachmentService(_dbContext);
            projectTaskService = new ProjectTaskService(_dbContext);
            this.projectTaskName = projectTaskName;
            this.projectTaskId = projectTaskId;
            frmLoader = new FrmLoader();
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
            frmLoader.Show();
            foreach (String file in openFileDialog.FileNames)
            {
                res = await fileUpload.uploadFile(file, file);
                MessageBox.Show(res);
            }
            frmLoader.Close();
            textBoxFileName.Text = res;

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private  async void buttonSave_Click(object sender, EventArgs e)
        {
            frmLoader.Show();
            List<ProjectTask> tasks = await projectTaskService.getAllProjectTask();
            ProjectAttachment attachment = new ProjectAttachment()
            {
                acttachmentId = Guid.NewGuid(),
                acttachmentName = textBoxProjectTaskName.Text,
                description = textBoxDescription.Text,
                dateCreate = DateTime.Now,
                acttachmentType = comboBoxTypeFile.Text,
                task = tasks.FirstOrDefault(x=>x.projectTaskid.Equals(projectTaskId)),
            };
            await projectAttachmentService.CreateProjectAttachment(attachment);
            frmLoader.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
