using DevExpress.XtraBars;
using HutechPM.UI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HutechNote.UI.Frm
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        uc_CreateProject uc_CreateProject;
        private void fluentDesignFormContainerMain_Click(object sender, EventArgs e)
        {
            if (uc_CreateProject == null)
            {
                uc_CreateProject = new uc_CreateProject();
                uc_CreateProject.Dock = DockStyle.Fill;
                fluentDesignFormContainerMain.Controls.Add(uc_CreateProject);
                uc_CreateProject.BringToFront();
            }
            else
            {
                uc_CreateProject.BringToFront();
            }
        }
    }
}
