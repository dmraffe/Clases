using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion.Contratos.Servicios
{
    public interface IservicioCategoria
    {

        public Task<List<Categoria>> ObtenerTodo();
    }
}
