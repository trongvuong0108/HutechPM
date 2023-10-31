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
        public async Task<List<ProjectTask>> GetProjectTask()
        {
            return await _dbContext.projectTasks
                .Include(x => x.projectDetail.project)
                .Include(x => x.projectDetail.user)
                .ToListAsync();
        }

        public async Task<ActionBaseResult> AddProjectTask(ProjectTask projectTask)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    await _dbContext.projectTasks.AddAsync(projectTask);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return new ActionBaseResult() { Success = true, Message = "Add task Successful" };
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }

        public async Task<ActionBaseResult> upadteProjectTask(ProjectTask projectTask)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.projectTasks.Update(projectTask);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return new ActionBaseResult() { Success = true, Message = "Add task Successful" };
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }
        public async Task<ActionBaseResult> DeleteProjectTask(ProjectTask projectTask)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.projectTasks.Remove(projectTask);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return new ActionBaseResult() { Success = true, Message = "Add project Successful" };
                }
                catch (Exception e)
                {
                    await transaction.RollbackAsync();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }
        public async Task<ProjectTask> findProjectTaskId(Guid projectTaskId)
        {
            List<ProjectTask> projectTasks = await GetProjectTask();
            return projectTasks.FirstOrDefault(x => x.projectTaskid == projectTaskId);
        }

    }
}
