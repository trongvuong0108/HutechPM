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
using HutechPM.Data.Entities;
namespace HutechPM.UI.Frm
{
    public partial class FrmCreateProject : Form
    {
        public User UserNameLogin { set; get; }
        List<User> listInviteUser = new List<User>();

        HutechNoteDbContext _dbContext;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        UserService userService;

        public FrmCreateProject()
        {
            //InitializeComponent();
        }
        public FrmCreateProject(User userNameLogin)
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            projectService = new ProjectService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
            userService = new UserService(_dbContext);
            this.UserNameLogin = userNameLogin;
        }

        //SingleTon design pattern -> Dependency Injection

        private async void FrmCreateProject_Load(object sender, EventArgs e)
        {
            MessageBox.Show(UserNameLogin.userName);
            addListCheckboxInviteUser(await userService.GetAllUsers());
        }

        private void addListCheckboxInviteUser(List<User> users)
        {
            foreach (User user in users)
            {
                checkedListBoxInviteUser.Items.Add(user);
            }
        }
        public Data.Entities.Project createProject;
        private async void buttonContinue_Click(object sender, EventArgs e)
        {
            panelCreateProject2.BringToFront();
         
            Data.Entities.Project project = new Data.Entities.Project();
            project.projectId = Guid.NewGuid();
            project.projectName = textBoxProjectname.Text;

            project.description = textBoxDescription.Text;
            project.dateStart = DateTime.Now;
            project.isActive = true;

            await projectService.AddProject(project);

            createProject = project;
            ProjectDetail projectDetail = new ProjectDetail();
            projectDetail.projectDetailId = Guid.NewGuid();
            projectDetail.project = project;

            /*Guid userIdLogin = UserNameLogin();
            using (HutechNoteDbContext _dbContext = new HutechNoteDbContext())
            {
                UserService userService = new UserService(_dbContext);
                var users = await userService.GetAllUsers();
                foreach (User user in users)
                {
                    if (user == UserName)
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
            }*/

            projectDetail.user_id = UserNameLogin.userId;
            projectDetail.timeJoin = DateTime.Now;
            projectDetail.timeLeft = DateTime.Now;
            projectDetail.projectRole = projectRole.ProjectManager;
            await projectDetailService.AddProjectDetail(projectDetail);
        }

        private void checkedListBoxInviteUser_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                User skill = checkedListBoxInviteUser.Items[e.Index] as User;
                listInviteUser.Add(skill);
            }
            else
            {
                User skill = checkedListBoxInviteUser.Items[e.Index] as User;
                listInviteUser.Remove(skill);
            }
        }
        private async void buttonInvite_Click(object sender, EventArgs e)
        {
            if (listInviteUser != null)
            {
                foreach (User user in listInviteUser)
                {
                    ProjectDetail projectDetail = new ProjectDetail();
                    projectDetail.projectDetailId = Guid.NewGuid();
                    projectDetail.user_id = user.userId;
                    projectDetail.timeJoin = DateTime.Now;
                    projectDetail.timeLeft = DateTime.Now;
                    projectDetail.projectRole = projectRole.ProjectMember;
                    projectDetail.project = createProject;
                    await projectDetailService.AddProjectDetail(projectDetail);
                    
                }
                XtraMessageBox.Show("moi thanh cong");

            }
            else
            {
                XtraMessageBox.Show("Chuaw chon user");
            }


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
