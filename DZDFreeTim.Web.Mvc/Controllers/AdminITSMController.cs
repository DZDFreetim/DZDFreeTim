using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class AdminITSMController : Controller
    {
        [Authorize(Roles = "editor,itsm_admin")]
        public IActionResult ITSMIndex()
        {
            return View();
        }
    }
}
