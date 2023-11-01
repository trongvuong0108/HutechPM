using DevExpress.Utils.CodedUISupport;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.Entities;
using HutechPM.Data.UserData;
using HutechPM.UI.Components;
using HutechPM.UI.Frm;
using HutechPM.UI.FRM;
using HutechPM.UI.Uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static HutechPM.UI.Frm.FrmCreateProject;

namespace HutechNote.UI.Frm
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        uc_ListProject uc_ListProject;
        uc_ListTask uc_ListTask;
        uc_ListEmployess uc_ListEmployess;
        uc_UserProfile uc_UserProfile;
        uc_ChangePassword uc_ChangePassword;
        uc_Home uc_Home;
        HutechNoteDbContext _dbContext;
        UserService userService;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        public User UserLogin { set; get; }

        public FrmMain()
        {
            //InitializeComponent();
        }

        public delegate void userNameLogin(User userName);

        public delegate void userNameAndProjectNameLogin(User userName, string projectName);
        public FrmMain(User userLogin)
        {
            InitializeComponent();
            this.UserLogin = userLogin;
            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
            projectService = new ProjectService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);

        }
        List<ProjectDetail> projectDetailOfUserLogin;
        AccordionControlElement[] accordionControlElement = new AccordionControlElement[100];
        private async void createControlElement()
        {
            FrmLoader frmLoader = new FrmLoader();
            frmLoader.Show();
            accordionControlElementEmployess.Elements.Clear();
            projectDetailOfUserLogin = await projectDetailService.getAllProjectDetailByUser(UserLogin);
            foreach (ProjectDetail projectDetail in projectDetailOfUserLogin)
            {
                int i = 0;
                accordionControlElement[i] = new AccordionControlElement();
                accordionControlElement[i].Text = projectDetail.project.projectName;
                accordionControlElement[i].Style = ElementStyle.Item;
                accordionControlElement[i].Click += new EventHandler(openUcListEmployess);
                accordionControlElementEmployess.Elements.Add(accordionControlElement[i]);
                i++;
            }
            frmLoader.Close();
        }
        private void accordionControlElementEmployess_Click(object sender, EventArgs e)
        {
            barStaticItemTitle.Caption = accordionControlElementEmployess.Text;
            FrmMain_Load(sender, e);
        }
        private void openUcListEmployess(object sender, EventArgs e)
        {
            var accordionControlElement = sender as AccordionControlElement;      
            uc_ListEmployess = new uc_ListEmployess();
            uc_ListEmployess.Dock = DockStyle.Fill;
            userNameAndProjectNameLogin userNameAndProjectNameLogin = new userNameAndProjectNameLogin(uc_ListEmployess.getUserLoginInUcListEmployess);
            userNameAndProjectNameLogin(UserLogin, accordionControlElement.Text);
            fluentDesignFormContainerMain.Controls.Add(uc_ListEmployess);
            uc_ListEmployess.BringToFront();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            createControlElement();
        }
        private void fluentDesignFormContainerMain_Click(object sender, EventArgs e)
        {
            //FrmCreateProject frmCreateProject = new FrmCreateProject();
            //userNameLogin userNameLogin = new userNameLogin(frmCreateProject.getUserLogin);
            //userNameLogin(UserName);
            //frmCreateProject.Show();
        }
        private void accordionControlElementHome_Click(object sender, EventArgs e)
        {
            barStaticItemTitle.Caption = accordionControlElementHome.Text;
            if (uc_Home == null)
            {
                uc_Home = new uc_Home();
                uc_Home.Dock = DockStyle.Fill;
                fluentDesignFormContainerMain.Controls.Add(uc_Home);
                uc_Home.BringToFront();
            }
            else
            {
                uc_Home.BringToFront();
            }
        }

        private void accordionControlElementProject_Click(object sender, EventArgs e)
        {
            barStaticItemTitle.Caption = accordionControlElementProject.Text;
            if (uc_ListProject == null)
            {
                uc_ListProject = new uc_ListProject();
                uc_ListProject.Dock = DockStyle.Fill;
                userNameLogin userNameLogin = new userNameLogin(uc_ListProject.getUserLoginInUcListProject);
                userNameLogin(UserLogin);
                fluentDesignFormContainerMain.Controls.Add(uc_ListProject);
                uc_ListProject.BringToFront();
            }
            else
            {
                uc_ListProject.BringToFront();
            }
        }

        private void accordionControlElementTask_Click(object sender, EventArgs e)
        {
            barStaticItemTitle.Caption = accordionControlElementTask.Text;
            if (uc_ListTask == null)
            {
                uc_ListTask = new uc_ListTask();
                uc_ListTask.Dock = DockStyle.Fill;
                userNameLogin userNameLogin = new userNameLogin(uc_ListTask.getUserLoginInUcListTask);
                userNameLogin(UserLogin);
                fluentDesignFormContainerMain.Controls.Add(uc_ListTask);
                uc_ListTask.BringToFront();
            }
            else
            {
                uc_ListTask.BringToFront();
            }
        }

        private void accordionControlElementProfile_Click(object sender, EventArgs e)
        {
            barStaticItemTitle.Caption = accordionControlElementProfile.Text;

            if (uc_UserProfile == null)
            {
                uc_UserProfile = new uc_UserProfile();
                uc_UserProfile.Dock = DockStyle.Fill;
                userNameLogin userNameLogin = new userNameLogin(uc_UserProfile.getUserLoginInUcUserProfile);
                userNameLogin(UserLogin);
                fluentDesignFormContainerMain.Controls.Add(uc_UserProfile);
                uc_UserProfile.BringToFront();
            }
            else
            {
                uc_UserProfile.BringToFront();
            }
        }
        private void accordionControlElementChangePassword_Click(object sender, EventArgs e)
        {
            barStaticItemTittle.Caption = accordionControlElementChangePassword.Text;
            if (uc_ChangePassword == null)
            {
                uc_ChangePassword = new uc_ChangePassword();
                uc_ChangePassword.Dock = DockStyle.Fill;
                userNameLogin userNameLogin = new userNameLogin(uc_ChangePassword.getUserLoginInUcChangePassword);
                userNameLogin(UserLogin);

                fluentDesignFormContainerMain.Controls.Add(uc_ChangePassword);
                uc_ChangePassword.BringToFront();
            }
            else
            {
                uc_ChangePassword.BringToFront();
            }
        }

        private void accordionControlElementLogout_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Log out successfully");
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
