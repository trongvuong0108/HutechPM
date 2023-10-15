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
    [Table("project_detail")]
    public class ProjectDetail
    {
        [Key]
        [Column("project_detail_id")]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid projectDetailId { set; get; }
        [Required]
        [Column("user_id")]
        public Guid ProjectId { get; set; }
        [Required]
        [Column("user_id")]
        public Guid userId { get; set; }
        [Column("time_join")]
        public DateTime timeJoin { get; set; }
        [Required]
        [Column("time_left")]
        public DateTime timeLeft { get; set; }
        [Required]
        [Column("project_role")]
        public projectRole projectRole { get; set; }
    }

}
