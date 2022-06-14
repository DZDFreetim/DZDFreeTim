using Microsoft.AspNetCore.Mvc;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult ChangePassword()  // Layou henüz hazırlanmadı 
        {
            return View();
        }
        public IActionResult MyAccount()
        {
            return View();
        }


    }
}
