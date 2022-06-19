using System;
using DataAccessLayer.Concrete;
using DZDFreeTim.Data.Entity;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class IssueStatusManager
    {
        Repository<IssueStatus> repoIssueStatus = new Repository<IssueStatus>();
        public string GetNameById(int id)
        {
            var issueStatus = repoIssueStatus.GetById(id);
            if (issueStatus == null)
            {
                return String.Empty;
            }
            return issueStatus.Definition;
        }


    }
}
