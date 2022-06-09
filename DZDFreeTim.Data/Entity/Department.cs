using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string DepartmentName { get; set; }
    }
}
