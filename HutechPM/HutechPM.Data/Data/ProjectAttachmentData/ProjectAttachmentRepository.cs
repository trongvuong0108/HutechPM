using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectData;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.ProjectAttachmentData
{
    public class ProjectAttachmentRepository
    {
        public HutechNoteDbContext _dbContext { set; get; }

        public ProjectAttachmentRepository(HutechNoteDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<List<ProjectAttachment>> getAllProjectAttachment()
        {
            return await _dbContext.acttachments.Include(p => p.task).ToListAsync();
        }
        public async Task<ActionBaseResult> DeleteProjectAttachment(ProjectAttachment projectAttachment)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.acttachments.Remove(projectAttachment);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return new ActionBaseResult() { Success = true, Message = "Remove Attachment Successful" };
                }
                catch (Exception e)
                {
                    await transaction.RollbackAsync();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }

        public async Task<ActionBaseResult> CreateProjectAttachment(ProjectAttachment projectAttachment)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.acttachments.Add(projectAttachment);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return new ActionBaseResult() { Success = true, Message = "Add Attachment Successful" };
                }
                catch (Exception e)
                {
                    await transaction.RollbackAsync();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }


    }
}
