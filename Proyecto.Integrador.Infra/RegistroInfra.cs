using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proyecto.Integrador.Aplicacions.Contratos.Repositorio;
using Proyecto.Integrador.Aplicacions.Contratos.Servicio;
using Proyecto.Integrador.Infra.Implementacion.Repositorio;
using Proyecto.Integrador.Infra.Implementacion.Servicio;
using Proyecto.Integrador.Infra.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Infra
{
    public static class RegistroInfra
    {
        public static IServiceCollection AddRegistroInfraestructura(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TiendaMIaDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ConnectionString"),
                  b => b.MigrationsAssembly("Proyecto.Integrador.Web"))
            );


            services.AddDbContext<IdentityDbContextTienda>(options =>
         options.UseSqlServer(configuration.GetConnectionString("ConnectionString"),
              b =>  b.MigrationsAssembly("Proyecto.Integrador.Web"))
         );


            services.AddScoped(typeof(IRepositorioBase<>), typeof(BaseRepositorio<>));
            services.AddScoped(typeof(IServicioBase<>), typeof(BaseServicio<>));
            services.AddScoped<IServicioCategoria,ServicioCategoria>();
            services.AddScoped<IServicioProductos, ServiciosProductos>();
            return services;
        }
    }
}
