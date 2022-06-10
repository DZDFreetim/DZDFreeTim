using DZDFreeTim.Data.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity
{
    public class Employee : BaseEntity
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string Name { get; set; }

       
        [Required]
        [Column(TypeName = "nvharchar(150)")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string Password { get; set; }

        [Required]        
        public DateTime EmployementDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string EmployeeType { get; set; }

        public int TeamId { get; set; }

    }
}
