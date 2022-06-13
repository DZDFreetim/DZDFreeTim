using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class ReporterSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var reporters = new List<Reporter>()
            {
                new Reporter() {
                    ReporterId=1,
                    Definition=""
                },
                new Reporter() {
                    ReporterId=2,
                    Definition=""
                },
                new Reporter() {
                    ReporterId=3,
                    Definition=""
                },




            };
            modelBuilder.Entity<Reporter>().HasData(reporters);



        }
    }
}
