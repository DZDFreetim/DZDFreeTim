using DataAccessLayer.Concrete;
using DZDFreeTim.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class EmployeeManager
    {
        Repository<Employee> repoEmployee = new Repository<Employee>();
        public string GetNameById(int id)
        {
            var employee= repoEmployee.GetById(id);
            if (employee == null)
            {
                return String.Empty;
            }
            return employee.Name;
        }
        public string GetEmailById(int id)
        {
            var employee = repoEmployee.GetById(id);
            if (employee == null)
            {
                return String.Empty;
            }
            return employee.Email;
        }












    }
}
