using DataAccessLayer.Concrete;
using DZDFreeTim.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class ProjectManager 
    {

        Repository<Project> repoProject = new Repository<Project>();
        
        public List<Project> GetAll()
        {
            return repoProject.List();
        }


        




        
    }
}
