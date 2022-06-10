using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DZDFreeTim.Data.Entity.Abstract;

namespace DZDFreeTim.Data.Entity
{
    public class Resolution : BaseEntity
    {
        [Key]
        public int ResolutionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Definition { get; set; }
    }
}
