using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DZDFreeTim.Business.Concrete;
using DZDFreeTim.Web.Mvc.Models;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class AdminITSMController : Controller
    {

        ITSMManager itsmm = new ITSMManager();
        BankManager bankm = new BankManager();
        EmployeeManager employeem = new EmployeeManager();
        IssueTypeManager issuetypem = new IssueTypeManager();
        IssueStatusManager issuestatusm = new IssueStatusManager();
        ResolutionManager resolutionm = new ResolutionManager();

        [Authorize(Roles = "editor,itsm_admin")]
        public IActionResult ITSMIndex()
        {
            var issues = itsmm.GetAll();
            var listIssues = new List<ITSMDetailModel>();

            foreach (var issue in issues)
            {
                var issueModel = new ITSMDetailModel
                {
                    Priority = issue.Priority,
                    IssueId = issue.IssueId,
                    IssueName = issue.IssueName,
                    Created = issue.Created,
                    Resolved = issue.Resolved,
                    Summary = issue.Summary,
                     
                };
                if(issue.IssueType > 0)
                {
                    issueModel.IssueTypeName = issuetypem.GetNameById(issue.IssueType); 
                }
                if (issue.Status > 0)
                {
                    issueModel.StatusName = issuestatusm.GetNameById(issue.Status);
                }
                if (issue.AssigneeId > 0)
                {
                    issueModel.AssigneeMail = employeem.GetEmailById(issue.AssigneeId);
                }
                if (issue.ReporterId > 0)
                {
                    issueModel.ReporterName = employeem.GetNameById(issue.ReporterId);
                }
                if (issue.CompanyId > 0)
                {
                    issueModel.CompanyName = bankm.GetNameById(issue.CompanyId);
                }
                if (issue.Resolution > 0)
                {
                    issueModel.ResolutionName = resolutionm.GetNameById(issue.Resolution);
                }
                listIssues.Add(issueModel); 
            }

            return View(listIssues);
        }
    }
}
