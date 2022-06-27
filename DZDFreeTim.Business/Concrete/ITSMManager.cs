using DataAccessLayer.Concrete;
using DZDFreeTim.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class ITSMManager
    {
        Repository<Issue> repoitsm = new Repository<Issue>();

        public List<Issue> GetAll()
        {
            return repoitsm.List();
        }
        public string GetNameById(int id)
        {
            var itsmName = repoitsm.GetById(id);
            if (itsmName == null)
            {
                return String.Empty;
            }
            return itsmName.IssueName;
        }
    }
}

