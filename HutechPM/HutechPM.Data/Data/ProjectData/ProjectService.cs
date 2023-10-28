using HutechNote.Data.Data.User.DTOs;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectData;
using HutechPM.Data.Data.ProjectData.DTO;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.Data.ProjectTaskData;
using HutechPM.Data.Data.User.DTOs;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechNote.Data.Data.ProjectData
{

    public class ProjectService
    {
        HutechNoteDbContext _dbContext = new HutechNoteDbContext();
        public ProjectRepository projectRepository;

        public ProjectService()
        {
            this.projectRepository = new ProjectRepository(_dbContext);
        }
        public List<Project> getAllProject()
        {
            return projectRepository.GetProject();
        }
        public List<ProjectDTO> getAllProjectsDTO()
        {
            List<ProjectDTO> ProjectDTOs = new List<ProjectDTO>();
            foreach (Project project in projectRepository.GetProject())
            {
                ProjectDTO projectDTO = new ProjectDTO();
                projectDTO.projectName = project.projectName;
                ProjectDetail findUserRole = projectRepository.findProjectOfOwner(project);
                if (findUserRole != null)
                {
                    projectDTO.owner = findUserRole.user.userName;
                }
                projectDTO.dateStart = project.dateStart;
                int count = 0;
                foreach (ProjectTask projectTask in projectRepository.GetProjectTask())
                {
                    if (projectTask.projectDetail.project.projectId == project.projectId)
                    {
                        count++;
                    }
                }
                projectDTO.quantityTask = count;
                projectDTO.isActive = project.isActive;
                ProjectDTOs.Add(projectDTO);
            }
            return ProjectDTOs;

        }
        public void AddProject(Project project)
        {
            projectRepository.AddProject(project);
        }

    }
}
