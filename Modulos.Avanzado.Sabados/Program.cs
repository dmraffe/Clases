using Microsoft.EntityFrameworkCore;
using Modulos.Avanzado.Sabados.Repositorio;
using Modulos.Avanzado.Sabados.Servicios;
using Modulos.Avanzados.Sabados.DB;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

 builder.Services.AddLogging(a=>a.AddConsole());

builder.Services.AddDbContext<ModulosAvanzadoDBContext>(opt =>

   opt.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"))

    );

builder.Services.AddScoped(typeof(IAsyncBaseRepositorio<>), typeof(BaseRepositorio<>));
builder.Services.AddScoped<IServicioCliente, ServicioCLiente>();
builder.Services.AddScoped<IServiceDirecciones, ServicioDireccion>();
builder.Services.AddScoped<IServicioPais, SerivioPais>();
builder.Services.AddScoped<IServicioCiudadcs, ServicioCiudad>();
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
    pattern: "{controller=Cliente}/{action=Index}/{id?}");

app.Run();
