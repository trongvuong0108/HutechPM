using HutechPM.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.User
{
    public class ApplicationUserRepository
    {
        public HutechNoteDbContext _dbContext;

        public ApplicationUserRepository(HutechNoteDbContext dbContext) { _dbContext = dbContext; }
    }
}
