using DataAccessLayer.Concrete;
using DZDFreeTim.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class ResolutionManager
    {
        Repository<Resolution> repoResolution = new Repository<Resolution>();
        public string GetNameById(int id)
        {
            var resolution = repoResolution.GetById(id);
            if (resolution == null)
            {
                return String.Empty;
            }
            return resolution.Definition;
        }
    }
}
