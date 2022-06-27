using DZDFreeTim.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DZDFreeTim.Web.Mvc.Controllers
{
    public class ITSMController : Controller
    {
        [HttpGet]
        public IActionResult ITSM()
        {
            var data = TempData["resourcedata"];
            string converted = (string)data;
            ResourceViewModel model = JsonConvert.DeserializeObject<ResourceViewModel>(converted);
            TempData["resourcedata"] = JsonConvert.SerializeObject(model);
            var listITSMs = new List<ITSMDetailModel>();
            listITSMs = model.ITSMs;

            return View(listITSMs);
        }
    }
}
