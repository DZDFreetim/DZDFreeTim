using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class IssueSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var Issue = new List<Issue>()
            {
                new IssueStatus()
                {
                    IssueId="1560510",
                    IssueName="ITSM-453728",
                    IssueType="Incident",
                    CompanyId="Odeabank",
                    Summary="internet ve mobil şube parola değiştirme sorunu ",
                    AssigneeId="batuhan@dzdtech.com",
                    ReporterId="Odeabank_Jira",
                    Resolution="Done",
                    Priority="Low",
                    Created="17.06.2020 12:25",
                    Resolved="18.06.2020 17:05",
                    Status="Closed"
                },
                new IssueStatus()
                {
                    IssueId="1616434",
                    IssueName="ITSM-460952",
                    IssueType="Service Request",
                    CompanyId="HSBC",
                    Summary="İb ve mobil kanallarında son beş login işlemi",
                    AssigneeId="batuhan@dzdtech.com",
                    ReporterId="bertanpiset@hsbc.com.tr",
                    Resolution="Done",
                    Priority="Low",
                    Created="30.06.2020 09:06",
                    Resolved="24.07.2020 10:42",
                    Status="Closed"
                },
                new IssueStatus()
                {
                    IssueId="2043290",
                    IssueName="ITSM-596790",
                    IssueType="Incident",
                    CompanyId="Odeabank",
                    Summary="İnternet PC kanalında EFT işlemini tamamlayamama sorunu",
                    AssigneeId="emrepinar@dzdtech.com",
                    ReporterId="Odeabank_Jira",
                    Resolution="Done",
                    Priority="Low",
                    Created="27.01.2021 15:21",
                    Resolved="24.02.2021 10:41",
                    Status="Closed"
                },
                new IssueStatus()
                {
                    IssueId="2051773",
                    IssueName="ITSM-599737",
                    IssueType="Incident",
                    CompanyId="HSBC",
                    Summary="IN54272873 / Onaylanan işlem detayları sayfası",
                    AssigneeId="damla.sevinc@dzdtech.com",
                    ReporterId="erdogansengezer@hsbc.com.tr",
                    Resolution="Done",
                    Priority="Low",
                    Created="1.02.2021 15:19",
                    Resolved="24.02.2021 09:55",
                    Status="Closed"
                },


            };
            modelBuilder.Entity<Issue>().HasData(Issue);



        }
    }
}
