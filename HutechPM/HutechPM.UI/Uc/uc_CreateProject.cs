using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutechPM.UI.Components
{
    public partial class uc_CreateProject : UserControl
    {
        public uc_CreateProject()
        {
            InitializeComponent();
        }

        private void uc_CreateProject_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelLater_Link_MouseHover(object sender, EventArgs e)
        {
            linkLabelLater.LinkBehavior = LinkBehavior.NeverUnderline;
        }
        private void linkLabelLater_Link_MouseLeave(object sender, EventArgs e)
        {
            linkLabelLater.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            panelCreateProject2.BringToFront();
            panelCreateProject1.Controls.Clear();
            panelCreateHide.BringToFront();
        }

        private void linkLabelLater_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
