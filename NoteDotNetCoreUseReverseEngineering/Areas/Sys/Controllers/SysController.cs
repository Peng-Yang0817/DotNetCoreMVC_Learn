using Microsoft.AspNetCore.Mvc;
using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;
using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Views;

using NoteDotNetCoreUseReverseEngineering.Models.MD5Service;

namespace NoteDotNetCoreUseReverseEngineering.Areas.Sys.Controllers
{
    public class SysController : Controller
    {
        // 建立 TQLDBTablesContext 和 TQLDBViewsContext 的私有變數
        private readonly TQLDBTablesContext tableDb;
        private readonly TQLDBViewsContext viewDb;

        // 建構函式，接收 TQLDBTablesContext 和 TQLDBViewsContext 的實例
        public SysController(TQLDBTablesContext tableDb, TQLDBViewsContext viewDb)
        {
            // 將傳入的實例賦值給私有變數
            this.tableDb = tableDb;
            this.viewDb = viewDb;
        }

        public IActionResult _Login()
        {
            //var XDXD = Request.Headers["XDXD"];
            return View();
        }

        [HttpGet]
        public IActionResult RenderBody_LoginPage()
        {
            ViewBag.ErrorMsg = "";
            return View();
        }
        [HttpPost]
        public IActionResult RenderBody_LoginPage(string username, string password)
        {
            password = password.ToMD5();

            Auth001 user = tableDb.Auth001s.FirstOrDefault(x => x.Username == username && x.Password == password);
            // 用戶資料未找到匹配
            if (user != null)
            {
                HttpContext.Session.SetString("Auth001Id", user.Id.ToString());
                return RedirectToAction("Index", "Home", new { Area = ""});
            }
            Auth001 auth001 = new Auth001() { Username = username };

            ViewBag.ErrorMsg = "用戶資訊錯誤!";
            return View(auth001);
        }

        [HttpGet]
        public IActionResult UserLogout()
        {
            // 清空Session
            HttpContext.Session.Clear();

            return RedirectToAction("RenderBody_LoginPage", "Sys", new { Area = "Sys" });
        }


        [HttpGet]
        public IActionResult RenderBody_RegistrationPage()
        {
            return View();
        }
    }
}
