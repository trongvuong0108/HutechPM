using DevExpress.XtraEditors;
using HutechNote.Data.Services;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectAttachmentData;
using HutechPM.Data.Data.ProjectTaskData;
using HutechPM.Data.Entities;
using HutechPM.UI.FRM;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace HutechPM.UI.Frm
{
    public partial class FrmAttachment : Form
    {
        string projectTaskId { get; set; }
        string projectTaskName { get; set; }
        private readonly ProjectAttachmentService projectAttachmentService;
        private readonly ProjectTaskService projectTaskService;
        private readonly HutechNoteDbContext _dbContext;
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
            getAttachment();

        }

        public async void getAttachment()
        {
            foreach (ProjectAttachment projectAttachment in await projectAttachmentService.getAllProjectAttachment())
            {
                Guid getGuidprojectTaskId = new Guid(projectTaskId);
                if (projectAttachment.task.projectTaskid == getGuidprojectTaskId)
                {
                    textBoxFileName.Text = projectAttachment.filename;
                    textBoxDescription.Text = projectAttachment.description;
                    comboBoxTypeFile.Text = projectAttachment.acttachmentType;
                }
            }
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
            FrmLoader frmLoader = new FrmLoader();
            frmLoader.Show();
            foreach (String file in openFileDialog.FileNames)
            {
                res = await fileUpload.uploadFile(file, file);
                XtraMessageBox.Show(res);
            }
            frmLoader.Close();
            textBoxFileName.Text = res;

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxDescription.Text == "" || comboBoxTypeFile.Text == "")
                {
                    throw new Exception("Please! Enter complete information");
                }   
                FrmLoader frmLoader = new FrmLoader();
                frmLoader.Show();
                Guid getguid = new Guid(projectTaskId);
                List<ProjectTask> tasks = await projectTaskService.getAllProjectTask();
                ProjectAttachment attachment = new ProjectAttachment()
                {
                    acttachmentId = Guid.NewGuid(),
                    acttachmentName = textBoxProjectTaskName.Text,
                    description = textBoxDescription.Text,
                    filename = textBoxFileName.Text,
                    dateCreate = DateTime.Now,
                    acttachmentType = comboBoxTypeFile.Text,
                    task = tasks.FirstOrDefault(x => x.projectTaskid == getguid),
                };
                ActionBaseResult result = await projectAttachmentService.CreateProjectAttachment(attachment);
                if (result.Success)
                {
                    frmLoader.Close();
                    XtraMessageBox.Show("Add file attachment successfully");
                }
            }catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OKCancel);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "chrome";
                process.StartInfo.Arguments = textBoxFileName.Text.Trim();
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
