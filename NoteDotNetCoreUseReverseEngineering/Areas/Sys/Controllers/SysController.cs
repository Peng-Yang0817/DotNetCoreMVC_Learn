using Microsoft.AspNetCore.Mvc;
using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

namespace NoteDotNetCoreUseReverseEngineering.Areas.Sys.Controllers
{
    public class SysController : Controller
    {
        public IActionResult _Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult _Login(Auth001 data)
        {
            return View();
        }

        [HttpGet]
        public IActionResult RenderBody_LoginPage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RenderBody_RegistrationPage()
        {
            return View();
        }
    }
}
