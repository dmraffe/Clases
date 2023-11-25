using Modulos.Avanzado.Sabados.Dominio;
using Modulos.Avanzado.Sabados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Servicios
{
    public class ServicioDireccion : IServiceDirecciones
    {

        IAsyncBaseRepositorio<Cliente> asyncBaseRepositorio { get; set; }

        IAsyncBaseRepositorio<Direccion> _asyncBaseRepositoriodireccion { get; set; }

        public ServicioDireccion(IAsyncBaseRepositorio<Cliente> asyncBaseRepositorio, IAsyncBaseRepositorio<Direccion> asyncBaseRepositorioDireccion)
        {
            this.asyncBaseRepositorio = asyncBaseRepositorio;
            this._asyncBaseRepositoriodireccion = asyncBaseRepositorioDireccion;
        }
        public async Task<bool> Add(Direccion dr)
        {
          return await  this._asyncBaseRepositoriodireccion.Add(dr);
        }

        public async Task<bool> Delete(Direccion dr)
        {
            return await this._asyncBaseRepositoriodireccion.Delete(dr);
        }

        public async Task<IEnumerable<Direccion>> GetAll()
        {
            return await this._asyncBaseRepositoriodireccion.GetAll();
        }

        public async Task<IEnumerable<Direccion>> GetByCliente(int idcliente)
        {

            return await this._asyncBaseRepositoriodireccion.GetAll(a => a.ClienteId == idcliente);
        }

        public async Task<Direccion> GetById(int id)
        {
             return await this._asyncBaseRepositoriodireccion.GetById(id);    
        }

        public async Task<bool> Update(Direccion dr)
        {
            return await this._asyncBaseRepositoriodireccion.Update(dr);
        }

        public async Task<Direccion> GetById(int id, string dependencia)
        {
            return await this._asyncBaseRepositoriodireccion.GetById(id,dependencia);
        }
    }
}
