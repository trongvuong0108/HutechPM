using HutechPM.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace HutechPM.Data.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("user_id")]
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

        [Column("avatar")]
        public string avatar { set; get; }
        public ICollection<ProjectDetail> ApplicationProjectDetails { set; get; }

        public User(Guid userId, string userName, string password, string email, string phone, string fullName, string address)
        {
            this.userId = userId;
            this.userName = userName;
            this.email = email;
            this.phone = phone;
            this.password = password;
            this.fullName = fullName;
            this.address = address;
            this.avatar = CommonConstanst.DEFAULT_AVT;
        }

        public override string ToString()
        {
            return userName;
        }
    }
}
