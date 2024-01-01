using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using HutechNote.Data.Data.UserData.DTOs;
using HutechNote.Data.Migrations;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HutechPM.UI.Uc
{
    public partial class uc_Signup : UserControl
    {
        FrmLoader frmLoader;
        public uc_Signup()
        {
            InitializeComponent();
            frmLoader = new FrmLoader();
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
        public bool checkGender()
        {
            if (radioButtonMale.Checked)
            {
                return true;
            }
            else
            {
                return false;
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
        public void clearInformationTextBox()
        {
            textBoxUsername.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxConfirmPass.Text = string.Empty;
            textBoxFullname.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
        }
        private async void registerBtn_Click(object sender, EventArgs e)
        {
            frmLoader.Show();
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            var numberPhoneVietNam = new Regex(@"0[0-9]{9,10}");
            try
            {
                if (textBoxUsername.Text == "" || textBoxEmail.Text == "" || textBoxPassword.Text == "" || textBoxConfirmPass.Text == "" || textBoxFullname.Text == "" || textBoxPhone.Text == "" || textBoxAddress.Text == "")
                {
                    throw new Exception("Please! Enter complete information");
                }
                if (!hasNumber.IsMatch(textBoxPassword.Text))
                {
                    throw new Exception("Password must contain numeric characters");
                }
                if (!hasUpperChar.IsMatch(textBoxPassword.Text))
                {
                    throw new Exception("Password must contain capital letters");
                }
                if (!hasMinimum8Chars.IsMatch(textBoxPassword.Text))
                {
                    throw new Exception("Password must have at least 8 characters");
                }
                if (!hasSymbols.IsMatch(textBoxPassword.Text))
                {
                    throw new Exception("Password must contain special characters");
                }
                if (textBoxPassword.Text != textBoxConfirmPass.Text)
                {
                    throw new Exception("The confirmation password does not match the new password");
                }
                if (checkEmailAddress(textBoxEmail.Text) == false)
                {
                    throw new Exception("The email address entered is not valid");
                }
                if (!numberPhoneVietNam.IsMatch(textBoxPhone.Text))
                {
                    throw new Exception("Please enter a 10-digit phone number with a leading zero");
                }
                UserDTO userDTO = new UserDTO()
                {
                    userName = textBoxUsername.Text.Trim(),
                    password = textBoxPassword.Text.Trim(),
                    email = textBoxEmail.Text.Trim(),
                    phone = textBoxPhone.Text.Trim(),
                    fullName = textBoxFullname.Text.Trim(),
                    address = textBoxAddress.Text.Trim(),
                    gender = checkGender(),
                };
                using (HutechNoteDbContext dbContext = new HutechNoteDbContext())
                {
                    UserService userService = new UserService(dbContext);
                    ActionBaseResult result = await userService.CreateUser(userDTO);
                    frmLoader.Close();
                    if (result.Success)
                    {
                        clearInformationTextBox();
                        XtraMessageBox.Show("SignUp successful");
                    }
                    else
                    {
                        throw new Exception("Signup Fail! Exception: " + result.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }
        private void uc_Signup_Load(object sender, EventArgs e)
        {

        }
    }
}

