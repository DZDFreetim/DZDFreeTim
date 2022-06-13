using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class ResolutionSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var resolutions = new List<Resolution>()
            {
                new Resolution() {
                   ResolutionId=1,
                   Definition=""
                },
                new Resolution() {
                   ResolutionId=2,
                   Definition=""
                },
                new Resolution() {
                   ResolutionId=3,
                   Definition=""
                },




            };
            modelBuilder.Entity<Resolution>().HasData(resolutions);



        }
    }
}
