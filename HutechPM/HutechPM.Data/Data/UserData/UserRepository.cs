using HutechPM.Data.Common;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;

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
                    return new ActionBaseResult() { Success = true, Message = "SignUp Successful" };
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
