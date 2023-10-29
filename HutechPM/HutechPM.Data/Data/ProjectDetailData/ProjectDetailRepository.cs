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
        public List<ProjectDetail> getAllProjectDetail()
        {
            return _dbContext.projectDetails.Include(p =>p.user).ToList();
        }
        public void AddProjectDetail(ProjectDetail projectDetail)
        {
            _dbContext.projectDetails.Add(projectDetail);
        }
       
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
