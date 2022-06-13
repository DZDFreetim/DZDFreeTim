using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class IssueStatusSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var issueStatuses = new List<IssueStatus>()
            {
                new IssueStatus() { IssueStatusId =1560510, Definition="ab"},
                new IssueStatus() { IssueStatusId =1616430, Definition="bc"},
                new IssueStatus() { IssueStatusId =2043290, Definition="cd"},
                new IssueStatus() { IssueStatusId =2051773, Definition="de"},
                new IssueStatus() { IssueStatusId =2052992, Definition="ef"},

            };
            modelBuilder.Entity<IssueStatus>().HasData(issueStatuses);

        }

    }
}
