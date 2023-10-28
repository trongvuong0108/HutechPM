using HutechPM.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HutechPM.Data.Entities;
namespace HutechPM.Data.UserData
{
    public class ProjectRepository
    {
        public HutechNoteDbContext _dbContext;

        public ProjectRepository(HutechNoteDbContext dbContext) { _dbContext = dbContext; }

      /* public List<User> GetAllUser()
        {
            return _dbContext.users.ToList();
        }*/
    }
        
    
}
