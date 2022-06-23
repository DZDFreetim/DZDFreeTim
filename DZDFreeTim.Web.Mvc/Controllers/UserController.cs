using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class UserController : Controller
    {
        [Authorize(Roles = "developer")]
        public IActionResult Developer()
        {
            return View();

        }

        [Authorize(Roles = "analyst")]
        public IActionResult Analist()
        {
            return View();

        }

        [Authorize(Roles = "superuser")]      
        public IActionResult SuperUser()
        {
            return View();


        }
    }
}
