using Microsoft.AspNetCore.Mvc;

namespace NoteDotNetCoreUseReverseEngineering.Areas.Auth.Controllers
{
    public class Auth001Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
