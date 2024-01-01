using HutechPM.Data.ProjectData.DTO;
using HutechPM.Domain.Entities;
using HutechPM.Infrastructure.Common;
using HutechPM.Infrastructure.ProjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Application.Data.ProjectData
{
    public interface IProjectService
    {
        public Task<List<Project>> getAllProject();
        public Task<Project> findProjectId(Guid projectId);
        public Task<List<ProjectDTO>> getAllProjectsDTO();
        public Task<ActionBaseResult> AddProject(Project project);
        public Task<ActionBaseResult> UpdateProject(Project project);
        public Task<ActionBaseResult> DeleteProject(Project project);
    }
}
