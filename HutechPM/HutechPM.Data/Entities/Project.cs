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
        public ICollection<ProjectDetail> ApplicationProjectDetails { set; get; }
    }
}
