using DZDFreeTim.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DZDFreeTim.Data.Abstract
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);

    }
}
