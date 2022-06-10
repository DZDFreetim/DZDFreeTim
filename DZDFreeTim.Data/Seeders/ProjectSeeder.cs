using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class ProjectSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var projects = new List<Project>()
            {
                new Project() { 
                    ProjectId = 1, 
                    BankId = 1, 
                    ProjectName= "Project 1" , 
                    JiraProjectNo = "jira-1",
                    JiraTaskNo = "100",
                    Priority = 1,
                    DzdStatus = 1,
                    JiraStatus = 2,
                    AnalystId = 2,
                    DeveloperId = 3,
                    IntertechTeam = 2,
                    Effort = 15,
                    Notes = "yok",
                    InvNumber = 2,
                    BillYearQuarter = "2022-Q1"
                    },
                new Project() {
                    ProjectId = 1,
                    BankId = 1,
                    ProjectName= "Project 2" ,
                    JiraProjectNo = "2",
                    JiraTaskNo = "103",
                    Priority = 80,
                    DzdStatus = 10,
                    JiraStatus = 10,
                    AnalystId = 3,
                    DeveloperId = 1,
                    IntertechTeam = 3,
                    Effort = 60,
                    Notes = "yok2",
                    InvNumber = 2,
                    BillYearQuarter = "2022-Q2"
                    },
                new Project() {
                    ProjectId = 1,
                    BankId =2,
                    ProjectName= "Project 3" ,
                    JiraProjectNo = "104",
                    JiraTaskNo = "30",
                    Priority = 40,
                    DzdStatus = 5,
                    JiraStatus = 3,
                    AnalystId = 2,
                    DeveloperId =2,
                    IntertechTeam = 2,
                    Effort = 46,
                    Notes = "yok",
                    InvNumber = 3,
                    BillYearQuarter = "2021-Q2"
                    },
                new Project() {
                    ProjectId = 1,
                    BankId = 4,
                    ProjectName= "Project 4" ,
                    JiraProjectNo = "4",
                    JiraTaskNo = "4",
                    Priority = 10,
                    DzdStatus = 11,
                    JiraStatus = 11,
                    AnalystId = 2,
                    DeveloperId = 1,
                    IntertechTeam = 1,
                    Effort = 36,
                    Notes = "yok",
                    InvNumber = 4,
                    BillYearQuarter = "2021-Q1"
                    },
            };
            modelBuilder.Entity<Project>().HasData(projects);



        }

    }
}
