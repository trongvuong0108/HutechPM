using HutechNote.Data.ProjectData;
using HutechPM.Application.Data.ProjectData;
using Microsoft.Extensions.DependencyInjection;

namespace HutechPM.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
        }
    }
}
