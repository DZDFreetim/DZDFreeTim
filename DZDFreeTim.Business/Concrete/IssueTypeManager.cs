using System;
using DataAccessLayer.Concrete;
using DZDFreeTim.Data.Entity;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class IssueTypeManager
    {
        Repository<IssueType> repoIssueType = new Repository<IssueType>();
        public string GetNameById(int id)
        {
            var issueType = repoIssueType.GetById(id);
            if (issueType == null)
            {
                return String.Empty;
            }
            return issueType.Definition;
        }


    }
}
