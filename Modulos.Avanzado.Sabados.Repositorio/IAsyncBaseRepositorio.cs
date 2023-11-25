using Modulos.Avanzado.Sabados.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Repositorio
{
    public interface IAsyncBaseRepositorio<T> where T : ModeloBase
    {
        public Task<bool> Add(T model);

        public Task<bool> Update(T model);

        public Task<bool> Delete(T model);

        public Task<T> GetById(int Id);
        public Task<T> GetById(int Id,string dependencia);

        public Task<IEnumerable<T>> GetAll();

        public Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicated);

    }
}
