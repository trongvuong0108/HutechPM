using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
using HutechNote.UI.Frm;
using HutechPM.Data.Common;
using HutechPM.Data.UserData;
using HutechPM.UI.Frm;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
        public bool checkEmailAddress(string emailAddress)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(emailAddress))
                return (true);
            else
                return (false);
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            string userName = textBoxUser.Text;
            string password = textBoxPassword.Text;
          
            using (HutechNoteDbContext dbContext = new HutechNoteDbContext())
            {
                UserService userService = new UserService(dbContext);
                if (userService.login(userName, password))
                {
                    XtraMessageBox.Show("Login successful");
                    using FrmMain frmMain = new FrmMain(userName);
                    if (frmMain.ShowDialog() == DialogResult.OK)
                    {
                        ((Form)this.TopLevelControl).Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show("The user or password was wrong");
                }
            }
        }

        private void uc_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
