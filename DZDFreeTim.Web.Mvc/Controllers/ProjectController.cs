using DZDFreeTim.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult Projects()
        {
            var data = TempData["resourcedata"];
            string converted = (string)data;
            ResourceViewModel model = JsonConvert.DeserializeObject<ResourceViewModel>(converted);
            TempData["resourcedata"] = JsonConvert.SerializeObject(model);
            var listProjects = new List<ProjectDetailModel>();
            listProjects = model.Projects;
            foreach(var project in listProjects)
            {
                Console.WriteLine(project.DzdStatusName);
            }
            
            return View(listProjects);
        }
    }
}
