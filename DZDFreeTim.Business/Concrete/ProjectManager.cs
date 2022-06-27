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
        public string GetNameById(int id)
        {
            var projectName = repoProject.GetById(id);
            if (projectName == null)
            {
                return String.Empty;
            }
            return projectName.ProjectName;
        }







    }
}
