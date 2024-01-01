using DevExpress.Map.Kml.Model;
using DevExpress.Office;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HutechPM.UI.Frm
{
    public partial class FrmChangePassword : Form
    {
        User UserChangePassword { get; set; }
        HutechNoteDbContext _dbContext;
        UserService userService;

        public FrmChangePassword()
        {
            //InitializeComponent();

        }

        public FrmChangePassword(User userChangePassword)
        {
            InitializeComponent();
            this.UserChangePassword = userChangePassword;
            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowpassword.Checked)
            {
                textBoxNewPassword.UseSystemPasswordChar = false;
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxNewPassword.UseSystemPasswordChar = true;
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
            }
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private async void ChangePassword_Click(object sender, EventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
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
                FrmLoader frmLoader = new FrmLoader();
                frmLoader.Show();
                User finduserChangePassword = await userService.findUserByEmail(UserChangePassword.email);
                if (finduserChangePassword != null)
                {
                    finduserChangePassword.password = textBoxNewPassword.Text;
                    await userService.updateUser(finduserChangePassword);
                    XtraMessageBox.Show("Changed password successfully", "Notification");
                    this.Close();
                    frmLoader.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
