using Modulos.Avanzado.Sabados.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Servicios
{
    public interface IServicioPais
    {

        public Task<IEnumerable<Pais>> getAll();
    }
}
