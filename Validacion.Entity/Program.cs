using Microsoft.EntityFrameworkCore;
using Validacion.Entity.BasedeDatos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EntityTestDbContext>(options
=> options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Database=EntityExamples;Trusted_Connection=True;TrustServerCertificate=True;"));

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
    pattern: "{controller=Persona}/{action=index}/{id?}");

app.Run();
