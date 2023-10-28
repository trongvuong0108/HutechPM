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
        public ActionBaseResult createUser(User user)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.users.Add(user);
                    _dbContext.SaveChanges();
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
