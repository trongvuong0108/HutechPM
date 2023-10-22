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
        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            panelSignupLast.BringToFront();
        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            panelSignupFirst.BringToFront();
        }
        private void checkBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowpassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxConfirmPass.UseSystemPasswordChar = true;
            }
        }
    }
}
