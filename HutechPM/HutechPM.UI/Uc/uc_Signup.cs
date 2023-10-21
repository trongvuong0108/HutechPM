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
    public partial class uc_Signup : UserControl
    {
        public uc_Signup()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            panelSignupFirst.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panelSignupFirst_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            panelSignupLast.BringToFront();
        }



        private void uc_Signup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            panelSignupFirst.BringToFront();
        }
    }
}
