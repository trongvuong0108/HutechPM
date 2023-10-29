using HutechPM.Data.Common;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.ProjectTaskData
{
    public class ProjectTaskRepository
    {
        public HutechNoteDbContext _dbContext { set; get; }

        public ProjectTaskRepository(HutechNoteDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public List<ProjectTask> GetProjectTask()
        {
            return _dbContext.projectTasks.Include(x => x.projectDetail.project).Include(x => x.projectDetail.user).ToList();
        }

        public void AddProjectTask(ProjectTask projectTask)
        {
            _dbContext.projectTasks.Add(projectTask);
        }
        public void upadteProjectTask(ProjectTask projectTask)
        {
            _dbContext.projectTasks.Update(projectTask);
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public ProjectTask findProjectTaskId(Guid projectTaskId)
        {
            ProjectTask projectNeedFind =_dbContext.projectTasks.FirstOrDefault(x => x.projectTaskid == projectTaskId);
            //ProjectTask projectNeedFind = _dbContext.projectTasks.Where(x => x.projectTaskid.ToString().Equals(projectTaskId.ToString(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            return projectNeedFind;
        }

    }
}
