using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class TeamSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var teams = new List<Team>()
            {
                new Team() {
                   TeamId=1,
                   TeamName="Power Rangers",
                   DepartmentId=3
                },
                new Team() {
                   TeamId=2,
                   TeamName="Freetim",
                   DepartmentId=1
                },
                new Team() {
                   TeamId=3,
                   TeamName="JiraSupporters",
                   DepartmentId=2
                },


            };
            modelBuilder.Entity<Team>().HasData(teams);



        }
    }
}