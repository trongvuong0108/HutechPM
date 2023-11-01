
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.Data.Entities
{
    [Table("ProjectAttachment")]
    public class ProjectAttachment
    {
        [Key]
        [Column("acttachment_id")]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid acttachmentId { set; get; }
        [Column("acttachment_name")]
        public string acttachmentName { set; get; }

        [Column("type")]
        public string acttachmentType { set; get; }

        [Column("description")]
        public string description { set; get; }
        [AllowNull]

        [Column("fileName")]
        public string filename { set; get; }

        [Column("date_create")]
        public DateTime dateCreate { set; get; }
        public ProjectTask task { set; get; }
    }
}
