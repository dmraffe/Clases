using MVC.MIR.VIER.Contratos;
using MVC.MIR.VIER.Implementacion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IAdministradorArchivo, AdministradorArchivo>();
var app = builder.Build();



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
    pattern: "{controller}/{action}/{id?}");


app.MapControllerRoute(
 name: "someRoute",
 pattern:"{controller}/{action}/{format}/{id?}",
 defaults: new
 {
     controller = "EjemploRazor",
     action = "Index"
 });





app.Run();
