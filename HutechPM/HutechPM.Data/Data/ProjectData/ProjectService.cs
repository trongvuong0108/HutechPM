using HutechNote.Data.Data.UserData.DTOs;
using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectData;
using HutechPM.Data.Data.ProjectData.DTO;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.Data.ProjectTaskData;
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
        private readonly ProjectRepository projectRepository;

        public ProjectService(HutechNoteDbContext _dbContext)
        {
            this.projectRepository = new ProjectRepository(_dbContext);
        }

        public async Task<List<Project>> getAllProject()
        {
            return await projectRepository.GetProject();
        }
        public async Task<Project> findProjectId(Guid projectId)
        {
            return await projectRepository.findProjectId(projectId);
        }
        public async Task<List<ProjectDTO>> getAllProjectsDTO()
        {
            List<ProjectDTO> ProjectDTOs = new List<ProjectDTO>();
            List<Project> projects = await projectRepository.GetProject();
            foreach (Project project in projects)
            {
                ProjectDTO projectDTO = new ProjectDTO();
                projectDTO.projectId = project.projectId;
                projectDTO.projectName = project.projectName;
                projectDTO.description = project.description;
                ProjectDetail findUserRole = await projectRepository.findProjectOfOwner(project);
                if (findUserRole != null)
                {
                    projectDTO.owner = findUserRole.user.userName;
                }
                projectDTO.dateStart = project.dateStart;
                projectDTO.dateEnd = project.dateEnd;
                int count = 0;
                foreach (ProjectTask projectTask in await projectRepository.GetProjectTask())
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

        public async Task<ActionBaseResult> AddProject(Project project)
        {
            return await projectRepository.AddProject(project);
        }
        public async Task<ActionBaseResult> UpdateProject(Project project)
        {
            return await projectRepository.UpdateProject(project);
        }
        public async Task<ActionBaseResult> DeleteProject(Project project)
        {
            return await projectRepository.DeleteProject(project);
        }
    }
}
