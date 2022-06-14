using Microsoft.AspNetCore.Mvc;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Developer()
        {
            return View();
        }

        public IActionResult Analist()
        {
            return View();
        }

        public IActionResult SuperUser()
        {
            return View();
        }
    }
}
