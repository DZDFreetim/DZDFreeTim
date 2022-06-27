using DZDFreeTim.Data.Abstract;
using DZDFreeTim.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DZDFreeTim.Data.Concreate
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee CreateEmployee(Employee employee)
        {
            using (var appDbContext = new AppDbContext())
            {
                appDbContext.Employees.Add(employee);
                appDbContext.SaveChanges();
                return employee;
            }
        }



        public void DeleteEmployee(int id)
        {
            using (var appDbContext = new AppDbContext())
            {
                var deleteEmployee = GetEmployeeById(id);
                appDbContext.Employees.Remove(deleteEmployee);
                appDbContext.SaveChanges();
            }
        }



        public List<Employee> GetAllEmployee()
        {
            using (var appDbContext = new AppDbContext())
            {
                return appDbContext.Employees.ToList();
            }
        }



        public Employee GetEmployeeById(int id)
        {
            using (var appDbContext = new AppDbContext())
            {
                return appDbContext.Employees.Find(id);
            }
        }



        public Employee UpdateEmployee(Employee employee)
        {
            using (var appDbContext = new AppDbContext())
            {
                appDbContext.Employees.Update(employee);
                appDbContext.SaveChanges();
                return employee;
            }
        }
    }
}

