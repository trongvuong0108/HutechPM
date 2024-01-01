
using HutechPM.Infrastructure.Common;
using HutechPM.Infrastructure.ProjectAttachmentData;
using HutechPM.Infrastructure.ProjectData;
using HutechPM.Infrastructure.ProjectDetailData;
using HutechPM.Infrastructure.ProjectTaskData;
using HutechPM.Infrastructure.UserData;
using Microsoft.Extensions.DependencyInjection;

namespace Hutech.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ProjectAttachmentRepository>();
            services.AddScoped<ProjectDetailRepository>();
            services.AddScoped<ProjectRepository>();
            services.AddScoped<ProjectTaskRepository>();
            services.AddScoped<UserRepository>();
            services.AddDbContext<HutechNoteDbContext>();
        }
    }
}
