using HutechPM.Data.Common;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.ProjectDetailData
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
            return await _dbContext.projectDetails.Include(p =>p.user).ToListAsync();
        }
        public async Task<ActionBaseResult> AddProjectDetail(ProjectDetail projectDetail)
        {
             
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    await _dbContext.projectDetails.AddAsync(projectDetail);
                    await _dbContext.SaveChangesAsync();
                    return new ActionBaseResult() { Success = true, Message = "Add project Successful" };
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }
    }
}
