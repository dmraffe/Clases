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
    public class ServicioCategoria : BaseServicio<Categoria>, IServicioCategoria
    {

        IRepositorioBase<Categoria> repositorioBase = null;

        public ServicioCategoria(IRepositorioBase<Categoria> repositorioBase) : base(repositorioBase)  
        {
            this.repositorioBase = repositorioBase;
        }

        public async Task<IReadOnlyCollection<Categoria>> GetCategoriasyProductos()
        {
            var ret = await repositorioBase.GetAsync(includeString : "Productos");

            return ret;
        }
    }
}
