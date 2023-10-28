using HutechPM.Data.Common;
using HutechPM.Data.Entities;

namespace HutechPM.Data.UserData
{
    public class UserRepository
    {
        private readonly HutechNoteDbContext _dbContext;

        public UserRepository(HutechNoteDbContext dbContext) { _dbContext = dbContext; }
        public IEnumerable<User> getAllUser()
        {
            return _dbContext.users;
        }
    }
        
    
}
