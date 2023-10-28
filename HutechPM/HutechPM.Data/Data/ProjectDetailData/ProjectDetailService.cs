using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectTaskData;
using HutechPM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.ProjectDetailData
{
    public class ProjectDetailService
    {
        HutechNoteDbContext _dbContext = new HutechNoteDbContext();
        public ProjectDetailRepository projectDetailRepository;
        public ProjectDetailService()
        {
            this.projectDetailRepository = new ProjectDetailRepository(_dbContext);
        }
   
    }
}
