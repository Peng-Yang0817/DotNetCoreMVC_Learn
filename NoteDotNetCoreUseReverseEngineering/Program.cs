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

// �K�[Session���\��
builder.Services.AddDistributedMemoryCache(); /*IServices ���X�֦b builder.Build() ��Ƥ��e�K�[�H�U�N�X��G*/
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20); /*�]�wSession Timeout time*/
});


var app = builder.Build();

app.UseSession();

// �]�w HTTP �ШD�޹D
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
/*
    �o�Ӹ��ѳ]�m�W�� "areaRoute"�A�����w�F�@�Ӹ����S�����ѼҦ��A�Ω�B�z�ϰ�]Area�^�����ѡC
    �����Ҧ��O {area}/{controller=Home}/{action=Index}/{id?}�A�䤤�G
        {area} ��ܰϰ쪺�W�١A�Ҧp Admin �� Blog�C���Ω���w�Ҧb���ϰ�C
        {controller=Home} ��ܱ�����W�١A�p�G�����ѡA�h�w�]�� Home ����C
        {action=Index} ��ܰʧ@���W�١A�p�G�����ѡA�h�w�]�� Index �ʧ@�C
        {id?} ��ܥi�諸 ID �ѼơA�i�H�b���Ѥ��ǻ��C
    �o�Ӹ��ѼҦ��Ω�B�z���ϰ줺������M�ʧ@�C�Ҧp�A�p�G���@�ӦW�� Admin ���ϰ�A�䤤���@�ӱ�� UserController�A
    �åB���@�� Details �ʧ@�A�h�Ӹ��ѼҦ��i�H�B�z���� /Admin/User/Details/1 ���ШD�C
 */
app.MapControllerRoute(
    name: "areaRoute",
    pattern: "{area}/{controller=Home}/{action=Index}/{id?}");

/*
    �o�Ӹ��ѳ]�m�W�� "default"�A�����w�F�@�ӹw�]�����ѼҦ��A�Ω�B�z�@�몺����M�ʧ@�C
    �����Ҧ��O {controller=Home}/{action=Index}/{id?}�A�䤤�G
        {controller=Home} ��ܱ�����W�١A�p�G�����ѡA�h�w�]�� Home ����C
        {action=Index} ��ܰʧ@���W�١A�p�G�����ѡA�h�w�]�� Index �ʧ@�C
        {id?} ��ܥi�諸 ID �ѼơA�i�H�b���Ѥ��ǻ��C
    �o�Ӹ��ѼҦ��Ω�B�z�����ϰ줺������M�ʧ@�C�Ҧp�A�p�G�S���ϰ���w�A�åB�����X�����ε{�Ǫ��� URL�]�Ҧp /�^�A
    �h�Ӹ��ѼҦ��i�H�B�z�ӽШD�A�N����Ѩ� Home ����� Index �ʧ@�C
 */

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
