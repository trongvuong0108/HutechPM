using DevExpress.XtraReports.Design;
using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.Data.ProjectTaskData;
using HutechPM.Data.Entities;
using HutechPM.Data.UserData;
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

namespace HutechPM.UI.Frm
{
    public partial class FrmProject : Form
    {
        HutechNoteDbContext _dbContext;
        UserService userService;
        ProjectTaskService projectTaskService;
        ProjectDetailService projectDetailService;
        List<Project> ListProject;
        List<ProjectTask> ListProjectTask;

        public FrmProject()
        {
            InitializeComponent();
           
        }
        public string projectName { get; set; }
        public string description { get; set; }
        public string owner { get; set; }
        public string dateStart { get; set; }
        public bool isActive { get; set; }
        public FrmProject(string projectName, string description, string owner, string dateStart, bool isActive)
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
            this.projectName = projectName;
            this.description = description;
            this.owner = owner;
            this.dateStart = dateStart;
            this.isActive = isActive;
        }

        private void FrmProject_Load(object sender, EventArgs e)
        {
            dateTimePickerStartdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartdate.CustomFormat = "dd/MM/yyyy";
            comboBoxOwner.DataSource = userService.GetAllUsers();
            textBoxProjectName.Text = projectName;
            textBoxDescription.Text = description;
            comboBoxOwner.Text = owner;
            string[] dateStartSplit = dateStart.Split(' ');
            dateTimePickerStartdate.Value = DateTime.ParseExact(dateStartSplit[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (isActive)
            {
                radioButtonTrue.Checked = true;
            }
            else
            {
                radioButtonFalse.Checked = false;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOwner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
