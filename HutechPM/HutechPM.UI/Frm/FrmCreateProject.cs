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
using System.Net.Mail;
using DevExpress.XtraRichEdit.Model;
using static DevExpress.CodeParser.CodeStyle.Formatting.Rules.LineBreaks;
using System.Windows.Documents;
using HutechPM.UI.FRM;

namespace HutechPM.UI.Frm
{
    public partial class FrmCreateProject : Form
    {
        public User UserLogin { set; get; }

        List<User> listInviteUser = new List<User>();

        HutechNoteDbContext _dbContext;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        UserService userService;

        public FrmCreateProject()
        {
            //InitializeComponent();
        }
        public FrmCreateProject(User userLogin)
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            projectService = new ProjectService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
            userService = new UserService(_dbContext);
            this.UserLogin = userLogin;
        }
        private static readonly string _from = "workflowttp@gmail.com";
        private static readonly string _pass = "mytk qdlt eyfl xfby";
        /* private static readonly string _from = "trantrung28122003@gmail.com";
         private static readonly string _pass = "artc gpdp bcpi gvuq";*/
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

        //SingleTon design pattern -> Dependency Injection

        private async void FrmCreateProject_Load(object sender, EventArgs e)
        {
            FrmLoader frmLoader = new FrmLoader();
            frmLoader.Show();
            addListCheckboxInviteUser(await userService.GetAllUsers());
            frmLoader.Close();
        }

        private void addListCheckboxInviteUser(List<User> users)
        {

            foreach (User user in users)
            {
                if (user.userId != UserLogin.userId)
                {
                    checkedListBoxInviteUser.Items.Add(user);
                }
            }
        }
        public Data.Entities.Project createProject;
        private async void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxProjectname.Text == "" && textBoxDescription.Text == "")
                {
                    throw new Exception("Please! Enter complete information");
                }
                if (textBoxProjectname.Text == "")
                {
                    throw new Exception("Please! Enter project name");
                }
                foreach (Data.Entities.Project checkproject in await projectService.getAllProject())
                {
                    if (checkproject.projectName == textBoxProjectname.Text)
                    {
                        throw new Exception("This project name already exists in the system");
                    }
                }
                if (textBoxDescription.Text == "")
                {
                    throw new Exception("Please! Enter project Description");
                }

                Data.Entities.Project project = new Data.Entities.Project();
                project.projectId = Guid.NewGuid();
                project.projectName = textBoxProjectname.Text;
                project.description = textBoxDescription.Text;
                project.dateStart = DateTime.Now;
                project.dateEnd = DateTime.Now;
                project.isActive = true;
                FrmLoader frmLoader = new FrmLoader();
                frmLoader.Show();
                await projectService.AddProject(project);

                createProject = project;
                ProjectDetail projectDetail = new ProjectDetail();
                projectDetail.projectDetailId = Guid.NewGuid();
                projectDetail.project = project;
                projectDetail.user_id = UserLogin.userId;
                projectDetail.timeJoin = DateTime.Now;
                projectDetail.timeLeft = DateTime.Now;
                projectDetail.projectRole = projectRole.ProjectManager;
                ActionBaseResult result = await projectDetailService.AddProjectDetail(projectDetail);
                if (result.Success)
                {
                    panelCreateProject2.BringToFront();
                    frmLoader.Close();
                    MessageBox.Show("Create successful projects");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }

            /*Guid userIdLogin = UserNameLogin();
            using (HutechNoteDbContext _dbContext = new HutechNoteDbContext())
            {
                UserService userService = new UserService(_dbContext);
                var users = await userService.GetAllUsers();
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
        }

        private void checkedListBoxInviteUser_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                User user = checkedListBoxInviteUser.Items[e.Index] as User;
                listInviteUser.Add(user);
            }
            else
            {
                User user = checkedListBoxInviteUser.Items[e.Index] as User;
                listInviteUser.Remove(user);
            }
        }

        private async void buttonInvite_Click(object sender, EventArgs e)
        {
            try
            {
                if (listInviteUser.Count != 0)
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
                        FrmLoader frmLoader = new FrmLoader();
                        frmLoader.Show();
                        ActionBaseResult result = await projectDetailService.AddProjectDetail(projectDetail);
                        if (result.Success)
                        {
                            string subject = "WorkFlow notifications";
                            string content =
                            "You have been invited to the " + createProject.projectName + " project by " + projectDetail.user.email;
                            sendEmail(user.email, subject, content);
                            frmLoader.Show();
                        }
                    }
                    this.Close();
                    XtraMessageBox.Show("Invite everyone to join the successfully " + createProject.projectName + " project");
                }
                else
                {
                    throw new Exception("Members have not been selected to invite to join the project");
                }
                listInviteUser.Clear();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }
        private void linkLabelLater_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void linkLabelLater_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
