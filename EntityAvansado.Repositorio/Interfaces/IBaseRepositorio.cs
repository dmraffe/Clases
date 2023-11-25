using EntityAvanzado.Modelos.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityAvansado.Repositorio.Interfaces
{
    public interface IBaseRepositorio<T> where T : BaseModel
    {
        public Task<bool> Add(T entity);
        public Task<bool> Update(T entity);
        public Task<bool> Delete(T entity);

        public Task<ICollection<T>> GetAll();

        public Task<ICollection<T>> GetAll(Expression<Func<T, bool>> predicated);

        public Task<T> Get(int id);
    }
}
