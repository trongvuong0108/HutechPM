using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace HutechPM.Data.Entities
{
    [Table("ProjectTask")]
    public class ProjectTask
    {
        [Key]
        [Column("project_task_id")]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid userId { set; get; }
        [Column("name")]
        public string name { set; get; }
        [Column("description")]
        public string description { set; get; }
        [Column("estimate")]
        public int estimate { set; get; }
        [Column("remaining")]
        public int remaining { set; get; }

        public ProjectDetail projectDetail { set; get; }

        public ICollection<ProjectAttachment>  projectAttachments { get; set; }
    }
}