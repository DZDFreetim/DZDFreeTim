using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class DepartmentSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var departments = new List<Department>()
            {
                new Department() { 
                    DepartmentId=1,
                    DepartmentName="analists"
                },
                new Department() {
                    DepartmentId=2,
                    DepartmentName="software"
                },
                new Department() {
                    DepartmentId=3,
                    DepartmentName="jira"
                },


            };
            modelBuilder.Entity<Department>().HasData(departments);



        }
    }
}
