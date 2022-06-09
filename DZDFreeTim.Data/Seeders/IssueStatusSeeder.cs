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
            var IssueStatus = new List<IssueStatus>()
            {
                new IssueStatus() { StatusId ="1560510", Definition="ab"},
                new IssueStatus() { StatusId ="1616430", Definition="bc"},
                new IssueStatus() { StatusId ="2043290", Definition="cd"},
                new IssueStatus() { StatusId ="2051773", Definition="de"},
                new IssueStatus() { StatusId ="2052992", Definition="ef"},

            };
            modelBuilder.Entity<IssueStatus>().HasData(IssueStatus);



        }

    }
}
