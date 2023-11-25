using Modulos.Avanzado.Sabados.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Servicios
{
    public interface IServiceDirecciones
    {
        public Task<bool> Add(Direccion dr);

        public Task<bool> Update (Direccion dr);

        public Task<bool> Delete(Direccion dr);

        public Task<IEnumerable<Direccion>> GetByCliente(int idcliente);
        public Task<Direccion> GetById(int id);
        public Task<Direccion> GetById(int id,string dependencia);

        public Task<IEnumerable<Direccion>> GetAll();

    }
}
