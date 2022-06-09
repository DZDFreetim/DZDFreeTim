using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class EmployeeSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var employees = new List<Employee>()
            {
                new Employee() { Email = "", Password = "", Name = "" },
                new Employee() { Email = "", Password = "", Name = "" },
                new Employee() { Email = "", Password = "", Name = "" },
                new Employee() { Email = "", Password = "", Name = "" },



            };
            modelBuilder.Entity<Employee>().HasData(employees);
                       


        }

    }
}
