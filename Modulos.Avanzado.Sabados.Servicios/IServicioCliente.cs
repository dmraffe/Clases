using Modulos.Avanzado.Sabados.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Servicios
{
    public interface IServicioCliente
    {
        public Task<bool> AddCliente(Cliente cliente);
        public Task<bool> UpdateCliente(Cliente cliente);

        public Task<Cliente> GetCliente(int Id);

        public Task<Cliente> GetClienteyDirecciones(int Id);

        public Task<IEnumerable<Cliente>> GetAll();

        public Task<bool> DelteCliente(Cliente cliente);
    }
}
