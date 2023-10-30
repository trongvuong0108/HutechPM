using DevExpress.XtraRichEdit.Fields;
using HutechNote.Data.Data.ProjectData;
using HutechNote.Data.Data.UserData.DTOs;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectDetailData;
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
    public partial class uc_ListEmployess : UserControl
    {
        HutechNoteDbContext _dbContext;
        UserService userService;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        public uc_ListEmployess()
        {
            InitializeComponent();

            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
            projectService = new ProjectService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
        }
        public User UserLogin { get; set; }

        public void getUserLoginInUcListEmployess(User userlogin)
        {
            this.UserLogin = userlogin;
        }

        List<User> Employess = new List<User>();
        List<ProjectDetail> EmployessProjectDetail = new List<ProjectDetail>();
        List<ProjectDetail> projectDetailOfUserLogin;
        List<ProjectDetail> projectDetails;
        List<User> users;
        private async void uc_ListEmployess_Load(object sender, EventArgs e)
        {
            projectDetailOfUserLogin = await projectDetailService.getAllProjectDetailByUser(UserLogin);
            projectDetails = await projectDetailService.getAllProjectDetail();
            users = await userService.GetAllUsers();
            GetEmployessProjectDetail();
            getListEmployess();
            BindingSource bindingSourceProject = new BindingSource();
            bindingSourceProject.DataSource = await userService.getListUserDTO(Employess);
            gridControlEmployess.DataSource = bindingSourceProject;
        }
        private void GetEmployessProjectDetail()
        {
            foreach (ProjectDetail projectDetailOfUserLogin in projectDetailOfUserLogin)
            {
                foreach (ProjectDetail projectDetail in projectDetails)
                {
                    if (projectDetail.project == projectDetailOfUserLogin.project)
                    {
                        EmployessProjectDetail.Add(projectDetail);
                    }
                }
            }
        }

        private void getListEmployess()
        {

            foreach (ProjectDetail employessProjectDetail in EmployessProjectDetail)
            {
                foreach (User user in users)
                {
                    if (user.userId == employessProjectDetail.user_id)
                    {

                        Employess.Add(user);
                    }
                }
            }

            /*for (int i = 0; i < Employess.Count - 1; i++)
            {
                User employDuplicate = Employess[i];
                for (int j = i + 1; j < Employess.Count; j++)
                {
                    if (Employess[j] == employDuplicate)
                    {
                        Employess.Remove(employDuplicate);
                    }
                }
            }*/
        }
    }
}
