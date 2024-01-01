using DevExpress.XtraGrid.Views.Grid;
using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectData.DTO;
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

namespace HutechPM.UI.Components
{
    public partial class uc_Home : UserControl
    {
        HutechNoteDbContext _dbContext;
        ProjectService projectService;
        ProjectTaskService projectTaskService;
        List<Project> listProject;
        List<ProjectTask> listProjectTasks;
        List<ProjectDTO> listProjectDTO;
        public uc_Home()
        {
            InitializeComponent();
        }

        private async void uc_Home_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
