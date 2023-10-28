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

namespace HutechPM.UI.Frm
{
    public partial class FrmCreateProject : Form
    {
        public FrmCreateProject()
        {
            InitializeComponent();
        }
        ProjectService projectService;
        ProjectDetailService projectDetailService;
        private void FrmCreateProject_Load(object sender, EventArgs e)
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            panelCreateProject2.BringToFront();
            panelCreateHide.BringToFront();

            Data.Entities.Project project = new Data.Entities.Project();
            project.projectId = new Guid();
            project.projectName = textBoxProjectname.Text;
            project.description = textBoxDescription.Text;
            project.dateStart = DateTime.Now;
            project.isActive = true;


            ProjectDetail projectDetail = new ProjectDetail();
            projectDetail.projectDetailId = new Guid();
            Guid guiduser = new Guid("97aa4a7d-88c2-4c52-87cc-1a3db1f124a0");
           /* foreach
            projectDetail.user.userId = guiduser;*/

            projectDetail.timeJoin = DateTime.Now;
            projectDetail.timeLeft = DateTime.Now;
            projectDetail.projectRole = projectRole.ProjectMember;
            projectDetail.project.projectId = project.projectId;

            projectService.AddProject(project);
            projectDetailService.AddProjectDetail(projectDetail);

        }

        private void buttonInvite_Click(object sender, EventArgs e)
        {
            ProjectDetail projectDetail = new ProjectDetail();
            projectDetail.projectDetailId = new Guid();
            //foreach(User user in listUSer())
            //{
            //    if(user.email == textBoxProjectMenbers.Text)
            //    {
            //        projectDetail.user.userId = user.userId;
            //    }
            //}
            Guid guiduser = new Guid("97aa4a7d - 88c2 - 4c52 - 87cc - 1a3db1f124a0");
            projectDetail.user.userId = guiduser;


            projectDetail.timeJoin = DateTime.Now;
            projectDetail.timeLeft = DateTime.Now;
            projectDetail.projectRole = projectRole.ProjectMember;
            foreach(Data.Entities.Project project in projectService.getAllProject())
            {
                if(project.projectName == textBoxProjectname.Text)
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
