using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Seguridad.MVC.DbContextSeguridad;
using Seguridad.MVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DbContextApp>(options =>

                options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Database=EntityAvanzadoSeguridad;Trusted_Connection=True;TrustServerCertificate=True;",
                 b => b.MigrationsAssembly(typeof(DbContextApp).Assembly.FullName)
                ));

builder.Services.AddDbContext<ContextIdentit>(options =>

                options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Database=EntityAvanzadoSeguridad;Trusted_Connection=True;TrustServerCertificate=True;",
                 b => b.MigrationsAssembly(typeof(ContextIdentit).Assembly.FullName)
                ));

 builder.Services.AddIdentity<Usuario, IdentityRole>().AddEntityFrameworkStores<ContextIdentit>();


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
    pattern: "{controller=Auth}/{action=Registro}/{id?}");

app.Run();
