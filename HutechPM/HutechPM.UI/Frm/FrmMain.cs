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
        public User UserName { set; get; }

        public FrmMain()
        {
            InitializeComponent();
        }
        public delegate void userNameLogin(User userName);

        public FrmMain(User userName)
        {
            InitializeComponent();
            this.UserName = userName;
        }

        private void fluentDesignFormContainerMain_Click(object sender, EventArgs e)
        {

            //FrmCreateProject frmCreateProject = new FrmCreateProject();
            //userNameLogin userNameLogin = new userNameLogin(frmCreateProject.getUserLogin);
            //userNameLogin(UserName);
            //frmCreateProject.Show();


            //if (uc_ListProject == null)
            //{
            //    uc_ListProject = new uc_ListProject();
            //    uc_ListProject.Dock = DockStyle.Fill;
            //    //userNameLogin userNameLogin = new userNameLogin(uc_ListProject.getUserLoginInUcListProject);
            //     //userNameLogin(UserName); 

            //     fluentDesignFormContainerMain.Controls.Add(uc_ListProject);
            //    uc_ListProject.BringToFront();
            //}
            //else
            //{
            //    uc_ListProject.BringToFront();
            //}

            if (uc_ListTask == null)
            {
                uc_ListTask = new uc_ListTask();
                uc_ListTask.Dock = DockStyle.Fill;
                userNameLogin userNameLogin = new userNameLogin(uc_ListTask.getUserLoginInUcListTask(UserName);
                userNameLogin(UserName);

                fluentDesignFormContainerMain.Controls.Add(uc_ListTask);
                uc_ListTask.BringToFront();
            }
            else
            {
                uc_ListTask.BringToFront();
            }
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aaaaa");
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
