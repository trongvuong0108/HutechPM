using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.Data.ProjectTaskData;
using HutechPM.Data.Entities;
using HutechPM.Data.UserData;
using HutechPM.UI.FRM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HutechPM.UI.Frm
{
    public partial class FrmProject : Form
    {
        HutechNoteDbContext _dbContext;
        UserService userService;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        List<Project> ListProject;
        List<ProjectTask> ListProjectTask;

        public FrmProject()
        {
            //InitializeComponent();
        }
        public string projectId { get; set; }
        public string projectName { get; set; }
        public string description { get; set; }
        public string owner { get; set; }
        public string dateStart { get; set; }
        public string dateEnd { get; set; }
        public bool isActive { get; set; }
        User UserNameLogin { get; set; }
        public FrmProject(string projectId, string projectName, string description, string owner, string dateStart, string dateEnd, bool isActive, User userNameLogin)
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
            projectService = new ProjectService(_dbContext);
            this.projectId = projectId;
            this.projectName = projectName;
            this.description = description;
            this.owner = owner;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.isActive = isActive;
            this.UserNameLogin = userNameLogin;
        }
        private async void FrmProject_Load(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndDate.CustomFormat = "dd/MM/yyyy";
            comboBoxOwner.DataSource = await userService.GetAllUsers();
            textBoxProjectName.Text = projectName;
            textBoxDescription.Text = description;
            comboBoxOwner.Text = owner;
            string[] dateStartSplit = dateStart.Split(' ');
            dateTimePickerStartDate.Value = DateTime.ParseExact(dateStartSplit[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string[] dateEndSplit = dateEnd.Split(' ');
            dateTimePickerEndDate.Value = DateTime.ParseExact(dateEndSplit[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (isActive)
            {
                radioButtonTrue.Checked = true;
            }
            else
            {
                radioButtonFalse.Checked = false;
            }

            if (UserNameLogin.userName != owner)
            {
                comboBoxOwner.Enabled = false;
            }
            else
            {
                comboBoxOwner.Enabled = true;
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (UserNameLogin.userName != comboBoxOwner.Text)
                {
                    throw new Exception("You do not have permission to edit this project");
                }
                Guid guidprojectId = new Guid(projectId);
                Project project = await projectService.findProjectId(guidprojectId);
                if (textBoxProjectName.Text == "" && textBoxDescription.Text == "")
                {
                    throw new Exception("Please! Enter complete information");
                }
                if (textBoxProjectName.Text == "")
                {
                    throw new Exception("Please! Enter project name");
                }
                frmLoader.Show();
                foreach (Data.Entities.Project checkproject in await projectService.getAllProject())
                {
                    if (checkproject.projectName == textBoxProjectName.Text && textBoxProjectName.Text != project.projectName)
                    {
                        throw new Exception("This project name already exists in the system");
                    }
                }
                if (textBoxDescription.Text == "")
                {
                    throw new Exception("Please! Enter Description");
                }

                project.projectName = textBoxProjectName.Text;
                project.description = textBoxDescription.Text;
                project.dateEnd = dateTimePickerEndDate.Value;
                if (radioButtonTrue.Checked)
                {
                    project.isActive = true;
                }
                else
                {
                    project.isActive = false;
                }

                ActionBaseResult result = await projectService.UpdateProject(project);
                frmLoader.Close();
                if (result.Success)
                {
                    MessageBox.Show("Update project successfully");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                frmLoader.Close();
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }
    }
}



