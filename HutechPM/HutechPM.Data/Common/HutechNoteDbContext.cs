using HutechPM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Common
{
    public class HutechNoteDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<ProjectAttachment> acttachments { get; set; }
        public DbSet<ProjectDetail> projectDetails { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<ProjectTask> projectTasks { get; set; }
        public HutechNoteDbContext()
        {
        }
        public HutechNoteDbContext(DbContextOptions<HutechNoteDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(@"Data Source=TRANTRUNG\SQLEXPRESS; Initial Catalog=hutechpm_Database; trusted_connection=true;");
            //optionsBuilder.UseSqlServer(@"Data Source=sql.bsite.net\MSSQL2016; Initial Catalog=hutechpm_Database; User ID=hutechpm_Database; pwd=Password@1234; MultipleActiveResultSets = True; TrustServerCertificate = True");
            optionsBuilder.UseSqlServer(@"Server=tcp:hutechpm.database.windows.net,1433;Initial Catalog=HutechPM;Persist Security Info=False;User ID=adminHutechPM;Password=Password@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public List<T> ExecSQL<T>(string query)
        {
            using (var command = Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                Database.OpenConnection();

                List<T> list = new List<T>();
                using (var result = command.ExecuteReader())
                {
                    T obj = default;
                    while (result.Read())
                    {
                        obj = Activator.CreateInstance<T>();
                        foreach (PropertyInfo prop in obj.GetType().GetProperties())
                        {
                            if (!Equals(result[prop.Name], DBNull.Value))
                            {
                                prop.SetValue(obj, result[prop.Name], null);
                            }
                        }
                        list.Add(obj);
                    }
                }
                Database.CloseConnection();
                return list;
            }
        }
    }
}
