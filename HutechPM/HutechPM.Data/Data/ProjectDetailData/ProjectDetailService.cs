using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectTaskData;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.ProjectDetailData
{
    public class ProjectDetailService
    {
        public ProjectDetailRepository projectDetailRepository;
        public ProjectDetailService(HutechNoteDbContext _dbContext)
        {
            this.projectDetailRepository = new ProjectDetailRepository(_dbContext);
        }
        public async Task<List<ProjectDetail>> getAllProjectDetail()
        {
            return await projectDetailRepository.getAllProjectDetail();
        }
        public async Task<ActionBaseResult> AddProjectDetail(ProjectDetail projectDetail)
        {
            return await projectDetailRepository.AddProjectDetail(projectDetail);
        }
        public async Task<ActionBaseResult> DeleteProjectDetail(ProjectDetail projectDetail)
        {
            return await projectDetailRepository.DeleteProjectDetail(projectDetail);
        }

        public async Task<List<ProjectDetail>> getAllProjectDetailByUser(User user)
        {
            return await projectDetailRepository.getAllProjectDetailByUser(user);
        }
    }
}
