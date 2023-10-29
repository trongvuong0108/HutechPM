using HutechPM.Data.Common;
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
        public List<ProjectTask> getAllProjectTask()
        {
            return projectTaskRepository.GetProjectTask();
        }
        public void AddProjectTask(ProjectTask projectTask)
        {
            projectTaskRepository.AddProjectTask(projectTask);
            projectTaskRepository.SaveChanges();
        }
        public void upadteProjectTask(ProjectTask projectTask)
        {
            projectTaskRepository.upadteProjectTask(projectTask);
            projectTaskRepository.SaveChanges();
        }
        public ProjectTask findProjectTaskId(Guid projectTaskId)
        {
            return projectTaskRepository.findProjectTaskId(projectTaskId);
        }

    }
}
