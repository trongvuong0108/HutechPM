using HutechPM.Domain.Entities;
using HutechPM.Infrastructure.Common;
using HutechPM.Infrastructure.ProjectDetailData;

namespace HutechPM.Data.Data.ProjectDetailData
{
    public class ProjectDetailService
    {
        public ProjectDetailRepository _projectDetailRepository;
        public ProjectDetailService(ProjectDetailRepository projectDetailRepository)
        {
            this._projectDetailRepository = projectDetailRepository;
        }
        public async Task<List<ProjectDetail>> getAllProjectDetail()
        {
            return await _projectDetailRepository.getAllProjectDetail();
        }
        public async Task<ActionBaseResult> AddProjectDetail(ProjectDetail projectDetail)
        {
            return await _projectDetailRepository.AddProjectDetail(projectDetail);
        }
        public async Task<ActionBaseResult> DeleteProjectDetail(ProjectDetail projectDetail)
        {
            return await _projectDetailRepository.DeleteProjectDetail(projectDetail);
        }

        public async Task<List<ProjectDetail>> getAllProjectDetailByUser(User user)
        {
            return await _projectDetailRepository.getAllProjectDetailByUser(user);
        }
    }
}
