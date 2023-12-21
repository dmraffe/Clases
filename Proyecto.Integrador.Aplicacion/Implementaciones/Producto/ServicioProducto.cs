using Proyecto.Integrador.Aplicacion.Contratos.Repositorio;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;
using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion.Implementaciones.Producto
{
    public class ServicioProducto : IServicioProductos
    {

        IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.Producto> baseRepositorio;

        public ServicioProducto(IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.Producto> baseRepositorio)
        {
            this.baseRepositorio = baseRepositorio;
        }

        public async Task<Modelos.Tablas.Producto> ObtenerProductoPorID(int Id)
        {
           return await this.baseRepositorio.GetByIdAsync(Id);  
        }

        public async Task<List<Modelos.Tablas.Producto>> ObtenerProductosCategoria(int categoria)
        {
            var  result =  await this.baseRepositorio.GetAsync(a=>a.CategoriaID == categoria);

            return result.ToList();
        }

        public async Task<List<Modelos.Tablas.Producto>> ObtenerProductosPrincipales()
        {
            var result = await this.baseRepositorio.GetAsync(a => a.EsPrimario);

            return result.ToList();
        }

        public async Task<List<Modelos.Tablas.Producto>> ProductosMasVendidos()
        {
            var result = await this.baseRepositorio.GetAllAsync();

            return result.Take(12).ToList();
        }

        public async Task<List<Modelos.Tablas.Producto>> ProductosNuevos()
        {
            var result = await this.baseRepositorio.GetAsync(a => a.EsNuevo);

            return result.Take(12).ToList();
        }

        public  async Task<List<Modelos.Tablas.Producto>> ProductosTops()
        {
            var result = await this.baseRepositorio.GetAllAsync();

            return result.OrderBy(a=>a.rate).Take(10).ToList();
        }                                   
    }
}
