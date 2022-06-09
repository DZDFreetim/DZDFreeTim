using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity
{
    class Reporter : BaseEntity
    {
        [Key]
        public int ReporterId { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string Definition { get; set; }
    }
}