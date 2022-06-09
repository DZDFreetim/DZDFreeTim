using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity
{
    class Resolution : BaseEntity
    {
        [Key]
        public int ResolutionId { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string Definition { get; set; }
    }
}
