using EntityAvansado.Repositorio.Implementacion;
using EntityAvansado.Repositorio.Interfaces;
using EntityAvanzado;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddLogging(a => a.AddConsole().AddDebug());

builder.Services.AddDbContext<EntityAvanzadoDBContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"))
    );
builder.Services.AddScoped(typeof(IBaseRepositorio<>), typeof(BaseRepositorio<>));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
else
{
    app.UseExceptionHandler("/Home/Error"); //app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

 



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
