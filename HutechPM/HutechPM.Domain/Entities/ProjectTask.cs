using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace HutechPM.Domain.Entities
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