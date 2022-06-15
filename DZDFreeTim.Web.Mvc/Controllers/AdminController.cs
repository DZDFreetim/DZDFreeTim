using DZDFreeTim.Data.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles = "editor,project_admin")]
        public IActionResult AddProject()
        {
            return View();
        }

        [Authorize(Roles = "editor,itsm_admin")]
        public IActionResult AddITSM()
        {
            return View();
        }
    }
}
