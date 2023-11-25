using Modulos.Avanzado.Sabados.Dominio;
using Modulos.Avanzado.Sabados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Servicios
{
    public class ServicioCLiente : IServicioCliente
    {
        IAsyncBaseRepositorio<Cliente>  asyncBaseRepositorio { get; set; }

        public ServicioCLiente(IAsyncBaseRepositorio<Cliente> asyncBaseRepositorio)
        {
            this.asyncBaseRepositorio = asyncBaseRepositorio;
        }

        public async Task<bool> AddCliente(Cliente cliente)
        {
            var list = await this.asyncBaseRepositorio.GetAll(x => x.Correo == cliente.Correo);

            if (list.Any())
                return false;
            return await asyncBaseRepositorio.Add(cliente);
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await asyncBaseRepositorio.GetAll();
        }

        public async Task<Cliente> GetCliente(int Id)
        {
            return await asyncBaseRepositorio.GetById(Id);
        }

        public async Task<bool> UpdateCliente(Cliente cliente)
        {
            return await asyncBaseRepositorio.Update(cliente);
        }

        public async Task<bool> DelteCliente(Cliente cliente)
        {
            return await asyncBaseRepositorio.Delete(cliente);
        }

        public async Task<Cliente> GetClienteyDirecciones(int Id)
        {
            return await asyncBaseRepositorio.GetById(Id,"Direcciones");
        }
    }
}
