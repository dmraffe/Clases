using Modulos.Avanzado.Sabados.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Servicios
{
    public interface IServicioCiudadcs
    {
        public Task<IEnumerable<Ciudad>> getAllByPaisId(int PaisId);
    }
}
