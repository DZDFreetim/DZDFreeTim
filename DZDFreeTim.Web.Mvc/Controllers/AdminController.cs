using DZDFreeTim.Data.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles = "editor,project")]
        public IActionResult AddProject()
        {
            return View();
        }

        [Authorize(Roles = "editor,ITSM")]
        public IActionResult AddITSM()
        {
            return View();
        }
    }
}
