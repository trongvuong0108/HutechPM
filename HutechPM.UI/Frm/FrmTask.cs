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
using DevExpress.XtraEditors;
using HutechPM.UI.FRM;

namespace HutechPM.UI.Frm
{
    public partial class FrmTask : Form
    {
        public string ProjectName { get; set; }
        public projectRole ProjectRole { get; set; }
        public string projectTaskId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Estimate { get; set; }
        public string Remaining { get; set; }
        public string Status { get; set; }
        public string userLoginRole { get; set; }
        public Data.Entities.User UserLogin { get; set; }
        public FrmTask()
        {

        }
        HutechNoteDbContext _dbContext;
        UserService userService;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        ProjectTaskService projectTaskService;
        List<ProjectDetail> projectDetails;
        public FrmTask(string projectName, projectRole ProjectRole, string projectTaskId, string taskName, string description, string owner, string estimate, string remaining, string status,Data.Entities.User userLogin)
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
            this.UserLogin = userLogin;
        }
        private async void FrmTask_Load(object sender, EventArgs e)
        {
           
            try
            {
                FrmLoader frmLoader = new FrmLoader();
                frmLoader.Show();
                projectDetails = await projectDetailService.getAllProjectDetail();
               
                frmLoader.Close();

              
                if(Owner != UserLogin.userName)
                {
                    comboBoxOwner.Enabled = false;
                }    
                else
                {
                    comboBoxOwner.Enabled = true;
                }
                if (projectTaskId != null)
                {
                    comboBoxProjectName.Enabled = false;
                }
                else
                {
                    comboBoxProjectName.Enabled = true;
                }
                

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
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
        private void listComboBoxOwner(string projectname)
        {
            this.comboBoxOwner.Items.Clear();  
            foreach (ProjectDetail projectDetail in projectDetails)
            {
                if (projectDetail.project.projectName == projectname)
                {
                    this.comboBoxOwner.Items.Add(projectDetail.user.userName);
                }
            }
        }
        private void listComboBoxProjectName()
        {
            this.comboBoxProjectName.Items.Clear();
            foreach (ProjectDetail projectDetail in projectDetails)
            {
                if (projectDetail.user.userName == Owner)
                {
                    this.comboBoxProjectName.Items.Add(projectDetail.project.projectName);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            FrmLoader frmLoader = new FrmLoader();
            try
            {
                /*foreach (Data.Entities.Project checkproject in await projectService.getAllProject())
                {
                    if (checkproject.projectName != comboBoxProjectName.Text)
                    {
                        throw new Exception("There is no such project in the system");
                    }
                    break;
                }*/
                if (textBoxTaskName.Text == "" || textBoxDescription.Text == "" || textBoxEstimate.Text == "" || textBoxRemaining.Text == "")
                {
                    throw new Exception("Please! Enter complete information");
                }
                if (textBoxTaskName.Text == "")
                {
                    throw new Exception("Please! Enter Task Name");
                }
                if (textBoxDescription.Text == "")
                {
                    throw new Exception("Please! Enter Description");
                }
                if (textBoxEstimate.Text == "")
                {
                    throw new Exception("Please! Enter Estimate");
                }
                if (textBoxRemaining.Text == "")
                {
                    throw new Exception("Please! Enter Remaining");
                }
                frmLoader.Show();
                if (projectTaskId != null)
                {
                    Guid guidprojectTaskId = new Guid(projectTaskId);
                    ProjectTask projectTask = await projectTaskService.findProjectTaskId(guidprojectTaskId);
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
                    ActionBaseResult result = await projectTaskService.upadteProjectTask(projectTask);
                    frmLoader.Close();
                    if (result.Success)
                    {
                        MessageBox.Show("Update task successfully");
                        uc_ListTask uc_ListTask = new uc_ListTask();

                        this.Close();
                    }
                }
                else
                {
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
                    foreach (ProjectDetail projectDetail in await projectDetailService.getAllProjectDetail())
                    {
                        if (projectDetail.user.userName == Owner && projectDetail.projectRole == ProjectRole)
                        {
                            projectTask.projectDetail = projectDetail;
                        }
                    }
                    ActionBaseResult result = await projectTaskService.AddProjectTask(projectTask);
                    frmLoader.Close();
                    if (result.Success)
                    {
                        MessageBox.Show("Create task successfully");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                frmLoader.Close();
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listComboBoxOwner(comboBoxProjectName.Text);
        }
    }
}
