using HutechPM.Data.Data.ProjectData.DTO;
using HutechPM.Domain.Entities;
using HutechPM.Infrastructure.Common;
using HutechPM.Infrastructure.ProjectData;

namespace HutechNote.Data.Data.ProjectData
{

    public class ProjectService
    {
        private readonly ProjectRepository _projectRepository;

        public ProjectService(HutechNoteDbContext _dbContext)
        {
            this._projectRepository = new ProjectRepository(_dbContext);
        }

        public async Task<List<Project>> getAllProject()
        {
            return await _projectRepository.GetProject();
        }
        public async Task<Project> findProjectId(Guid projectId)
        {
            return await _projectRepository.findProjectId(projectId);
        }
        public async Task<List<ProjectDTO>> getAllProjectsDTO()
        {
            List<ProjectDTO> ProjectDTOs = new List<ProjectDTO>();
            List<Project> projects = await _projectRepository.GetProject();
            foreach (Project project in projects)
            {
                ProjectDTO projectDTO = new ProjectDTO();
                projectDTO.projectId = project.projectId;
                projectDTO.projectName = project.projectName;
                projectDTO.description = project.description;
                ProjectDetail findUserRole = await _projectRepository.findProjectOfOwner(project);
                if (findUserRole != null)
                {
                    projectDTO.owner = findUserRole.user.userName;
                }
                projectDTO.dateStart = project.dateStart;
                projectDTO.dateEnd = project.dateEnd;
                int count = 0;
                foreach (ProjectTask projectTask in await _projectRepository.GetProjectTask())
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
            return await _projectRepository.AddProject(project);
        }
        public async Task<ActionBaseResult> UpdateProject(Project project)
        {
            return await _projectRepository.UpdateProject(project);
        }
        public async Task<ActionBaseResult> DeleteProject(Project project)
        {
            return await _projectRepository.DeleteProject(project);
        }
    }
}
