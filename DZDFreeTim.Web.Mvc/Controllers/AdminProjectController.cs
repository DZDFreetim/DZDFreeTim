using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DZDFreeTim.Data;
using DZDFreeTim.Business;
using System.Collections;
using System.Text;
using System.Dynamic;
using DZDFreeTim.Business.Concrete;
using DZDFreeTim.Web.Mvc.Models;
using DZDFreeTim.Data.Entity;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class AdminProjectController : Controller
    {
        ProjectManager projectm = new ProjectManager();
        EmployeeManager employeem = new EmployeeManager();
        IntertechTeamManager teamm = new IntertechTeamManager();
        DzdStatusManager dzdstatusm = new DzdStatusManager();
        BankManager bankm = new BankManager();



        [Authorize(Roles = "editor,project_admin")]
        public IActionResult ProjectIndex()

        {
            var projects = projectm.GetAll();
            var projectDetailList = new List<ProjectDetailModel>();
            foreach(var project in projects)
            {
                var projectDetail = new ProjectDetailModel
                {
                     BillYearQuarter = project.BillYearQuarter,
                     Effort=project.Effort,
                     InvNumber=project.InvNumber,
                     JiraTaskNo=project.JiraTaskNo,
                     JiraProjectNo=project.JiraProjectNo,
                     JiraStatus=project.JiraStatus,
                     Priority= project.Priority,
                     Notes= project.Notes,
                     ProjectId=project.ProjectId,
                     ProjectName=project.ProjectName,
                };

               
                if (project.AnalystId > 0)
                {
                    projectDetail.AnalystName = employeem.GetNameById(project.AnalystId);
                }
                if (project.DeveloperId > 0)
                {
                    projectDetail.DeveloperName = employeem.GetNameById(project.DeveloperId);
                }
                if (project.IntertechTeam > 0)
                {
                    projectDetail.IntertechTeamName = teamm.GetNameById(project.IntertechTeam);
                }
                if (project.DzdStatus > 0)
                {
                    projectDetail.DzdStatusName = dzdstatusm.GetNameById(project.DzdStatus);
                }
                if (project.BankId > 0)
                {
                    projectDetail.BankName = bankm.GetNameById(project.BankId);
                }
    
                projectDetailList.Add(projectDetail);
            }

            return View(projectDetailList);
        }

        [HttpGet]
        


        public IActionResult AddProject()
        {
            return View();
        }


        public IActionResult AddNewProject(Project project)
        {
            projectm.AddNewProject(project);
            return RedirectToAction("ProjectIndex");

        }


    }
}
