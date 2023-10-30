using HutechPM.Data.Common;
using HutechPM.Data.Entities;
using HutechPM.Data.UserData;
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
    public partial class uc_ChangePassword : UserControl
    {
        public User UserLogin { get; set; }
        HutechNoteDbContext _dbContext;
        UserService userService;
        public uc_ChangePassword()
        {
            InitializeComponent();
            userService = new UserService(_dbContext);
        }


        public void getUserLoginInUcChangePassword(User userlogin)
        {
            this.UserLogin = userlogin;
        }
        private void uc_ChangePassword_Load(object sender, EventArgs e)
        {

        }


        private void checkBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowpassword.Checked)
            {
                textBoxCurentPassword.UseSystemPasswordChar = false;
                textBoxCurentPassword.UseSystemPasswordChar = false;
                textBoxCurentPassword.UseSystemPasswordChar = false;
            }
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            //var userChangePassword = userService.getUser(UserLogin);
        }
    }
}
