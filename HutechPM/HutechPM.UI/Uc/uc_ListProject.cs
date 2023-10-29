﻿using DevExpress.DataProcessing.InMemoryDataProcessor;
using HutechNote.Data.Data.ProjectData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HutechPM.Data.Entities;
using DevExpress.XtraGrid.Views.Grid;
using HutechPM.Data.Data.ProjectTaskData;
using Project = HutechPM.Data.Entities.Project;
using HutechPM.Data.Data.ProjectDetailData;
using DevExpress.XtraGrid;
using HutechPM.UI.Frm;
using DevExpress.Map.Native;
using DevExpress.Utils.MVVM;
using HutechPM.Data.Data.ProjectData.DTO;
using HutechPM.Data.Common;

namespace HutechPM.UI.Components
{
    public partial class uc_ListProject : UserControl
    {
        HutechNoteDbContext _dbContext;
        ProjectService projectService;
        ProjectTaskService projectTaskService;
        ProjectDetailService projectDetailService;
        List<Project> ListProject;
        List<ProjectTask> ListProjectTask;
        List<ProjectDTO> listProjectDTO;
        public uc_ListProject()
        {
            InitializeComponent();
            _dbContext = new HutechNoteDbContext();
            projectService = new ProjectService(_dbContext);
            projectTaskService = new ProjectTaskService(_dbContext);
            projectDetailService = new ProjectDetailService(_dbContext);

        }

        public string UserName { get; set; }

        public void getUserLoginInUcListProject(string userName)
        {
            this.UserName = userName;
        }

        private void uc_ListProject_Load(object sender, EventArgs e)
        {
            //test
            MessageBox.Show(UserName);

            ListProject = projectService.getAllProject();
            ListProjectTask = projectTaskService.getAllProjectTask();
            listProjectDTO = projectService.getAllProjectsDTO();
            BindingSource bindingSourceProject = new BindingSource();
            bindingSourceProject.DataSource = listProjectDTO;
            gridControlProjects.DataSource = bindingSourceProject;
            ItemButtonUpdate.Click += ItemButtonUpdate_Click;
            ItemButtonDelete.Click += ItemButtonDelete_Click;
        }
        private void ItemButtonUpdate_Click(object sender, EventArgs e)
        {
            string projectName = gridViewProjects.GetFocusedRowCellValue("projectName").ToString();
            string description;
            if (gridViewProjects.GetFocusedRowCellValue("description") == null)
            {
                description = null;
            }
            else
            {
                description = gridViewProjects.GetFocusedRowCellValue("description").ToString();
            }
            string owner = gridViewProjects.GetFocusedRowCellValue("owner").ToString();
            string dateStart = gridViewProjects.GetFocusedRowCellValue("dateStart").ToString();
            //string dateEnd = gridViewProjects.GetFocusedRowCellValue("dateEnd").ToString();
            bool isActive = true;
            foreach (ProjectDTO projectDTO in listProjectDTO)
            {
                if (projectDTO.projectName == projectName)
                {
                    isActive = projectDTO.isActive;
                }
            }

            //string isActive = gridViewProjects.GetFocusedRowCellValue("isAcive").ToString();
            using (FrmProject frmProject = new FrmProject(projectName, description, owner, dateStart, isActive))
            {
                if (frmProject.ShowDialog() == DialogResult.OK)
                {
                    // frmProject.projectName = projectName;
                }
            }
        }
        private void ItemButtonDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        private void GridViewProjects_InitNewRow(object sender, InitNewRowEventArgs e)
        {

            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["Owner"], "trung");
            view.SetRowCellValue(e.RowHandle, view.Columns["Ownler"], "4");
            view.SetRowCellValue(e.RowHandle, view.Columns[3], "5");
        }

        private void gridViewProjects_InitNewRow(object sender, InitNewRowEventArgs e)
        {

        }






        private void button1_Click(object sender, EventArgs e)
        {
            gridViewProjects.AddNewRow();
            gridViewProjects.SetRowCellValue(1, "projectName", "111");
            gridViewProjects.SetRowCellValue(1, "owner", "2");
            gridViewProjects.SetRowCellValue(1, "dateStart", DateTime.Now);
            gridViewProjects.SetRowCellValue(1, "tasks", "5");
        }

        private void gridControlProjects_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            using (FrmCreateProject frmCreateProject = new FrmCreateProject(UserName))
            {
                if (frmCreateProject.ShowDialog() == DialogResult.OK)
                {

                }
            }

        }
    }
}
