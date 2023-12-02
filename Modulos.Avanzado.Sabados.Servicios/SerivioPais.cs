using Modulos.Avanzado.Sabados.Dominio;
using Modulos.Avanzado.Sabados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Servicios
{
    public class SerivioPais : IServicioPais
    {

        IAsyncBaseRepositorio<Pais> asyncBaseRepositorio { get; set; }

        public SerivioPais(IAsyncBaseRepositorio<Pais> asyncBaseRepositorio)
        {
            this.asyncBaseRepositorio = asyncBaseRepositorio;
        }
        public async Task<IEnumerable<Pais>> getAll()
        {
           return await this.asyncBaseRepositorio.GetAll();
        }
    }
}
