using Microsoft.AspNetCore.Mvc;
using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

// Update資料會用到的包
using Microsoft.EntityFrameworkCore;


namespace NoteDotNetCoreUseReverseEngineering.Areas.Auth.Controllers
{
    public class Auth001Controller : Controller
    {
        // 初始化DbContext
        private readonly TQLDBTablesContext dbTable;
        public Auth001Controller(TQLDBTablesContext dbTable)
        {
            this.dbTable = dbTable;
        }

        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 移除用戶區域
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Auth001Delect()
        {
            ViewBag.UserName = "";
            return View();
        }

        [HttpPost]
        public IActionResult Auth001Delect(string UserName)
        {
            List<Auth001> targetDataList_auth001 = dbTable.Auth001s.Where(x => x.Username == UserName).ToList();

            // 符合
            if (!(targetDataList_auth001.Count == 0 ||
                targetDataList_auth001.Count > 1))
            {
                Auth001 targetData_auth001 = targetDataList_auth001[0];
                dbTable.Auth001s.Remove(targetData_auth001);
                dbTable.SaveChanges();

                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewBag.UserName = UserName;
            return View();
        }
        /// <summary>
        /// 用戶更新密碼區
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Auth001UpdatePassword()
        {
            ViewBag.UserName = "";
            ViewBag.password_old = "";
            ViewBag.password_new = "";
            ViewBag.Email = "";
            ViewBag.ErroorMassages = new List<string>();

            return View();
        }

        [HttpPost]
        public IActionResult Auth001UpdatePassword(string UserName, string Email, string password_old, string password_new)
        {
            List<Auth001> targetDataList_auth001 = dbTable.Auth001s.Where(x => x.Username == UserName &&
                                                                                x.Email == Email &&
                                                                                x.Password == password_old).ToList();
            // 符合
            if (targetDataList_auth001.Count == 1)
            {
                Auth001 target_auth001 = targetDataList_auth001[0];
                target_auth001.Password = password_new;
                dbTable.Entry(target_auth001).State = EntityState.Modified;
                dbTable.SaveChanges();
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            List<string> ErroorMassages = new List<string>();
            // 不符合
            if (targetDataList_auth001.Count == 0)
            {
                ErroorMassages.Add("查無用戶資料");
            }
            if (targetDataList_auth001.Count > 1)
            {
                ErroorMassages.Add("系統問題! 多使用者狀況! 請聯繫系統管理者。");
            }
            ViewBag.UserName = UserName;
            ViewBag.password_old = password_old;
            ViewBag.password_new = password_new;
            ViewBag.Email = Email;
            ViewBag.ErroorMassages = ErroorMassages;
            return View();
        }

        /// <summary>
        /// 新增用戶區域
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Auth001Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Auth001Create(Auth001 get_Auth001)
        {
            // Model is valid
            if (ModelState.IsValid)
            {
                dbTable.Add(get_Auth001);
                dbTable.SaveChanges();

                // return RedirectToAction("Index", "Home", new { area = "AnotherArea", a = a });
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            // Model is not valid
            return View(get_Auth001);
        }
    }
}
