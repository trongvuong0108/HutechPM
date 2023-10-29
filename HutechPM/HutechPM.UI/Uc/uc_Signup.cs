using DevExpress.XtraEditors;
using HutechNote.Data.Data.UserData.DTOs;
using HutechPM.Data.Common;
using HutechPM.Data.UserData;
using HutechPM.UI.FRM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            FrmSplashScreen frmSplashScreen = new FrmSplashScreen();
            UserDTO userDTO = new UserDTO()
            {
                userName = textBoxUsername.Text.Trim(),
                password = textBoxPassword.Text.Trim(),
                email = textBoxEmail.Text.Trim(),
                phone = textBoxPhone.Text.Trim(),
                fullName = textBoxFullname.Text.Trim(),
                address = textBoxAddress.Text.Trim(),
            };
            using (HutechNoteDbContext dbContext = new HutechNoteDbContext())
            {
                UserService userService = new UserService(dbContext);
                frmSplashScreen.Show();
                ActionBaseResult result = await userService.CreateUser(userDTO);
                frmSplashScreen.Close();
                if (result.Success)
                {
                    XtraMessageBox.Show("SignUp successful");
                }
                else
                {
                    XtraMessageBox.Show("Sign up Fail!! Exception: " + result.Message);
                }
            }
        }
    }
}
