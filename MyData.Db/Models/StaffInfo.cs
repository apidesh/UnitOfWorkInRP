using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyData.Db.Models
{
    [Table("StaffInfo")]
    public class StaffInfo
    {
        [Column("ID")]
        [Key]
        public Guid ID { get; set; }

        [Required]
        [Column("EmployeeID")]
        public string EmployeeID { get; set; }

        [Required]
        [Column("DivisionName")]
        public string DivisionName { get; set; }

        [Required]
        [Column("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Column("LastName")]
        public string LastName { get; set; }

        [Required]
        [Column("Email")]
        public string Email { get; set; }

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