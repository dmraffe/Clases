using Proyecto.Integrador.Modelo.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacions.Contratos.Servicio
{
    public interface IServicioBase<T>  where T : ModeloBase
    {
        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<T> DeleteAsync(T entity);

        Task<IReadOnlyList<T>> GetAllAsync();
        
                                     
        Task<T> GetByIdAsync(int id);
    }
}
