using Proyecto.Integrador.Aplicacions.Contratos.Repositorio;
using Proyecto.Integrador.Aplicacions.Contratos.Servicio;
using Proyecto.Integrador.Modelo.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Infra.Implementacion.Servicio
{
    public class BaseServicio<T> : IServicioBase<T> where T : ModeloBase
    {

        IRepositorioBase<T> repositorioBase = null;

        public BaseServicio(IRepositorioBase<T> repositorioBase)
        {
            this.repositorioBase = repositorioBase;
        }

        public async Task<T> AddAsync(T entity)
        {
            return await this.repositorioBase.AddAsync(entity);
        }

        public async Task<T> DeleteAsync(T entity)
        {
            return await this.repositorioBase.DeleteAsync(entity);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await this.repositorioBase.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await this.repositorioBase.GetByIdAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            return await this.repositorioBase.UpdateAsync(entity);
        }
    }
}
