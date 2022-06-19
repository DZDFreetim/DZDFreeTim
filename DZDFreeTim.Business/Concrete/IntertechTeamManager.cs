using System;
using DataAccessLayer.Concrete;
using DZDFreeTim.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class IntertechTeamManager
    {
        Repository<IntertechTeam> repoIntertechTeam = new Repository<IntertechTeam>();
        public string GetNameById(int id)
        {
            var team = repoIntertechTeam.GetById(id);
            if(team == null)
            {
                return String.Empty;
            }
            return team.TeamName;
        }
    }
}
