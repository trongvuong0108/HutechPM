using HutechPM.Data.Common;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HutechPM.Data.UserData
{
    public class UserRepository
    {
        private readonly HutechNoteDbContext _dbContext;

        public UserRepository(HutechNoteDbContext dbContext) { _dbContext = dbContext; }

        public async Task<List<User>> getAllUser()
        {
            return await _dbContext.users.ToListAsync();
        }
        public async Task<ActionBaseResult> createUser(User user)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    await _dbContext.users.AddAsync(user);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return new ActionBaseResult() { Success = true, Message = "SignUp Successful" };
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }

        }
        public async Task<ActionBaseResult> updateUser(User user)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.users.Update(user);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return new ActionBaseResult() { Success = true, Message = "SignUp Successful" };
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }
        public async Task<ProjectDetail> findProjetRoleOfOwner(User user)
        {
            List<ProjectDetail> projectDetails = await _dbContext.projectDetails
                                                    .Include(p => p.projectTasks)
                                                    .Include(p => p.user).ToListAsync();
            return projectDetails.FirstOrDefault(p => p.user.userId == user.userId);
        }
        public async Task<List<ProjectTask>> GetProjectTask()
        {
            return await _dbContext.projectTasks.Include(x => x.projectDetail.project).Include(x => x.projectDetail.user).ToListAsync();
        }

        public async Task<User> findUserByEmail(string email)
        {
            return await _dbContext.users.FirstOrDefaultAsync(x => x.email == email);


        }
   
    }


}
