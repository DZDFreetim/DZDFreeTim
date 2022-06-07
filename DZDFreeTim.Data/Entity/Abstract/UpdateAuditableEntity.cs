using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity.Abstract
{
    public class UpdateAuditableEntity : BaseEntity
    {
        public int UpdatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
