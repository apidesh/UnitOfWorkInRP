using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyData.Db.Models
{
    public class AccountType
    {
        [Column("ID")]
        [Key]
        public Guid ID { get; set; }

        [Required]
        [Column("AccountTypeName")]
        public string AccountTypeName { get; set; }

        [Required]
        [Column("AccountTypeCode")]
        public string AccountTypeCode { get; set; }

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