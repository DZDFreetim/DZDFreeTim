using Microsoft.AspNetCore.Mvc;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AddProject()
        {
            return View();
        }

        public IActionResult AddITSM()
        {
            return View();
        }
    }
}
