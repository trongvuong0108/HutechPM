using DevExpress.XtraRichEdit.Fields;
using HutechNote.Data.Data.ProjectData;
using HutechNote.Data.Data.UserData.DTOs;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.Entities;
using HutechPM.Data.UserData;
using HutechPM.UI.Frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutechPM.UI.Uc
{
    public partial class uc_ListEmployess : UserControl
    {
        HutechNoteDbContext _dbContext;
        UserService userService;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        public uc_ListEmployess()
        {
            InitializeComponent();

            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
            projectService = new ProjectService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
        }
        public User UserLogin { get; set; }
        public string ProjectNameLogin { get; set; }

        

        public void getUserLoginInUcListEmployess(User userlogin, string projectNameLogin)
        {
            this.UserLogin = userlogin;
            this.ProjectNameLogin = projectNameLogin;
        }

        List<User> Employess = new List<User>();
        List<ProjectDetail> EmployessProjectDetail = new List<ProjectDetail>();
        List<ProjectDetail> projectDetailOfUserLogin;
        List<ProjectDetail> projectDetails;
        List<User> users;
        private async void uc_ListEmployess_Load(object sender, EventArgs e)
        {
            MessageBox.Show(UserLogin.userName + ProjectNameLogin);
            projectDetailOfUserLogin = await projectDetailService.getAllProjectDetailByUser(UserLogin);
            projectDetails = await projectDetailService.getAllProjectDetail();
            users = await userService.GetAllUsers();
            getListEmployess(ProjectNameLogin);
            BindingSource bindingSourceProject = new BindingSource();
            bindingSourceProject.DataSource = await userService.getListUserDTO(Employess);
            gridControlEmployess.DataSource = bindingSourceProject;
        }

        public void getListEmployess(string ProjectNameLogin)
        {
            foreach (ProjectDetail projectDetail in projectDetails)
            {
                if (projectDetail.project.projectName == ProjectNameLogin)
                {
                    Employess.Add(projectDetail.user);
                }
            }
        }

        private void buttonAddMenber_Click(object sender, EventArgs e)
        {
           using(FrmInviteMenbers frmInviteMenbers = new FrmInviteMenbers(UserLogin, ProjectNameLogin, Employess))
           {
                if(frmInviteMenbers.ShowDialog() == DialogResult.OK)
                {

                }
           }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

