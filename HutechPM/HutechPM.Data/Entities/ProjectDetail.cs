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
    public enum projectRole
    {
        ProjectManager = 10,
        ProjectMember = 15,
        ProjectSupport = 20
    }


    [Table("ProjectDetail")]
    public class ProjectDetail
    {
        [Key]
        [Column("project_detail_id")]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid projectDetailId { set; get; }
        public Guid? project_id { get; set; }
        [ForeignKey("project_id")]
        public Project project { get; set; }
        public Guid? user_id { get; set; }
        [ForeignKey("user_id")]
        public User user { get; set; }
        [Column("time_join")]
        public DateTime timeJoin { get; set; }
        [Required]
        [Column("time_left")]
        public DateTime timeLeft { get; set; }
        [Required]
        [Column("project_role")]
        public projectRole projectRole { get; set; }
        public ICollection<ProjectTask> projectTasks { set; get; }
    }

}
