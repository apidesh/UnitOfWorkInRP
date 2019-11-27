using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyData.Db.Models
{
    [Table("UserAccount")]
    public class UserAccount
    {
        [Column("ID")]
        [Key]
        public Guid ID { get; set; }

        [Required]
        [Column("AccountTypeFK")]
        public Guid AccountTypeFK { get; set; }

        [Required]
        [Column("StaffInfoFK")]
        public Guid StaffInfoFK { get; set; }

        [Required]
        [Column("Username")]
        public string Username { get; set; }

        [Required]
        [Column("Password")]
        public string Password { get; set; }

        [Required]
        [Column("IsActive")]
        public bool IsActive { get; set; }

        [Required]
        [Column("ModifyDate")]
        public DateTime ModifyDate { get; set; }

        [Required]
        [StringLength(50)]
        [Column("ModifyBy")]
        public string ModifyBy { get; set; }
    }
}