using HutechPM.Data.Common;
using HutechPM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.ProjectTaskData
{
    public class ProjectTaskService
    {
        HutechNoteDbContext _dbContext = new HutechNoteDbContext();
        public ProjectTaskRepository projectTaskRepository;
        public ProjectTaskService()
        {
            this.projectTaskRepository = new ProjectTaskRepository(_dbContext);
        }
        public List<ProjectTask> getAllProjectTask()
        {
            return projectTaskRepository.GetProjectTask();
        }
    }
}
