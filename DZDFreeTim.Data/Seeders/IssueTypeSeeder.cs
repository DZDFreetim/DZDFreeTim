using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class IssueTypeSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var issueTypes = new List<IssueType>()
            {
                new IssueType() {
                    IssueId=1,
                    Definition=""
                },
                 new IssueType() {
                    IssueId=2,
                    Definition=""
                },
                  new IssueType() {
                    IssueId=3,
                    Definition=""
                },




            };
            modelBuilder.Entity<IssueType>().HasData(issueTypes);



        }
    }
}
