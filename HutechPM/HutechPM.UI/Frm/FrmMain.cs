using DevExpress.Utils.CodedUISupport;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using HutechPM.Data.Entities;
using HutechPM.UI.Components;
using HutechPM.UI.Frm;
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
        public User UserLogin { set; get; }

        public FrmMain()
        {
            //InitializeComponent();
        }

        public delegate void userNameLogin(User userName);

        public FrmMain(User userLogin)
        {
            InitializeComponent();
            this.UserLogin = userLogin;
        }
        AccordionControlElement[] accordionControlElement = new AccordionControlElement[100];
        private void createControlElement()
        {
            for (int i = 0; i < 5; i++)
            {
                accordionControlElement[i] = new AccordionControlElement();
                accordionControlElement[i].Text = i.ToString();
                accordionControlElement[i].Style = ElementStyle.Item;
                accordionControlElement[i].Click += new EventHandler(thongbao);
                accordionControlElement1.Elements.Add(accordionControlElement[i]);
                //var a = accordionControlElement.to

            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {



            /*private void thongbao(object sender, EventArgs e)
            {
                var accordionControlElement = sender as AccordionControlElement;
                if (accordionControlElement.Text == "1")

                    MessageBox.Show(accordionControlElement.Text);

            }*/

        }
        private void fluentDesignFormContainerMain_Click(object sender, EventArgs e)
        {

            //FrmCreateProject frmCreateProject = new FrmCreateProject();
            //userNameLogin userNameLogin = new userNameLogin(frmCreateProject.getUserLogin);
            //userNameLogin(UserName);
            //frmCreateProject.Show();





        }

        /*private void accordionControlElementProject_Click(object sender, EventArgs e)
        {
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
        }*/


        private void accordionControlElementTasks_Click(object sender, EventArgs e)
        {
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


        private void accordionControlElementEmployees_Click(object sender, EventArgs e)
        {
            if (uc_ListEmployess == null)
            {
                uc_ListEmployess = new uc_ListEmployess();
                uc_ListEmployess.Dock = DockStyle.Fill;
                userNameLogin userNameLogin = new userNameLogin(uc_ListEmployess.getUserLoginInUcListEmployess);
                userNameLogin(UserLogin);

                fluentDesignFormContainerMain.Controls.Add(uc_ListEmployess);
                uc_ListEmployess.BringToFront();
            }
            else
            {
                uc_ListEmployess.BringToFront();
            }
        }

        private void accordionControlElementMyprofile_Click(object sender, EventArgs e)
        {
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

        private void accordionControlElementHome_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElementChangePassword_Click(object sender, EventArgs e)
        {
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
    }
}
