using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DZDFreeTim.Business.Concrete;
using DZDFreeTim.Web.Mvc.Models;
using Newtonsoft.Json;
using System.Collections;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class UserController : Controller
    {
        EmployeeManager emp = new EmployeeManager();

        [Authorize(Roles = "developer")]
        public IActionResult Developer()
        {

            var data = TempData["mydata"];
            string converted = (string)data;
            LoginViewModel model = JsonConvert.DeserializeObject<LoginViewModel>(converted);



            var employees = emp.GetAll();
            int ID = 0;

            foreach (var e in employees)
            {
                if (e.Email == model.Email)
                {
                    ID = e.EmployeeID;
                    break;
                }
            }


            ResourceViewModel resource = new ResourceViewModel();

            resource.ProjectBonus = emp.CalculateBonusForProjects(ID, 10);
            resource.ITSMBonus = emp.CalculateBonusForITSMs(ID, 10);
            resource.TotalBonus = emp.CalculateBonusForProjects(ID, 10) + emp.CalculateBonusForITSMs(ID, 10);


            resource.OpenProjects = emp.projects.Count;
            resource.OpenITSMs = emp.ITSMs.Count;
            resource.OpenAll = emp.projects.Count + emp.ITSMs.Count;

            resource.Name = emp.GetEmployeeById(ID).Name;

            resource.ProjectQuarters = emp.quarterProjectBonus;
            resource.ITSMQuarters = emp.quarterITSMBonus;

            EmployeeManager employeeManager = new EmployeeManager();
            BankManager bank = new BankManager();
            ProjectManager project = new ProjectManager();
            DzdStatusManager dzdStatusManager = new DzdStatusManager();
            IntertechTeamManager intertech = new IntertechTeamManager();
            ITSMManager itsmm = new ITSMManager();
            IssueTypeManager issuetypem = new IssueTypeManager();
            IssueStatusManager issuestatusm = new IssueStatusManager();
            ResolutionManager resolutionm = new ResolutionManager();

            List<ProjectDetailModel> projects = new List<ProjectDetailModel>();
            List<ITSMDetailModel> ITSMs = new List<ITSMDetailModel>();

            foreach (var e in emp.projects)
            {
                // resource projeleri güncellenecek! Sonra project controllerde kullanılacak!
                ProjectDetailModel prj = new ProjectDetailModel();
                prj.JiraStatus = e.JiraStatus;
                prj.JiraProjectNo = e.JiraProjectNo;
                prj.JiraTaskNo = e.JiraTaskNo;
                prj.ProjectId = e.ProjectId;
                prj.ProjectName = project.GetNameById(e.ProjectId);
                prj.Notes = e.Notes;
                prj.DzdStatusName = dzdStatusManager.GetNameById(e.DzdStatus);
                prj.BankName = bank.GetNameById(e.BankId);
                prj.InvNumber = e.InvNumber;
                prj.BillYearQuarter = e.BillYearQuarter;
                prj.Effort = e.Effort;
                prj.AnalystName = employeeManager.GetNameById(e.AnalystId);
                prj.DeveloperName = employeeManager.GetNameById(e.DeveloperId);
                prj.Priority = e.Priority;
                prj.IntertechTeamName = intertech.GetNameById(e.IntertechTeam);
                projects.Add(prj);
            }
            resource.Projects = projects;
            
            foreach (var e in emp.ITSMs)
            {
                ITSMDetailModel itsm = new ITSMDetailModel();
                itsm.Summary = e.Summary;
                itsm.StatusName = issuestatusm.GetNameById(e.Status);
                itsm.IssueId = e.IssueId;
                itsm.IssueName = itsmm.GetNameById(e.IssueId);
                itsm.ReporterName = employeeManager.GetNameById(e.ReporterId);
                itsm.Priority = e.Priority;
                itsm.AssigneeMail = employeeManager.GetEmailById(e.AssigneeId);
                itsm.CompanyName = bank.GetNameById(e.CompanyId);
                itsm.Created = e.Created;
                itsm.Resolved = e.Resolved;
                itsm.IssueTypeName = issuetypem.GetNameById(e.IssueId);
                itsm.ResolutionName = resolutionm.GetNameById(e.Resolution);
                ITSMs.Add(itsm);
            }
            resource.ITSMs = ITSMs;

            ResourceViewModel data2 = new ResourceViewModel();
            data2 = resource;
            TempData["resourcedata"] = JsonConvert.SerializeObject(data2);
            TempData["mydata"] = JsonConvert.SerializeObject(model);
            return View(resource);

        }

        [Authorize(Roles = "analyst")]
        public IActionResult Analist()
        {
            var data = TempData["mydata"];
            string converted = (string)data;
            LoginViewModel model = JsonConvert.DeserializeObject<LoginViewModel>(converted);
            var employees = emp.GetAll();
            int ID = 0;

            foreach (var e in employees)
            {
                if (e.Email == model.Email)
                {
                    ID = e.EmployeeID;
                    break;
                }
            }

            ResourceViewModel resource = new ResourceViewModel();

            resource.ProjectBonus = emp.CalculateBonusForProjects(ID, 10);
            resource.ITSMBonus = emp.CalculateBonusForITSMs(ID, 10);
            resource.TotalBonus = emp.CalculateBonusForProjects(ID, 10) + emp.CalculateBonusForITSMs(ID, 10);

            resource.OpenProjects = emp.projects.Count;
            resource.OpenITSMs = emp.ITSMs.Count;
            resource.OpenAll = emp.projects.Count + emp.ITSMs.Count;

            resource.Name = emp.GetEmployeeById(ID).Name;

            resource.ProjectQuarters = emp.quarterProjectBonus;
            resource.ITSMQuarters = emp.quarterITSMBonus;

            EmployeeManager employeeManager = new EmployeeManager();
            BankManager bank = new BankManager();
            ProjectManager project = new ProjectManager();
            DzdStatusManager dzdStatusManager = new DzdStatusManager();
            IntertechTeamManager intertech = new IntertechTeamManager();
            ITSMManager itsmm = new ITSMManager();
            IssueTypeManager issuetypem = new IssueTypeManager();
            IssueStatusManager issuestatusm = new IssueStatusManager();
            ResolutionManager resolutionm = new ResolutionManager();

            List<ProjectDetailModel> projects = new List<ProjectDetailModel>();
            List<ITSMDetailModel> ITSMs = new List<ITSMDetailModel>();

            foreach (var e in emp.projects)
            {
                // resource projeleri güncellenecek! Sonra project controllerde kullanılacak!
                ProjectDetailModel prj = new ProjectDetailModel();
                prj.JiraStatus = e.JiraStatus;
                prj.JiraProjectNo = e.JiraProjectNo;
                prj.JiraTaskNo = e.JiraTaskNo;
                prj.ProjectId = e.ProjectId;
                prj.ProjectName = project.GetNameById(e.ProjectId);
                prj.Notes = e.Notes;
                prj.DzdStatusName = dzdStatusManager.GetNameById(e.DzdStatus);
                prj.BankName = bank.GetNameById(e.BankId);
                prj.InvNumber = e.InvNumber;
                prj.BillYearQuarter = e.BillYearQuarter;
                prj.Effort = e.Effort;
                prj.AnalystName = employeeManager.GetNameById(e.AnalystId);
                prj.DeveloperName = employeeManager.GetNameById(e.DeveloperId);
                prj.Priority = e.Priority;
                prj.IntertechTeamName = intertech.GetNameById(e.IntertechTeam);
                projects.Add(prj);
            }
            resource.Projects = projects;
            foreach (var e in emp.ITSMs)
            {
                ITSMDetailModel itsm = new ITSMDetailModel();
                itsm.Summary = e.Summary;
                itsm.StatusName = issuestatusm.GetNameById(e.Status);
                itsm.IssueId = e.IssueId;
                itsm.IssueName = itsmm.GetNameById(e.IssueId);
                itsm.ReporterName = employeeManager.GetNameById(e.ReporterId);
                itsm.Priority = e.Priority;
                itsm.AssigneeMail = employeeManager.GetEmailById(e.AssigneeId);
                itsm.CompanyName = bank.GetNameById(e.CompanyId);
                itsm.Created = e.Created;
                itsm.Resolved = e.Resolved;
                itsm.IssueTypeName = issuetypem.GetNameById(e.IssueId);
                itsm.ResolutionName = resolutionm.GetNameById(e.Resolution);
                ITSMs.Add(itsm);
            }
            resource.ITSMs = ITSMs;

            ResourceViewModel data2 = new ResourceViewModel();
            data2 = resource;
            TempData["resourcedata"] = JsonConvert.SerializeObject(data2);
            TempData["mydata"] = JsonConvert.SerializeObject(model);


            return View(resource);
        }

        [Authorize(Roles = "superuser")]
        public IActionResult SuperUser()
        {
            return View();
        }
    }
}
