using EntityAvansado.Repositorio.Interfaces;
using EntityAvanzado;
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

        public void Cualquiera()
        {
            throw new NotImplementedException();
        }
    }
}
