using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity.Abstract
{
    public class CreateAuditableEntity : BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
