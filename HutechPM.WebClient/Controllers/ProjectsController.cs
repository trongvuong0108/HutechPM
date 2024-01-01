using HutechPM.Application.Data.ProjectData;
using HutechPM.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HutechPM.WebClient.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService) { this._projectService = projectService; }
        public async Task<IActionResult> Index()
        {
            List<Project> projects = await _projectService.getAllProject();
            return View(projects);
        }
    }
}
