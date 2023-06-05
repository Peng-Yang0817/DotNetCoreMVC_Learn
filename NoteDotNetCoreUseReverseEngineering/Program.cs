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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
