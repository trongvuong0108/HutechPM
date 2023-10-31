
using HutechNote.Data.Data.ProjectData;
using HutechPM.Data.Data.ProjectData;
using Microsoft.Extensions.DependencyInjection;

namespace Hutech.Data
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ProjectRepository>();
            services.AddScoped<ProjectService>();
        }
    }
}
