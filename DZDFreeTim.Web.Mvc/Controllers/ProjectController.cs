using Microsoft.AspNetCore.Mvc;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Projects()
        {
            return View();
        }
    }
}
