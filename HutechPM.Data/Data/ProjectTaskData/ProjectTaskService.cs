using HutechPM.Domain.Entities;
using HutechPM.Infrastructure.Common;
using HutechPM.Infrastructure.ProjectTaskData;

namespace HutechPM.Data.Data.ProjectTaskData
{
    public class ProjectTaskService
    {
        private readonly ProjectTaskRepository _projectTaskRepository;
     
        public ProjectTaskService(ProjectTaskRepository projectTaskRepository)
        {
            this._projectTaskRepository = projectTaskRepository;
        }

        public async Task<List<ProjectTask>> getAllProjectTask()
        {
            return await _projectTaskRepository.GetProjectTask();
        }

        public async Task<ActionBaseResult> AddProjectTask(ProjectTask projectTask)
        {
            return await _projectTaskRepository.AddProjectTask(projectTask);
        }

        public async Task<ActionBaseResult> upadteProjectTask(ProjectTask projectTask)
        {
            return await _projectTaskRepository.upadteProjectTask(projectTask);
        }
        public async Task<ActionBaseResult> DeleteProjectTask(ProjectTask projectTask)
        {
            return await _projectTaskRepository.DeleteProjectTask(projectTask);
        }
        public async Task<ProjectTask> findProjectTaskId(Guid projectTaskId)
        {
            return await _projectTaskRepository.findProjectTaskId(projectTaskId);
        }

    }
}
