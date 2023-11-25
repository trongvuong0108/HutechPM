using HutechPM.Domain.Entities;
using HutechPM.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace HutechPM.Infrastructure.ProjectDetailData
{
    public class ProjectDetailRepository
    {
        private readonly HutechNoteDbContext _dbContext;

        public ProjectDetailRepository(HutechNoteDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<List<ProjectDetail>> getAllProjectDetail()
        {
            return await _dbContext.projectDetails.Include(p =>p.user).Include(p=>p.project).ToListAsync();
          
        }
        public async Task<ActionBaseResult> AddProjectDetail(ProjectDetail projectDetail)
        {
             
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    await _dbContext.projectDetails.AddAsync(projectDetail);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return new ActionBaseResult() { Success = true, Message = "Add project Successful" };
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }
        public async Task<ActionBaseResult> DeleteProjectDetail(ProjectDetail projectDetail)
        {

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.projectDetails.Remove(projectDetail);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return new ActionBaseResult() { Success = true, Message = "Add project Successful" };
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }
        public async Task<List<ProjectDetail>> getAllProjectDetailByUser(User user)
        {
            return await _dbContext.projectDetails.Include(p=>p.project).Where(p => p.user.userId == user.userId && p.projectRole == projectRole.ProjectManager).ToListAsync();
        }
    }
}
