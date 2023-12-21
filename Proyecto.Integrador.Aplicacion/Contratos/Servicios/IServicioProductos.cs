using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion.Contratos.Servicios
{
    public interface IServicioProductos
    {

        public Task<List<Producto>> ObtenerProductosPrincipales();

        public Task<List<Producto>> ObtenerProductosCategoria(int categoria);

        public Task<Producto> ObtenerProductoPorID(int Id);


        public Task<List<Producto>> ProductosNuevos();

        public Task<List<Producto>> ProductosTops();

        public Task<List<Producto>> ProductosMasVendidos();
    }
}
