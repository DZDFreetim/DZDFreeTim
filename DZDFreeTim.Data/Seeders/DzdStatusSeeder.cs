using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class DzdStatusSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var dzdStatuses = new List<DzdStatus>()
            {
                new DzdStatus() {
                    DzdStatusId=1,
                    Definition=""
                },
                new DzdStatus() {
                    DzdStatusId=2,
                    Definition=""
                },
                new DzdStatus() {
                    DzdStatusId=3,
                    Definition=""
                },



            };
            modelBuilder.Entity<DzdStatus>().HasData(dzdStatuses);



        }
    }
}
