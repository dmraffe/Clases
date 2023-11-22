using MVC.Contratos;
using MVC.Implementacion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IRepositorioArchivo, RepositorioArchivo>();
var app = builder.Build();

var path = Directory.GetCurrentDirectory();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Razor}/{action=Index}/{id?}");

app.Run();
