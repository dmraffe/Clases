using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
                 b => b.MigrationsAssembly("Proyecto.Integrador.Infra"))


            );
           // services.AddScoped(typeof(IBaseRepositorioAsync<>), typeof(BaseRepositorio<>));

            return services;
        }
    }
}
