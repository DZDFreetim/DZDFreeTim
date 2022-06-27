using DZDFreeTim.Data;
using DZDFreeTim.Web.Mvc.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class AuthController : Controller
    {
        public AppDbContext Db { get; }
        public AuthController(AppDbContext db)
        {
            Db = db;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            
            if (ModelState.IsValid)
            {
                var user = Db.Employees.FirstOrDefault(e =>
                    (e.Email== model.Email.Trim())  &&
                    e.Password == model.Password.Trim() &&
                    e.IsActive == true
                );

                if (user != null)
                {
                    // Kimlik Bilgileri
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Email),
                        new Claim(ClaimTypes.Name, user.Name),                       
                        new Claim(ClaimTypes.Name, user.EmployeeID.ToString()),
                        new Claim(ClaimTypes.Role, user.EmployeeType)
                    };
                    
                    if (!string.IsNullOrEmpty(user.EmployeeType))
                    {
                        string[] roles = user.EmployeeType.Split(";");
                        foreach (var role in roles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role));
                        }
                    }

                    // Kimlik
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Cüzdan
                    var claimsPrinciple = new ClaimsPrincipal(claimsIdentity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = model.RememberMe,
                        ExpiresUtc = DateTime.UtcNow.AddDays(1)
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrinciple, properties);

                    LoginViewModel data = new LoginViewModel()
                    {
                        Email = model.Email,
                        Password = model.Password
                    };
                    TempData["mydata"] = JsonConvert.SerializeObject(model); 
                    //ViewData["mydata"] = JsonConvert.SerializeObject(model);

                    if (user.EmployeeType == "analyst")
                        return RedirectToAction("Analist", "User");
                    else if (user.EmployeeType == "developer")
                        return RedirectToAction("Developer", "User");
                    else if (user.EmployeeType == "project_admin")
                        return RedirectToAction("ProjectIndex","AdminProject");
                    else if (user.EmployeeType == "itsm_admin")
                        return RedirectToAction("ITSMIndex", "AdminITSM");
                    //return Redirect(returnUrl != null ? returnUrl : "/");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Mail adresi ya da şifre hatalı!");
                }
            }
            

            return View();
        }



        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index","Login");
        }

        public IActionResult AccessDenied()
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
