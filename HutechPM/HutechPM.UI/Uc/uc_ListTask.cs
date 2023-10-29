using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Common;
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

namespace HutechPM.UI.Uc
{
    public partial class uc_ListTask : UserControl
    {
        HutechNoteDbContext _dbContext;
        ProjectService projectService;
        ProjectTaskService projectTaskService;
        ProjectDetailService projectDetailService;
        List<Project> ListProject;
        List<ProjectTask> ListProjectTask;
        public uc_ListTask()
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            projectService = new ProjectService(_dbContext);
            projectTaskService = new ProjectTaskService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
        }
        public string userNameLogin { get; set; }
        public void getUserLoginInUcListProject(string userNameLogin)
        {
            this.userNameLogin = userNameLogin;
        }
        private async void uc_ListTask_Load(object sender, EventArgs e)
        {
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
            string projectTaskid = gridViewTask.GetFocusedRowCellValue("projectTaskid").ToString();
            string projectName = gridViewTask.GetFocusedRowCellValue("projectDetail.project.projectName").ToString();
            string taskName = gridViewTask.GetFocusedRowCellValue("name").ToString();
            string description;
            if (gridViewTask.GetFocusedRowCellValue("description") == null)
            {
                description = null;
            }
            else
            {
                description = gridViewTask.GetFocusedRowCellValue("description").ToString();
            }
            string owner = gridViewTask.GetFocusedRowCellValue("projectDetail.user.userName").ToString();
            string estimate = gridViewTask.GetFocusedRowCellValue("estimate").ToString();
            string remaining = gridViewTask.GetFocusedRowCellValue("remaining").ToString();
            string status = gridViewTask.GetFocusedRowCellValue("taskStatus").ToString();
            using (FrmTask frmTask = new FrmTask(projectName, projectTaskid, taskName, description, owner, estimate, remaining, status))
            {
                if (frmTask.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void ItemButtonDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ItemButtonuploadFile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string projectName = "";
            string projectTaskid ="";
            string taskName = "";
            string description = "";
           // userNameLogin = "admin";
            string owner = "admin";
            string estimate = "";
            string remaining = "";
            string status = "In_Process";
            FrmTask frmTask = new FrmTask(projectName, projectTaskid, taskName, description, owner, estimate, remaining, status);
            frmTask.Show();

        }


        private void gridControlGridTask_Click(object sender, EventArgs e)
        {

        }


    }
}
