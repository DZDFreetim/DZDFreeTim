using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity
{
    public class JiraStatus
    {
        [Key]
        public int JiraStatusId { get; set; }

        [Column(TypeName = "nvharchar(150)")]
        public string Definition { get; set; }
    }
}
