using DevExpress.XtraEditors;
using HutechPM.Data.Common;
using HutechPM.Data.Entities;
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

namespace HutechPM.UI.Uc
{
    public partial class uc_ChangePassword : UserControl
    {
        public User UserChangePassword { get; set; }
        HutechNoteDbContext _dbContext;
        UserService userService;
        public uc_ChangePassword()
        {
        }
        public void getUserLoginInUcChangePassword(User userlogin)
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
            this.UserChangePassword = userlogin;
        }
        private void uc_ChangePassword_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void ChangePassword_Click(object sender, EventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            FrmLoader frmLoader = new FrmLoader();
            try
            {
                if (!hasNumber.IsMatch(textBoxNewPassword.Text))
                {
                    throw new Exception("Password must contain numeric characters");
                }
                if (!hasUpperChar.IsMatch(textBoxNewPassword.Text))
                {
                    throw new Exception("Password must contain capital letters");
                }
                if (!hasMinimum8Chars.IsMatch(textBoxNewPassword.Text))
                {
                    throw new Exception("Password must have at least 8 characters");
                }
                if (!hasSymbols.IsMatch(textBoxNewPassword.Text))
                {
                    throw new Exception("Password must contain special characters");
                }
                if (textBoxNewPassword.Text != textBoxPasswordConfirm.Text)
                {
                    throw new Exception("The confirmation password does not match the new password");
                }
                frmLoader.Show();
                User finduserChangePassword = await userService.findUserByEmail(UserChangePassword.email);
                if (finduserChangePassword.password != textBoxCurentPassword.Text)
                {
                    throw new Exception("Password entered is incorrect");
                }
                if (finduserChangePassword != null)
                {

                    finduserChangePassword.password = textBoxNewPassword.Text;
                    await userService.updateUser(finduserChangePassword);
                    frmLoader.Close();
                    textBoxCurentPassword.Text = string.Empty;
                    textBoxNewPassword.Text = string.Empty;
                    textBoxPasswordConfirm.Text = string.Empty;
                    XtraMessageBox.Show("Changed password successfully", "Notification");
                }
            }
            catch (Exception ex)
            {
                frmLoader.Close();
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }

        private void checkBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowpassword.Checked)
            {
                textBoxCurentPassword.UseSystemPasswordChar = false;
                textBoxNewPassword.UseSystemPasswordChar = false;
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
            }
        }
    }
}
