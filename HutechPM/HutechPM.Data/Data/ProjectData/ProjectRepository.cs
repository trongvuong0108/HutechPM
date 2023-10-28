using HutechPM.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HutechPM.Data.Entities;
using HutechPM.Data.Data.ProjectData.DTO;
using HutechPM.Data.Data.User;
using Microsoft.EntityFrameworkCore;

namespace HutechPM.Data.Data.ProjectData
{
    public class ProjectRepository
    {
        public HutechNoteDbContext _dbContext;

        public ProjectRepository(HutechNoteDbContext dbContext) 
        { 
            this._dbContext = dbContext; 
        }
        public List<Project> GetProject()
        {
            return _dbContext.projects.ToList();
        }

        public List<ProjectTask> GetProjectTask()
        {
            return _dbContext.projectTasks.Include(x => x.projectDetail.project).Include(x => x.projectDetail.user).ToList(); 
        }

        public ProjectDetail findProjectOfOwner(Project project)
        {
            return _dbContext.projectDetails.Include(p => p.projectTasks).Include(p => p.user).FirstOrDefault(p => p.project.projectId == project.projectId && p.projectRole == projectRole.ProjectManager);
        }

        public Project GetProjectid(Guid projectid)
        {
            return _dbContext.projects.Find(projectid);
        }

    }
}
