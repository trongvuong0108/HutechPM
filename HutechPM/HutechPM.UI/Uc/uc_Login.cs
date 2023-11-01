using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
using DevExpress.XtraScheduler;
using HutechNote.UI.Frm;
using HutechPM.Data.Common;
using HutechPM.Data.Entities;
using HutechPM.Data.UserData;
using HutechPM.UI.Common;
using HutechPM.UI.Frm;
using HutechPM.UI.FRM;
using System;
using System.Drawing;
using System.Net.Mail;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HutechPM.UI.Uc
{
    public partial class uc_Login : UserControl
    {
        User userChangePassword { get; set; }
        string formattedNumber { get; set; }

        private static readonly string _from = "workflowttp@gmail.com";

        private static readonly string _pass = "mytk qdlt eyfl xfby";

        /* private static readonly string _from = "trantrung28122003@gmail.com";
         private static readonly string _pass = "artc gpdp bcpi gvuq";*/

        uc_ForgetPassword uc_ForgetPassword;
        HutechNoteDbContext _dbContext;
        UserService userService;

        public uc_Login()
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
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

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text == "" && textBoxUser.Text == "")
                {
                    throw new Exception("Please! Enter complete information");
                }
                if (textBoxUser.Text == "")
                {
                    throw new Exception("Please! Enter user name");

                }
                if (textBoxPassword.Text == "")
                {
                    throw new Exception("Please! Enter password");
                }

                string userName = textBoxUser.Text;
                string password = textBoxPassword.Text;
                FrmLoader frmLoader = new FrmLoader();
                frmLoader.Show();
                User currentUser = await userService.getUser(userName, password);
                frmLoader.Close();
                if (currentUser != null)
                {
                    ((Form)this.ParentForm).Hide();
                    using FrmMain frmMain = new FrmMain(currentUser);
                    frmMain.ShowDialog();
                    ((Form)this.ParentForm).Close();
                }
                else
                {
                    XtraMessageBox.Show("Please check your user name and password! and try again", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }

        private void uc_Login_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = "admin";
            textBoxPassword.Text = "Password@1234";
            textBoxSendCode.Enabled = false;
        }

        public static string sendEmail(string sendto, string subject, string content)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                mail.Priority = MailPriority.High;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
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

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxSendCode.Enabled = true;

                if (checkEmailAddress(textBoxEmailSend.Text) == false)
                {
                    throw new Exception("The email address entered is not valid");
                }
                if (textBoxEmailSend.Text == "")
                {
                    throw new Exception("Please! Enter email address");
                }
                FrmLoader frmLoader = new FrmLoader();
                frmLoader.Show();
                User user = await userService.findUserByEmail(textBoxEmailSend.Text);
                if (user != null)
                {
                    Random random = new Random();
                    // Define the range for your random numbers
                    int minValue = 1; // Minimum value (000001)
                    int maxValue = 999999; // Maximum value (999999)
                                           // Generate and print a random number
                    int randomNumber = random.Next(minValue, maxValue + 1); // +1 to include the maxValue
                                                                            // Format the number as a string with leading zeros
                    formattedNumber = randomNumber.ToString("D6");
                    userChangePassword = user;
                    string subject = "WorkFolw Support  - Account Recovery";
                    string content =
                    "<br />Hello " + user.userName +
                    "<br />Please get the code information to recover your WorkFlow login:: " + formattedNumber;
                    sendEmail(user.email, subject, content);
                    frmLoader.Close();
                }
                else
                {
                    throw new Exception("The email address is not registered in the WorkFlow system");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSendCode.Text == "")
                {
                    throw new Exception("Please! Enter the code");
                }
                if (textBoxSendCode.Text == formattedNumber)
                {
                    using FrmChangePassword frmChangePassword = new FrmChangePassword(userChangePassword);
                    frmChangePassword.ShowDialog();
                    panelLogin.BringToFront();
                }
                else
                {
                    throw new Exception("The code you just entered is incorrect! Please re-enter");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }
        private void labelForget_Click(object sender, EventArgs e)
        {
            panelSendCode.BringToFront();
        }

        private void labelBackLogin_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void pictureBoxShowPass_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxHidePass.BringToFront();
        }
        private void pictureBoxHidePass_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShowPass.BringToFront();
        }
    }
}
