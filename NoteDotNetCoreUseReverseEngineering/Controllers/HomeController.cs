using Microsoft.AspNetCore.Mvc;
using NoteDotNetCoreUseReverseEngineering.Models;
using System.Diagnostics;

// 引入模型的命名空間
using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;
using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Views;


namespace NoteDotNetCoreUseReverseEngineering.Controllers
{
    public class HomeController : Controller
    {
        // 建立 TQLDBTablesContext 和 TQLDBViewsContext 的私有變數
        private readonly TQLDBTablesContext tableDb;
        private readonly TQLDBViewsContext viewDb;

        // 建構函式，接收 TQLDBTablesContext 和 TQLDBViewsContext 的實例
        public HomeController(TQLDBTablesContext tableDb, TQLDBViewsContext viewDb)
        {
            // 將傳入的實例賦值給私有變數
            this.tableDb = tableDb;
            this.viewDb = viewDb;
        }

        public IActionResult Index()
        {
            // 使用 tableDb 從資料庫中取得 Auth001s 資料表的所有記錄，轉換為 List<Auth001>
            List<Auth001> dataList_auth001 = tableDb.Auth001s.ToList();

            // 使用 viewDb 從資料庫中取得 ViewOneNformCaseNameLists 檢視的所有記錄，轉換為 List<ViewOneNformCaseNameList>
            List<ViewOneNformCaseNameList> dataList_viewOneNformCaseNameList = viewDb.ViewOneNformCaseNameLists.ToList();

            // 傳遞空的模型物件到視圖
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}