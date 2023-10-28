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
        public HutechNoteDbContext _dbContext;

        public ProjectTaskRepository(HutechNoteDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public List<ProjectTask> GetProjectTask()
        {
            return _dbContext.projectTasks.Include(x => x.projectDetail.project).Include(x => x.projectDetail.user).ToList();
        }
    }
}
