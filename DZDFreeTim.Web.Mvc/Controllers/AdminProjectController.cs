using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class AdminProjectController : Controller
    {
        [Authorize(Roles = "editor,project_admin")]
        public IActionResult ProjectIndex()
        {
            return View();
        }
    }
}
