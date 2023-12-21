using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proyecto.Integrador.Aplicacion.Contratos.Repositorio;
using Proyecto.Integrador.Infraestructura.Persistencia;
using Proyecto.Integrador.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Infraestructura
{
    public static class RegistroInfraestructura
    {

        public static IServiceCollection AddRegistroInfraestructura(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProyectoIntegradorDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ConnectionString"),
                 b => b.MigrationsAssembly("Proyecto.Integrador"))
            
            
            );
            services.AddScoped(typeof(IBaseRepositorioAsync<>), typeof(BaseRepositorio<>));

            return services;
        }
    }
}
