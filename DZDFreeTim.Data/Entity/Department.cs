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
    public class Department: IAuditEntity
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required, StringLength(50)]
        public string DepartmentName { get; set; }
    }
}
