using System;
using DataAccessLayer.Concrete;
using DZDFreeTim.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class DzdStatusManager
    {
        Repository<DzdStatus> repoDzdStatus = new Repository<DzdStatus>();
        public string GetNameById(int id)
        {
            var status = repoDzdStatus.GetById(id);
            if (status == null)
            {
                return String.Empty;
            }
            return status.Definition;
        }
    }
}
