using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;
using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Views;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 添加 DbContext TQLDBTablesContext 到服務容器中，以便連接到資料庫的檢視
builder.Services.AddDbContext<TQLDBTablesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TQLDBConnection")));

// 添加 DbContext TQLDBViewsContext 到服務容器中，以便連接到資料庫的檢視
builder.Services.AddDbContext<TQLDBViewsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TQLDBConnection")));

// 添加控制器與視圖的服務
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 設定 HTTP 請求管道
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
/*
    這個路由設置名為 "areaRoute"，它指定了一個較為特殊的路由模式，用於處理區域（Area）的路由。
    它的模式是 {area}/{controller=Home}/{action=Index}/{id?}，其中：
        {area} 表示區域的名稱，例如 Admin 或 Blog。它用於指定所在的區域。
        {controller=Home} 表示控制器的名稱，如果未提供，則預設為 Home 控制器。
        {action=Index} 表示動作的名稱，如果未提供，則預設為 Index 動作。
        {id?} 表示可選的 ID 參數，可以在路由中傳遞。
    這個路由模式用於處理位於區域內的控制器和動作。例如，如果有一個名為 Admin 的區域，其中有一個控制器 UserController，
    並且有一個 Details 動作，則該路由模式可以處理類似 /Admin/User/Details/1 的請求。
 */
app.MapControllerRoute(
    name: "areaRoute",
    pattern: "{area}/{controller=Home}/{action=Index}/{id?}");

/*
    這個路由設置名為 "default"，它指定了一個預設的路由模式，用於處理一般的控制器和動作。
    它的模式是 {controller=Home}/{action=Index}/{id?}，其中：
        {controller=Home} 表示控制器的名稱，如果未提供，則預設為 Home 控制器。
        {action=Index} 表示動作的名稱，如果未提供，則預設為 Index 動作。
        {id?} 表示可選的 ID 參數，可以在路由中傳遞。
    這個路由模式用於處理不位於區域內的控制器和動作。例如，如果沒有區域指定，並且直接訪問應用程序的根 URL（例如 /），
    則該路由模式可以處理該請求，將其路由到 Home 控制器的 Index 動作。
 */

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
