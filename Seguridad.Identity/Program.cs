using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seguridad.Identity.DbContext;
using Seguridad.Identity.Models;
using Seguridad.Identity.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IdentityDbContextSabado>(options =>

                options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Database=EntityAvanzadoSabados;Trusted_Connection=True;TrustServerCertificate=True;",
                 b => b.MigrationsAssembly(typeof(IdentityDbContextSabado).Assembly.FullName)
                ));
builder.Services.AddIdentity<Usuario, IdentityRole>().AddEntityFrameworkStores<IdentityDbContextSabado>();

builder.Services.AddScoped<IAuthServices , AuthServices>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=login}/{id?}");

app.Run();
