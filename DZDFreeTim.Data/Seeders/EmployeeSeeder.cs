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
                new Employee() {
                    EmployeeID = 1,
                    Name = "Sena Kaytaz",
                    Email = "sena.kaytaz@dzdtech.com",
                    Password = "kyd8952e",
                    EmployementDate = new DateTime(2018, 7, 24),
                    EmployeeType = "analyst",
                    TeamId = 1
        
                },
                new Employee() {
                    EmployeeID = 2,
                    Name = "Büşra Aydın",
                    Email = "busra.aydin@dzdtech.com",
                    Password = "efedw562",
                    EmployementDate = new DateTime(2019, 7, 24),
                    EmployeeType = "analyst",
                    TeamId = 2

                },
                new Employee() {
                    EmployeeID = 3,
                    Name = "Yasin Ekinci",
                    Email = "yasin.ekinci@dzdtech.com",
                    Password = "eu546des",
                    EmployementDate = new DateTime(2019, 5, 24),
                    EmployeeType = "developer",
                    TeamId = 3

                },
                new Employee() {
                    EmployeeID = 4,
                    Name = "Mustafa Mercan",
                    Email = "mustafa.mercan@dzdtech.com",
                    Password = "dk856sd3",
                    EmployementDate = new DateTime(2020, 10, 20),
                    EmployeeType = "developer",
                    TeamId = 1

                }

            };
            modelBuilder.Entity<Employee>().HasData(employees);
                       


        }

    }
}
