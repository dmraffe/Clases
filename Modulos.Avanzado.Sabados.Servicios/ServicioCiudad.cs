using Modulos.Avanzado.Sabados.Dominio;
using Modulos.Avanzado.Sabados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Servicios
{
    public class ServicioCiudad : IServicioCiudadcs
    {
        IAsyncBaseRepositorio<Ciudad> asyncBaseRepositorio { get; set; }

        public ServicioCiudad(IAsyncBaseRepositorio<Ciudad> asyncBaseRepositorio)
        {
            this.asyncBaseRepositorio = asyncBaseRepositorio;
        }
        public async Task<IEnumerable<Ciudad>> getAllByPaisId(int PaisId)
        {
            return await this.asyncBaseRepositorio.GetAll(a=>a.PaisId == PaisId);
        }
    }
}
