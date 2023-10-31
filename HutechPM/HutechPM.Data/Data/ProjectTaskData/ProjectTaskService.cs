using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectAttachmentData;
using HutechPM.Data.Data.ProjectData;
using HutechPM.Data.Data.ProjectDetailData;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.ProjectTaskData
{
    public class ProjectTaskService
    {
        private readonly ProjectTaskRepository projectTaskRepository;
     
        public ProjectTaskService(HutechNoteDbContext _dbContext)
        {
            this.projectTaskRepository = new ProjectTaskRepository(_dbContext);
        }

        public async Task<List<ProjectTask>> getAllProjectTask()
        {
            return await projectTaskRepository.GetProjectTask();
        }

        public async Task<ActionBaseResult> AddProjectTask(ProjectTask projectTask)
        {
            return await projectTaskRepository.AddProjectTask(projectTask);
        }

        public async Task<ActionBaseResult> upadteProjectTask(ProjectTask projectTask)
        {
            return await projectTaskRepository.upadteProjectTask(projectTask);
        }
        public async Task<ActionBaseResult> DeleteProjectTask(ProjectTask projectTask)
        {
            return await projectTaskRepository.DeleteProjectTask(projectTask);
        }
        public async Task<ProjectTask> findProjectTaskId(Guid projectTaskId)
        {
            return await projectTaskRepository.findProjectTaskId(projectTaskId);
        }

    }
}
