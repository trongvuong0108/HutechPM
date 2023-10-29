﻿using HutechPM.Data.Common;
using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HutechPM.Data.Data.ProjectData
{
    public class ProjectRepository
    {
        public HutechNoteDbContext _dbContext { set; get; }

        public ProjectRepository(HutechNoteDbContext dbContext) 
        { 
            this._dbContext = dbContext; 
        }
        public async Task<List<Project>> GetProject()
        {
            return await _dbContext.projects.ToListAsync();
        }

        public async Task<List<ProjectTask>> GetProjectTask()
        {
            return await _dbContext.projectTasks.Include(x => x.projectDetail.project).Include(x => x.projectDetail.user).ToListAsync(); 
        }

        public async Task<ProjectDetail> findProjectOfOwner(Project project)
        {
            List<ProjectDetail> projectDetails = await _dbContext.projectDetails
                                                    .Include(p => p.projectTasks)
                                                    .Include(p => p.user).ToListAsync();
            return projectDetails.FirstOrDefault(p => p.project.projectId == project.projectId && p.projectRole == projectRole.ProjectManager);
        }

        public async Task<ActionBaseResult> AddProject(Project project)
        {
            
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    await _dbContext.projects.AddAsync(project);
                     _dbContext.SaveChanges();
                    return new ActionBaseResult() { Success = true, Message = "Add project Successful" };
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return new ActionBaseResult() { Success = false, Message = e.Message };
                }
            }
        }
    }
}
