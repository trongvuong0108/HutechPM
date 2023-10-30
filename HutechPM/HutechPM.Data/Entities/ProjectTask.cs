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
        public enum TaskStatus
        {
            In_Process = 10,
            Completed = 15,
            On_Hold = 20,
        }
        [Key]
        [Column("project_task_id")]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid projectTaskid { set; get; }
        [Column("taskName")]
        public string name { set; get; }
        [Column("description")]
        [AllowNull]
        public string description { set; get; }
        [Column("estimate")]
        public int estimate { set; get; }
        [Column("remaining")]
        public int remaining { set; get; }
        [Required]
        [Column("status")]
        public TaskStatus taskStatus { get; set; }

        [ForeignKey("project_detail_id")]
        public ProjectDetail projectDetail { set; get; }

        public ICollection<ProjectAttachment>  projectAttachments { get; set; }
    }
}