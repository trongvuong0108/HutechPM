using DevExpress.Xpo.Logger.Transport;
using Hutech.Data;
using HutechNote.UI.Frm;
using HutechPM.Data.UserData;
using HutechPM.UI.Frm;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace HutechNote.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             IHostBuilder builder = new HostBuilder()
             .ConfigureAppConfiguration((hostContext, builder) =>
             {
                 builder.AddJsonFile("apsettings.json", optional: true, reloadOnChange: true);
             })
            .ConfigureServices((hostContext, services) =>
            {
                services.AddApplication();
            });

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                IServiceProvider services = serviceScope.ServiceProvider;
                FrmLogin mainform = services.GetRequiredService<FrmLogin>();
                System.Windows.Forms.Application.Run(mainform);
            }
            Application.Run(new FrmLogin());
        }
    }
}