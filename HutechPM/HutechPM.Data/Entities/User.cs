using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace HutechPM.Data.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("use_id")]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid userId { set; get; }

        [NotNull]
        [StringLength(50)]
        [Column("user_name")]
        public string userName { set; get; }

        [StringLength(50)]
        [EmailAddress]
        [NotNull]
        [Column("email")]
        public string email { set; get; }

        [StringLength(11)]
        [Column("phone")]
        public string phone { set; get; }

        [NotNull]
        [Column("password")]
        public string password { set; get; }

        [StringLength(50)]
        [Column("full_name")]
        public string fullName { set; get; }

        [StringLength(50)]
        [Column("address")]
        public string address { set; get; }
        [Column("gender")]
        public bool gender { set; get; }

        [Column("is_active")]
        public bool isActive { set; get; }
        public ICollection<ProjectDetail> ApplicationProjectDetails { set; get; }

        public User(Guid userId, string userName, string email, string phone, string password, string fullName, string address)
        {
            this.userId = userId;
            this.userName = userName;
            this.email = email;
            this.phone = phone;
            this.password = password;
            this.fullName = fullName;
            this.address = address;
        }
    }
}
