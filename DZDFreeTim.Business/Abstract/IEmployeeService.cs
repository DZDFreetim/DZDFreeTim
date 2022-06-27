using DZDFreeTim.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DZDFreeTim.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);



    }
}