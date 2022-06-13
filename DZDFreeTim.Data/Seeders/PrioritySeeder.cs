using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class PrioritySeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var priorities = new List<Priority>()
            {
                new Priority() {
                    PriorityId=1,
                    Definition=""
                },
                new Priority() {
                    PriorityId=2,
                    Definition=""
                },
                    new Priority() {
                    PriorityId=3,
                    Definition=""
                },



            };
            modelBuilder.Entity<Priority>().HasData(priorities);



        }
    }
}
