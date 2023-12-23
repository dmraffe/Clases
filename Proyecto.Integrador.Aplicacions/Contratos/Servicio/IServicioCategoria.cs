using Proyecto.Integrador.Modelo.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacions.Contratos.Servicio
{
    public interface IServicioCategoria
    {

        Task<IReadOnlyCollection<Categoria>> GetCategoriasyProductos();

    }
}
