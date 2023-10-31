using HutechPM.Data.Common;
using HutechPM.Data.Data.ProjectData;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Data.ProjectAttachmentData
{
    public class ProjectAttachmentService
    {
        private readonly ProjectAttachmentRepository projectAttachmentRepository;
        public ProjectAttachmentService(HutechNoteDbContext _dbContext)
        {
            this.projectAttachmentRepository = new ProjectAttachmentRepository(_dbContext);
        }

        public async Task<List<ProjectAttachment>> getAllProjectAttachment()
        {
            return await projectAttachmentRepository.getAllProjectAttachment();
        }
        public async Task<ActionBaseResult> DeleteProjectAttachment(ProjectAttachment projectAttachment)
        {
            return await projectAttachmentRepository.DeleteProjectAttachment(projectAttachment);
        }

        public async Task<ActionBaseResult> CreateProjectAttachment(ProjectAttachment projectAttachment)
        {
            return await projectAttachmentRepository.CreateProjectAttachment(projectAttachment);
        }
    }
}
