using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity
{
    public class IntertechTeam
    {
        [Key]
        public int IntertechTeamId { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string TeamName { get; set; }

    }
}
