using DevExpress.XtraGrid.Views.Grid;
using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Data.ProjectTaskData;
using HutechPM.Data.Entities;
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
    public partial class uc_ListTask : UserControl
    {
        public uc_ListTask()
        {
            InitializeComponent();
        }
        ProjectService projectService = new ProjectService();
        ProjectTaskService projectTaskService = new ProjectTaskService();
        List<Project> listProject;
        List<ProjectTask> listProjectTask;
        private void uc_ListTask_Load(object sender, EventArgs e)
        {
            listProject = projectService.getAllProject();
            listProjectTask = projectTaskService.getAllProjectTask();
            gridControlListProject.DataSource = listProject;
        }

        private void gridViewProject_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;
            Project project = view.GetRow(e.RowHandle) as Project;
            if (project != null)
            {
                e.IsEmpty = !listProjectTask.Any(p => p.projectDetail.project.projectId == project.projectId);
            }
        }

        private void gridViewProject_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            Project project = view.GetRow(e.RowHandle) as Project;
            if (project != null)
            {
                e.ChildList = listProjectTask.Where(p => p.projectDetail.project.projectId == project.projectId).ToList();
            }
        }

        private void gridViewProject_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridViewProject_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Task";
        }

        private void gridControlListProject_Click(object sender, EventArgs e)
        {

        }
    }

}
