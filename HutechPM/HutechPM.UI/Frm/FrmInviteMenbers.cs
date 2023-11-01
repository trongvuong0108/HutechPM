using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Native;
using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.Entities;
using HutechPM.Data.UserData;
using HutechPM.UI.FRM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutechPM.UI.Frm
{
    public partial class FrmInviteMenbers : Form
    {
        public User getUserLogin { get; set; }
        public string getProjectName { get; set; }
        public List<User> getListEmloyess;
        List<User> listInviteUser = new List<User>();

        HutechNoteDbContext _dbContext;
        UserService userService;
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        List<User> users;
        List<Project> projects;
        List<Guid> listEmloyessId = new List<Guid>();
        public FrmInviteMenbers()
        {
            //InitializeComponent();

        }
        public FrmInviteMenbers(User userLogin, string ProjectName, List<User> listEmloyess)
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            userService = new UserService(_dbContext);
            projectService = new ProjectService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
            this.getUserLogin = userLogin;
            this.getProjectName = ProjectName;
            this.getListEmloyess = listEmloyess;
        }
        private async void FrmInviteMenbers_Load(object sender, EventArgs e)
        {
            foreach (User user in getListEmloyess) 
            {
                listEmloyessId.Add(user.userId);
                    
            }
            users = await userService.GetAllUsers();
            projects = await projectService.getAllProject();
            addListCheckboxInviteUser(users, getListEmloyess);
            

        }
        private void addListCheckboxInviteUser(List<User> users, List<User> getListEmloyess)
        {
            foreach (User user in users)
            {
                if (!listEmloyessId.Contains(user.userId))
                {
                    checkedListBoxInviteUser.Items.Add(user);
                }
            }

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
        private static readonly string _from = "workflowttp@gmail.com";
        private static readonly string _pass = "mytk qdlt eyfl xfby";
        /* private static readonly string _from = "trantrung28122003@gmail.com";
         private static readonly string _pass = "artc gpdp bcpi gvuq";*/
        public static string sendEmail(string sendto, string subject, string content)
        {
            FrmLoader frmLoader = new FrmLoader();
            
            try
            {
                frmLoader.Show();
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
                frmLoader.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                frmLoader.Close();
                return ex.ToString();
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
                        foreach (var projectInvite in projects)
                        {
                            if (projectInvite.projectName == getProjectName)
                            {
                                projectDetail.project = projectInvite;
                            }
                        }
                        ActionBaseResult result = await projectDetailService.AddProjectDetail(projectDetail);
                        if (result.Success)
                        {
                            string subject = "WorkFlow notifications";
                            string content =
                            "You have been invited to the " + getProjectName + " project by " + projectDetail.user.email;
                            sendEmail(user.email, subject, content);
                        }
                    }
                    this.Close();
                    XtraMessageBox.Show("Invite everyone to join the successfully " + getProjectName + " project");
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
      
    }
}
