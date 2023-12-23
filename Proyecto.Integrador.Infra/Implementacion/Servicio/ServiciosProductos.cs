using Proyecto.Integrador.Aplicacions.Contratos.Repositorio;
using Proyecto.Integrador.Aplicacions.Contratos.Servicio;
using Proyecto.Integrador.Modelo.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Infra.Implementacion.Servicio
{
    public class ServiciosProductos : BaseServicio<Producto>, IServicioProductos
    {

        IRepositorioBase<Producto> repositorioBase = null;
        public ServiciosProductos(IRepositorioBase<Producto> _repositorioBase) : base(_repositorioBase)
        {
            repositorioBase = _repositorioBase;
        }

        public Task<IReadOnlyCollection<Producto>> GetProductosMasVendidos()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Producto>> GetProductosMejorRate()
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyCollection<Producto>> GetProductosNuevos()
        {
            var ret = await repositorioBase.GetAsync(a=>a.EsNuevo);

            return ret.Take(8).ToList();
        }
    }
}
