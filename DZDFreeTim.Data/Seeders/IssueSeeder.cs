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

            var issues = new List<Issue>()
            {
                new Issue()
                {
                    IssueId=1560510,
                    IssueName="ITSM-453728",
                    IssueType=1,
                    CompanyId=2,
                    Summary="internet ve mobil şube parola değiştirme sorunu ",
                    AssigneeId=1,
                    ReporterId=2,
                    Resolution=3,
                    Priority=1,
                    Created="17.06.2020 12:25",
                    Resolved="18.06.2020 17:05",
                    Status=2
                },
                new Issue()
                {
                    IssueId=1616434,
                    IssueName="ITSM-460952",
                    IssueType=2,
                    CompanyId=3,
                    Summary="İb ve mobil kanallarında son beş login işlemi",
                    AssigneeId=2,
                    ReporterId=1,
                    Resolution=2,
                    Priority=2,
                    Created="30.06.2020 09:06",
                    Resolved="24.07.2020 10:42",
                    Status=2
                },
                new Issue()
                {
                    IssueId=2043290,
                    IssueName="ITSM-596790",
                    IssueType=1,
                    CompanyId=2,
                    Summary="İnternet PC kanalında EFT işlemini tamamlayamama sorunu",
                    AssigneeId=3,
                    ReporterId=2,
                    Resolution=1,
                    Priority=1,
                    Created="27.01.2021 15:21",
                    Resolved="24.02.2021 10:41",
                    Status=2
                },
                new Issue()
                {
                    IssueId=2051773,
                    IssueName="ITSM-599737",
                    IssueType=1,
                    CompanyId=1,
                    Summary="IN54272873 / Onaylanan işlem detayları sayfası",
                    AssigneeId=1,
                    ReporterId=1,
                    Resolution=1,
                    Priority=3,
                    Created="1.02.2021 15:19",
                    Resolved="24.02.2021 09:55",
                    Status=3
                },


            };
            modelBuilder.Entity<Issue>().HasData(issues);

        }
    }
}
