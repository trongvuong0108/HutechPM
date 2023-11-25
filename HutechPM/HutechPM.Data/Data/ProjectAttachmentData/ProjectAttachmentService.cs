using HutechPM.Domain.Entities;
using HutechPM.Infrastructure.Common;
using HutechPM.Infrastructure.ProjectAttachmentData;

namespace HutechPM.Data.Data.ProjectAttachmentData
{
    public class ProjectAttachmentService
    {
        private readonly ProjectAttachmentRepository _projectAttachmentRepository;
        public ProjectAttachmentService(ProjectAttachmentRepository projectAttachmentRepository)
        {
            this._projectAttachmentRepository = projectAttachmentRepository;
        }

        public async Task<List<ProjectAttachment>> getAllProjectAttachment()
        {
            return await _projectAttachmentRepository.getAllProjectAttachment();
        }
        public async Task<ActionBaseResult> DeleteProjectAttachment(ProjectAttachment projectAttachment)
        {
            return await _projectAttachmentRepository.DeleteProjectAttachment(projectAttachment);
        }

        public async Task<ActionBaseResult> CreateProjectAttachment(ProjectAttachment projectAttachment)
        {
            return await _projectAttachmentRepository.CreateProjectAttachment(projectAttachment);
        }
    }
}
