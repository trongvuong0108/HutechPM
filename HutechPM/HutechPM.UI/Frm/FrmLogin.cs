using DevExpress.XtraEditors;
using HutechPM.UI.Uc;
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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        uc_Signup uc_Signup;
        uc_Login uc_Login;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            uc_Login = new uc_Login();
            uc_Login.Dock = DockStyle.Fill;
            panelFormLogin.Controls.Add(uc_Login);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
        private void buttonSignup_Click(object sender, EventArgs e)
        {

        }

        private void labelCreate_Click(object sender, EventArgs e)
        {
            if (labelCreate.Text == "Create New Account ?")
            {
                uc_Signup = new uc_Signup();
                uc_Signup.Dock = DockStyle.Fill;
                panelFormSignup.Controls.Add(uc_Signup);
                uc_Signup.BringToFront();
                panelFormSignup.BringToFront();
                labelCreate.Text = "Back";
            }
            else if (labelCreate.Text == "Back")
            {
                uc_Login = new uc_Login();
                uc_Login.Dock = DockStyle.Fill;
                panelFormLogin.Controls.Add(uc_Login);
                panelFormLogin.BringToFront();
                panelFormSignup.Controls.Clear();
                labelCreate.Text = "Create New Account ?";
            }
        }
        private void panelFormSignup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}