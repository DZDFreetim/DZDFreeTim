using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity
{
    public class DzdStatus
    {
        [Key]
        public int DzdStatusId { get; set; }

        [Column(TypeName = "nvharchar(150)")]
        public string Definition { get; set; }
    }
}
