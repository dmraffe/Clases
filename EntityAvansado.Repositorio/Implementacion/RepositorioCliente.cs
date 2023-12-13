using EntityAvansado.Repositorio.Interfaces;
using EntityAvanzado;
using EntityAvanzado.Modelos;
using EntityAvanzado.Modelos.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAvansado.Repositorio.Implementacion
{
    public class RepositorioCliente : BaseRepositorio<Cliente>, IRepositorioCliente
    {
        public RepositorioCliente(EntityAvanzadoDBContext entityAvanzadoDBContext) : base(entityAvanzadoDBContext)
        {
        }

      

        public async Task<bool> AddCliente(Cliente cl)
        {
  

            if (string.IsNullOrEmpty(cl.Nombre))
                throw new Exception("EL nombre no puede estar vacio");

            if (string.IsNullOrEmpty(cl.Apellido))
                throw new ArgumentException("EL Apellido no puede estar vacio");


            var lista = await GetAll(a => a.Correo == cl.Correo);
            if (lista.Any())
                throw new ClienteException("El correo ya existe");

          return await  Add(cl);
        }

        public void Cualquiera()
        {
            throw new NotImplementedException();
        }
    }
}
