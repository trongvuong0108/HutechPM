
using DevExpress.XtraEditors;
using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectAttachmentData;
using HutechPM.Data.Data.ProjectData.DTO;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.Data.ProjectTaskData;
using HutechPM.Data.Entities;
using HutechPM.UI.Frm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HutechPM.UI.Uc
{
    public partial class uc_ListTask : UserControl
    {

        public string getProjectTaskid { get; set; }
        public string getProjectName { get; set; }
        public string getTaskName { get; set; }
        public string getDescription { get; set; }
        public string getOwner { get; set; }

        public string getEstimate { get; set; }
        public string getRemaining { get; set; }
        public string getStatus { get; set; }

        HutechNoteDbContext _dbContext;
        ProjectService projectService;
        ProjectTaskService projectTaskService;
        ProjectDetailService projectDetailService;
        ProjectAttachmentService projectAttachmentService;
        List<Project> ListProject;
        List<ProjectTask> ListProjectTask;
        public uc_ListTask()
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            projectService = new ProjectService(_dbContext);
            projectTaskService = new ProjectTaskService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
            projectAttachmentService = new ProjectAttachmentService(_dbContext);
        }
        public projectRole userProjectRole { get; set; }
        public User UserLogin { get; set; }

        public void getUserLoginInUcListTask(User userlogin)
        {
            this.UserLogin = userlogin;
        }
        private async void uc_ListTask_Load(object sender, EventArgs e)
        {
            ListProject = await projectService.getAllProject();

            ListProjectTask = await projectTaskService.getAllProjectTask();
            BindingSource bindingSourceProject = new BindingSource();
            bindingSourceProject.DataSource = ListProjectTask;
            gridControlGridTask.DataSource = bindingSourceProject;

            ItemButtonUpdate.Click += ItemButtonUpdate_Click;
            ItemButtonDelete.Click += ItemButtonDelete_Click;
            ItemButtonuploadFile.Click += ItemButtonuploadFile_Click;
        }
        private void ItemButtonUpdate_Click(object sender, EventArgs e)
        {
            getProjectTaskid = gridViewTask.GetFocusedRowCellValue("projectTaskid").ToString();
            getProjectName = gridViewTask.GetFocusedRowCellValue("projectDetail.project.projectName").ToString();
            getTaskName = gridViewTask.GetFocusedRowCellValue("name").ToString();
            getDescription = gridViewTask.GetFocusedRowCellValue("description").ToString();
            getOwner = gridViewTask.GetFocusedRowCellValue("projectDetail.user.userName").ToString();
            getEstimate = gridViewTask.GetFocusedRowCellValue("estimate").ToString();
            getRemaining = gridViewTask.GetFocusedRowCellValue("remaining").ToString();
            getStatus = gridViewTask.GetFocusedRowCellValue("taskStatus").ToString();
            using (FrmTask frmTask = new FrmTask(getProjectName, userProjectRole, getProjectTaskid, getTaskName, getDescription, getOwner, getEstimate, getRemaining, getStatus))
            {
                if (frmTask.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private async void ItemButtonDelete_Click(object sender, EventArgs e)
        {
            getProjectTaskid = gridViewTask.GetFocusedRowCellValue("projectTaskid").ToString();
            Guid guidgetProjectTaskid = new Guid(getProjectTaskid);
            getTaskName = gridViewTask.GetFocusedRowCellValue("name").ToString();

            if (XtraMessageBox.Show($"Do you want to delete project '" + getTaskName + "'", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewTask.DeleteSelectedRows();
                ProjectTask deleteprojectTask = await projectTaskService.findProjectTaskId(guidgetProjectTaskid);
                foreach (ProjectAttachment delteprojectAttachment in await projectAttachmentService.getAllProjectAttachment())
                {
                    if (delteprojectAttachment.task.projectTaskid == deleteprojectTask.projectTaskid)
                    {
                        await projectAttachmentService.DeleteProjectAttachment(delteprojectAttachment);
                    }
                }
                await projectTaskService.DeleteProjectTask(deleteprojectTask);
            }
        }

        private void ItemButtonuploadFile_Click(object sender, EventArgs e)
        {
            string projectTaskName = gridViewTask.GetFocusedRowCellValue("name").ToString();
            using (FrmAttachment frmAttachment = new FrmAttachment(projectTaskName))
            {
                if (frmAttachment.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }


        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            string projectName = null;
            foreach (ProjectDetail projectDetail in await projectDetailService.getAllProjectDetail())
            {
                if (projectDetail.user.userId == UserLogin.userId)
                {
                    userProjectRole = projectDetail.projectRole;
                }
            }
            string projectTaskid = null;
            string taskName = null;
            string description = null;
            string owner = UserLogin.userName;
            string estimate = null;
            string remaining = null;
            string status = "In_Process";
            FrmTask frmTask = new FrmTask(projectName, userProjectRole, projectTaskid, taskName, description, owner, estimate, remaining, status);
            frmTask.Show();
        }


        private void gridControlGridTask_Click(object sender, EventArgs e)
        {

        }

        private async void buttonSelectDelete_Click(object sender, EventArgs e)
        {
            List<int> row = gridViewTask.GetSelectedRows().Where(c => c >= 0).ToList();
            foreach (var item in row)
            {
                getProjectTaskid = gridViewTask.GetFocusedRowCellValue("projectTaskid").ToString();
                Guid guidgetProjectTaskid = new Guid(getProjectTaskid);
                getTaskName = gridViewTask.GetFocusedRowCellValue("name").ToString();

                if (XtraMessageBox.Show($"Do you want to delete task '" + getTaskName + "'", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProjectTask deleteprojectTask = await projectTaskService.findProjectTaskId(guidgetProjectTaskid);
                    foreach (ProjectAttachment delteprojectAttachment in await projectAttachmentService.getAllProjectAttachment())
                    {
                        if (delteprojectAttachment.task.projectTaskid == deleteprojectTask.projectTaskid)
                        {
                            await projectAttachmentService.DeleteProjectAttachment(delteprojectAttachment);
                        }
                    }
                    await projectTaskService.DeleteProjectTask(deleteprojectTask);
                }
            }
            foreach (var item in row)
            {
                gridViewTask.DeleteSelectedRows();
            }
        }
        private void gridViewTask_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            getProjectTaskid = gridViewTask.GetFocusedRowCellValue("projectTaskid").ToString();
            getProjectName = gridViewTask.GetFocusedRowCellValue("projectDetail.project.projectName").ToString();
            getTaskName = gridViewTask.GetFocusedRowCellValue("name").ToString();
            getDescription = gridViewTask.GetFocusedRowCellValue("description").ToString();
            getOwner = gridViewTask.GetFocusedRowCellValue("projectDetail.user.userName").ToString();
            getEstimate = gridViewTask.GetFocusedRowCellValue("estimate").ToString();
            getRemaining = gridViewTask.GetFocusedRowCellValue("remaining").ToString();
            getStatus = gridViewTask.GetFocusedRowCellValue("taskStatus").ToString();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            getProjectTaskid = gridViewTask.GetFocusedRowCellValue("projectTaskid").ToString();
            getProjectName = gridViewTask.GetFocusedRowCellValue("projectDetail.project.projectName").ToString();
            getTaskName = gridViewTask.GetFocusedRowCellValue("name").ToString();
            getDescription = gridViewTask.GetFocusedRowCellValue("description").ToString();
            getOwner = gridViewTask.GetFocusedRowCellValue("projectDetail.user.userName").ToString();
            getEstimate = gridViewTask.GetFocusedRowCellValue("estimate").ToString();
            getRemaining = gridViewTask.GetFocusedRowCellValue("remaining").ToString();
            getStatus = gridViewTask.GetFocusedRowCellValue("taskStatus").ToString();
            using (FrmTask frmTask = new FrmTask(getProjectName, userProjectRole, getProjectTaskid, getTaskName, getDescription, getOwner, getEstimate, getRemaining, getStatus))
            {
                if (frmTask.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }
    }
}
