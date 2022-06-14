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
                    Definition="12"
                },
                new Reporter() {
                    ReporterId=2,
                    Definition="32"
                },
                new Reporter() {
                    ReporterId=3,
                    Definition="48"
                },




            };
            modelBuilder.Entity<Reporter>().HasData(reporters);



        }
    }
}
