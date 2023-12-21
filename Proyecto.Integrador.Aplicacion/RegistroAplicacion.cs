using Microsoft.Extensions.DependencyInjection;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;
using Proyecto.Integrador.Aplicacion.Implementaciones.Categoria;
using Proyecto.Integrador.Aplicacion.Implementaciones.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion
{
    public  static class RegistroAplicacion
    {
        public static IServiceCollection AddRegistroAplicacion(this IServiceCollection services)
        {
           
            services.AddScoped<IServicioProductos, ServicioProducto>();
            services.AddScoped<IservicioCategoria, ServicioCategoria>();
            return services;
        }
    }
}
