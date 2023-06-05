using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;
using NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Views;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// �K�[ DbContext TQLDBTablesContext ��A�Ȯe�����A�H�K�s�����Ʈw���˵�
builder.Services.AddDbContext<TQLDBTablesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TQLDBConnection")));

// �K�[ DbContext TQLDBViewsContext ��A�Ȯe�����A�H�K�s�����Ʈw���˵�
builder.Services.AddDbContext<TQLDBViewsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TQLDBConnection")));

// �K�[����P���Ϫ��A��
builder.Services.AddControllersWithViews();

var app = builder.Build();

// �]�w HTTP �ШD�޹D
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
