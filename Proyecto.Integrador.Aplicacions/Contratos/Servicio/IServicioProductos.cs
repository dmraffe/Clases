using Proyecto.Integrador.Modelo.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacions.Contratos.Servicio
{
    public interface IServicioProductos
    {

        Task<IReadOnlyCollection<Producto>> GetProductosNuevos();
        Task<IReadOnlyCollection<Producto>> GetProductosMasVendidos();

        Task<IReadOnlyCollection<Producto>> GetProductosMejorRate();

    }
}
