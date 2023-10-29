using HutechPM.Data.Common;
using HutechPM.Data.UserData;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HutechPM.Data.Entities;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HutechPM.Data.Data.ProjectTaskData;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using HutechNote.Data.Data.ProjectData;
using HutechPM.UI.Uc;
using HutechPM.Data.Data.ProjectDetailData;
using DevExpress.DataProcessing.InMemoryDataProcessor;

namespace HutechPM.UI.Frm
{
    public partial class FrmTask : Form
    {
        HutechNoteDbContext _dbContext;
        UserService userService;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        ProjectTaskService projectTaskService;
        public FrmTask()
        {

        }
        public string ProjectName { get; set; }
        public string ProjectRole { get; set; }
        public string projectTaskId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Estimate { get; set; }
        public string Remaining { get; set; }
        public string Status { get; set; }
        public FrmTask(string projectName, string ProjectRole, string projectTaskId, string taskName, string description, string owner, string estimate, string remaining, string status)
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
            projectService = new ProjectService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
            projectTaskService = new ProjectTaskService(_dbContext);
            this.ProjectName = projectName;
            this.ProjectRole = ProjectRole;
            this.projectTaskId = projectTaskId;
            this.TaskName = taskName;
            this.Description = description;
            this.Owner = owner;
            this.Estimate = estimate;
            this.Remaining = remaining;
            this.Status = status;

        }
        private void FrmTask_Load(object sender, EventArgs e)
        {
            if(projectTaskId != null)
            {
                comboBoxProjectName.Enabled = false;
            }
            else
            {
                comboBoxProjectName.Enabled = true;
            }
            listComboBoxOwner();
            listComboBoxStatus();
            listComboBoxProjectName();
            comboBoxProjectName.Text = ProjectName;
            textBoxTaskName.Text = TaskName;
            textBoxDescription.Text = Description;
            comboBoxOwner.Text = Owner;
            textBoxEstimate.Text = Estimate;
            textBoxRemaining.Text = Remaining;
            comboBoxStatus.Text = Status;
            listTaskStatus.Add(ProjectTask.TaskStatus.In_Process);
            listTaskStatus.Add(ProjectTask.TaskStatus.Completed);
            listTaskStatus.Add(ProjectTask.TaskStatus.On_Hold);
        }
        private void listComboBoxOwner()
        {
            foreach(ProjectDetail projectDetail in projectDetailService.getAllProjectDetail())
            {
                if(projectDetail.project.projectName == ProjectName)
                {
                    this.comboBoxOwner.Items.Add(projectDetail.user.userName);
                }
            }
        }
        List<ProjectTask.TaskStatus> listTaskStatus = new List<ProjectTask.TaskStatus>();


        private void listComboBoxStatus()
        {
            this.comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add(ProjectTask.TaskStatus.In_Process);
            comboBoxStatus.Items.Add(ProjectTask.TaskStatus.Completed);
            comboBoxStatus.Items.Add(ProjectTask.TaskStatus.On_Hold);

        }
        private void listComboBoxProjectName()
        {
            foreach (ProjectDetail projectDetail in projectDetailService.getAllProjectDetail())
            {
                if (projectDetail.user.userName == Owner)
                {
                    this.comboBoxOwner.Items.Add(projectDetail.project.projectName);
                }
            }
            /*List<Data.Entities.Project> projectName = projectService.getAllProject();
            this.comboBoxProjectName.DataSource = projectName;
            this.comboBoxProjectName.DisplayMember = "projectName";
            this.comboBoxProjectName.ValueMember = "projectId";*/
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (projectTaskId != null)
            {
                Guid guidprojectTaskId = new Guid(projectTaskId);
                ProjectTask projectTask = projectTaskService.findProjectTaskId(guidprojectTaskId);
                projectTask.name = textBoxTaskName.Text;
                projectTask.description = textBoxDescription.Text;
                projectTask.estimate = int.Parse(textBoxEstimate.Text);
                projectTask.remaining = int.Parse(textBoxRemaining.Text);
                foreach (ProjectTask.TaskStatus task in listTaskStatus)
                {
                    if (task.ToString() == comboBoxStatus.Text)
                    {
                        projectTask.taskStatus = task;
                    }
                }
                projectTaskService.upadteProjectTask(projectTask);
                MessageBox.Show("update thanh cong");
            }
            else
            {/*
                ProjectDetail projectDetail = new ProjectDetail();
                projectDetail.projectDetailId = Guid.NewGuid();
                foreach (Data.Entities.User user in userService.GetAllUsers())
                {
                    user.userName = comboBoxOwner.Text;
                    projectDetail.user_id = user.userId;
                }
                projectDetail.timeJoin = DateTime.Now;
                projectDetail.timeLeft = DateTime.Now;
                foreach (Project project in projectService.getAllProject())
                {
                    if (project.projectName == comboBoxProjectName.Text)
                    {
                        projectDetail.project = project;
                    }
                }
                projectDetailService.AddProjectDetail(projectDetail);*/

                ProjectTask projectTask = new ProjectTask();
                projectTask.projectTaskid = Guid.NewGuid();
                projectTask.name = textBoxTaskName.Text;
                projectTask.description = textBoxDescription.Text;
                projectTask.estimate = int.Parse(textBoxEstimate.Text);
                projectTask.remaining = int.Parse(textBoxRemaining.Text);
                foreach (ProjectTask.TaskStatus task in listTaskStatus)
                {
                    if (task.ToString() == comboBoxStatus.Text)
                    {
                        projectTask.taskStatus = task;
                    }
                }
                foreach(ProjectDetail projectDetail in projectDetailService.getAllProjectDetail())
                {
                    if(projectDetail.user.userName == Owner && projectDetail.project.projectName == ProjectName)
                    {
                        projectTask.projectDetail = projectDetail;
                    }
                }
                projectTaskService.AddProjectTask(projectTask);
            }
        }

        private void textBoxTaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOwner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
