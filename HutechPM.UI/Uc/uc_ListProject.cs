using DevExpress.DataProcessing.InMemoryDataProcessor;
using HutechNote.Data.Data.ProjectData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HutechPM.Data.Entities;
using HutechPM.Data.Data.ProjectTaskData;
using Project = HutechPM.Data.Entities.Project;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.UI.Frm;
using DevExpress.Map.Native;
using DevExpress.Utils.MVVM;
using HutechPM.Data.Data.ProjectData.DTO;
using HutechPM.Data.Common;
using DevExpress.XtraEditors;
using System.Linq;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraGrid.Views.Base;
using HutechPM.Data.UserData;
using System.Threading.Tasks;
using DevExpress.CodeParser;
using HutechPM.UI.FRM;

namespace HutechPM.UI.Components
{
    public partial class uc_ListProject : UserControl
    {
        public User UserNameLogin { get; set; }
        public string getProjectId { get; set; }
        public string getProjectName { get; set; }
        public string getDescription { get; set; }
        string getOwner { get; set; }
        string getDateStart { get; set; }
        string getDateEnd { get; set; }
        bool getisActive { get; set; }

        HutechNoteDbContext _dbContext;
        ProjectService projectService;
        ProjectTaskService projectTaskService;
        ProjectDetailService projectDetailService;
        UserService userService;
        List<Project> ListProject;
        List<ProjectTask> ListProjectTask;
        List<ProjectDTO> listProjectDTO;
        private uc_ListProject uc_ListProject1;

        public uc_ListProject()
        {

        }
        public async void getUserLoginInUcListProject(User userNameLogin)
        {
            InitializeComponent();
            this.UserNameLogin = userNameLogin;
        }
        public async void loadData()
        {
            FrmLoader frmLoader = new FrmLoader();
            frmLoader.Show();
            _dbContext = new HutechNoteDbContext();
            projectService = new ProjectService(_dbContext);
            projectTaskService = new ProjectTaskService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);
            userService = new UserService(_dbContext);
            ListProject = await projectService.getAllProject();
            ListProjectTask = await projectTaskService.getAllProjectTask();
            listProjectDTO = await projectService.getAllProjectsDTO();
            BindingSource bindingSourceProject = new BindingSource();
            bindingSourceProject.DataSource = listProjectDTO;
            gridControlProjects.DataSource = bindingSourceProject;
            frmLoader.Close();
        }

        private async void uc_ListProject_Load(object sender, EventArgs e)
        {
            loadData();
            ItemButtonUpdate.ButtonClick += ItemButtonUpdate_Click;
            ItemButtonDelete.ButtonClick += ItemButtonDelete_Click;
        }

        private void ItemButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                getProjectId = gridViewProjects.GetFocusedRowCellValue("projectId").ToString();
                getProjectName = gridViewProjects.GetFocusedRowCellValue("projectName").ToString();
                getDescription = gridViewProjects.GetFocusedRowCellValue("description").ToString();
                getOwner = gridViewProjects.GetFocusedRowCellValue("owner").ToString();
                getDateStart = gridViewProjects.GetFocusedRowCellValue("dateStart").ToString();
                getDateEnd = gridViewProjects.GetFocusedRowCellValue("dateEnd").ToString();
                getisActive = true;
                foreach (ProjectDTO projectDTO in listProjectDTO)
                {
                    if (projectDTO.projectName == getProjectName)
                    {
                        getisActive = projectDTO.isActive;
                    }
                }
                using (FrmProject frmProject = new FrmProject(getProjectId, getProjectName, getDescription, getOwner, getDateStart, getDateEnd, getisActive, UserNameLogin))
                {
                    frmProject.ShowDialog();
                    loadData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private async void ItemButtonDelete_Click(object sender, EventArgs e)
        {
            getProjectId = gridViewProjects.GetFocusedRowCellValue("projectId").ToString();
            Guid guidGetProject = new Guid(getProjectId);
            getProjectName = gridViewProjects.GetFocusedRowCellValue("projectName").ToString();
            if (XtraMessageBox.Show($"Do you want to delete project '" + getProjectName + "'", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewProjects.DeleteSelectedRows();
                FrmLoader frmLoader = new FrmLoader();
                frmLoader.Show();
                Project deleteproject = await projectService.findProjectId(guidGetProject);
                foreach (ProjectDetail deleteProjectDetail in await projectDetailService.getAllProjectDetail())
                {
                    if (deleteproject.projectId == deleteProjectDetail.project.projectId)
                    {
                        await projectDetailService.DeleteProjectDetail(deleteProjectDetail);
                    }
                }
                ActionBaseResult result = await projectService.DeleteProject(deleteproject);
                if (result.Success)
                {
                    XtraMessageBox.Show("Successfully deleted the selected project", "Notification");
                    loadData();
                    frmLoader.Close();
                }
            }
        }
        private void gridViewProjects_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                getProjectId = gridViewProjects.GetFocusedRowCellValue("projectId").ToString();
                getProjectName = gridViewProjects.GetFocusedRowCellValue("projectName").ToString();
                getDescription = gridViewProjects.GetFocusedRowCellValue("description").ToString();
                getOwner = gridViewProjects.GetFocusedRowCellValue("owner").ToString();
                getDateStart = gridViewProjects.GetFocusedRowCellValue("dateStart").ToString();
                getDateEnd = gridViewProjects.GetFocusedRowCellValue("dateEnd").ToString();
                getisActive = true;
                foreach (ProjectDTO projectDTO in listProjectDTO)
                {
                    if (projectDTO.projectName == getProjectName)
                    {
                        getisActive = projectDTO.isActive;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {

                using (FrmCreateProject frmCreateProject = new FrmCreateProject(UserNameLogin))
                {
                    frmCreateProject.ShowDialog();
                    uc_ListProject_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                uc_ListProject_Load(sender, e);
                List<int> row = gridViewProjects.GetSelectedRows().Where(c => c >= 0).ToList();
                if (row.Count > 1)
                {
                    throw new Exception("Cannot update multiple lines at once");
                }
                using (FrmProject frmProject = new FrmProject(getProjectId, getProjectName, getDescription, getOwner, getDateStart, getDateEnd, getisActive, UserNameLogin))
                {
                    frmProject.ShowDialog();
                    loadData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private async void buttonSelectDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> row = gridViewProjects.GetSelectedRows().Where(c => c >= 0).ToList();
                foreach (var item in row)
                {
                    getProjectId = gridViewProjects.GetRowCellValue(item, "projectId").ToString();
                    Guid guidGetProject = new Guid(getProjectId);
                    getProjectName = gridViewProjects.GetRowCellValue(item, "projectName").ToString();
                    if (XtraMessageBox.Show($"Do you want to delete project '" + getProjectName + "'", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmLoader frmLoader = new FrmLoader();
                        frmLoader.Show();
                        Project deleteproject = await projectService.findProjectId(guidGetProject);

                        foreach (ProjectDetail deleteProjectDetail in await projectDetailService.getAllProjectDetail())
                        {
                            if (deleteproject.projectId == deleteProjectDetail.project.projectId)
                            {
                                await projectDetailService.DeleteProjectDetail(deleteProjectDetail);
                            }
                        }
                        ActionBaseResult result = await projectService.DeleteProject(deleteproject);
                        if (result.Success)
                        {
                            frmLoader.Close();
                            XtraMessageBox.Show("Successfully deleted the selected project", "Notification");

                        }
                    }
                }
                foreach (var item in row)
                {
                    gridViewProjects.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }
    }
}

