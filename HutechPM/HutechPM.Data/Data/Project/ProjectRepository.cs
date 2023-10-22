using HutechPM.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.Project
{
    public class ProjectRepository
    {
        public HutechNoteDbContext _dbContext;

        public ProjectRepository(HutechNoteDbContext dbContext) { _dbContext = dbContext; }
    }
}
