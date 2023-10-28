using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutechPM.UI.Frm
{
    public partial class FrmCreateProject : Form
    {
        public FrmCreateProject()
        {
            InitializeComponent();
        }

        private void FrmCreateProject_Load(object sender, EventArgs e)
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            panelCreateProject2.BringToFront();
            panelCreateHide.BringToFront();


        }

        private void buttonInvite_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelLater_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelLater_MouseHover(object sender, EventArgs e)
        {

            linkLabelLater.LinkBehavior = LinkBehavior.NeverUnderline;
        }
        private void linkLabelLater_MouseLeave(object sender, EventArgs e)
        {
            linkLabelLater.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelCreateProject2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
