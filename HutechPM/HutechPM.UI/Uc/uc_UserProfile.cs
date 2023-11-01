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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutechPM.UI.Uc
{
    public partial class uc_UserProfile : UserControl
    {
        public User UserLogin { get; set; }
        HutechNoteDbContext _dbContext;
        UserService userService;
        public uc_UserProfile()
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
        }
        public void getUserLoginInUcUserProfile(User userlogin)
        {
            this.UserLogin = userlogin;
        }
        private async void uc_UserProfile_Load(object sender, EventArgs e)
        {
            FrmLoader frmLoader = new FrmLoader();
            frmLoader.Show();
            BindingSource bindingSourceProject = new BindingSource();
            bindingSourceProject.DataSource = await userService.getUserProfile(UserLogin);
            frmLoader.Close(); 
            gridControlUserProfile.DataSource = bindingSourceProject;
        }
    }
}
