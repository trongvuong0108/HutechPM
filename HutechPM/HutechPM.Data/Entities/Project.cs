using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Entities
{
    [Table("Project")]
    public class Project
    {
        [Key]
        [Column("project_id")]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid projectId { set; get; }
        [Column("project_name")]
        [NotNull]

        public string projectName { set; get; }
        [Column("description")]
        [AllowNull]
        public string description { set; get; }
        [Column("date_start")]
        public DateTime dateStart { set; get; }

        [Column("date_end")]
        public DateTime dateEnd { set; get; }

        [Column("is_active")]
        public bool isActive { set; get; }
        public ICollection<ProjectDetail> ApplicationProjectDetails { set; get; }
        public override string ToString()
        {
            return projectName;
        }
    }
}
