using DevExpress.DataProcessing.InMemoryDataProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HutechPM.Data.Entities;
using DevExpress.XtraRichEdit.Fields;
using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.UserData;
using HutechPM.Data.Common;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using HutechNote.UI.Frm;

namespace HutechPM.UI.Frm
{
    public partial class FrmCreateProject : Form
    {
        HutechNoteDbContext _dbContext;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        UserService userService;
        public FrmCreateProject()
        {
            InitializeComponent();

        }
        public string UserName { set; get; }
        public FrmCreateProject(string userName)
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            projectService = new ProjectService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
            userService = new UserService(_dbContext);
            this.UserName = userName;
        }

        //SingleTon design pattern -> Dependency Injection
       
        private void FrmCreateProject_Load(object sender, EventArgs e)
        {
            MessageBox.Show(UserName);
        }

        private async void buttonContinue_Click(object sender, EventArgs e)
        {
            panelCreateProject2.BringToFront();
            panelCreateHide.BringToFront();

            Data.Entities.Project project = new Data.Entities.Project();
            project.projectId = Guid.NewGuid();
            project.projectName = textBoxProjectname.Text;
            
            project.description = textBoxDescription.Text;
            project.dateStart = DateTime.Now;
            project.isActive = true;

            projectService.AddProject(project);

            ProjectDetail projectDetail = new ProjectDetail();
            projectDetail.projectDetailId = Guid.NewGuid();
            projectDetail.project = project;

            Guid userIdLogin = Guid.NewGuid();
            using (HutechNoteDbContext _dbContext = new HutechNoteDbContext())
            {
                UserService userService = new UserService(_dbContext);
                var users = await userService.GetAllUsers();
                foreach (User user in users)
                {
                    if(user.userName == UserName)
                    {
                        userIdLogin = user.userId;
                    }
                }
                User userNeedFind = users.Where(user => user.userId.ToString().Equals(userIdLogin.ToString(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if (userNeedFind != null)
                {
                    projectDetail.user_id = userNeedFind.userId;
                }
                else
                {
                    XtraMessageBox.Show("Dell tạo dc condilon oi");
                }
            }

            projectDetail.timeJoin = DateTime.Now;
            projectDetail.timeLeft = DateTime.Now;
            projectDetail.projectRole = projectRole.ProjectManager;

            projectDetailService.AddProjectDetail(projectDetail);
        }
        private async void buttonInvite_Click(object sender, EventArgs e)
        {
            ProjectDetail projectDetail = new ProjectDetail();
            projectDetail.projectDetailId = new Guid();
            Guid guiduser = new Guid("d639a5b0-3946-45ee-bfa7-fc52deb8821a");
            //foreach(User user in listUSer())
            //{
            //    if(user.email == textBoxProjectMenbers.Text)
            //    {
            //        projectDetail.user.userId = user.userId;
            //    }
            //}
            projectDetail.user.userId = guiduser;


            projectDetail.timeJoin = DateTime.Now;
            projectDetail.timeLeft = DateTime.Now;
            projectDetail.projectRole = projectRole.ProjectMember;
            foreach (Data.Entities.Project project in await projectService.getAllProject())
            {
                if (project.projectName == textBoxProjectname.Text)
                {
                    projectDetail.project.projectId = project.projectId;
                }
            }
            projectDetailService.AddProjectDetail(projectDetail);

        }
        private void linkLabelLater_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelLater_MouseHover(object sender, EventArgs e)
        {

            linkLabelLater.LinkBehavior = LinkBehavior.NeverUnderline;
        }
        private void linkLabelLater_MouseLeave(object sender, EventArgs e)
        {
            linkLabelLater.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelCreateProject2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
