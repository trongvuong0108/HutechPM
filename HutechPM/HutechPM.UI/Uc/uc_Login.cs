using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
using HutechPM.Data.Common;
using HutechPM.Data.UserData;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HutechPM.UI.Uc
{
    public partial class uc_Login : UserControl
    {
        public uc_Login()
        {
            InitializeComponent();
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            textBoxUser.BackColor = Color.White;
            pictureBoxUser.BackColor = Color.White;
            pictureBoxIconUser.BackColor = Color.White;
            textBoxPassword.BackColor = SystemColors.Control;
            pictureBoxPasswork.BackColor = SystemColors.Control;
            pictureBoxIconLock.BackColor = SystemColors.Control;

        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
            pictureBoxPasswork.BackColor = Color.White;
            pictureBoxIconLock.BackColor = Color.White;
            textBoxUser.BackColor = SystemColors.Control;
            pictureBoxUser.BackColor = SystemColors.Control;
            pictureBoxIconUser.BackColor = SystemColors.Control;

        }

        private void labelForget_Click(object sender, EventArgs e)
        {
        }


        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUser.Text;
            string password = textBoxPassword.Text;
            using (HutechNoteDbContext dbContext = new HutechNoteDbContext())
            {
                UserService userService = new UserService(dbContext);
                if(userService.login(userName, password))
                {
                    XtraMessageBox.Show("Login successful");
                }
            }
        }
    }
}
