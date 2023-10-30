using Hutech.Data;
using HutechNote.UI.Frm;
using HutechPM.UI.Frm;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace HutechNote.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddApplication();
            Application.Run(new FrmLogin());
        }
    }
}