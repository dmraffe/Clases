using Microsoft.EntityFrameworkCore;
using Proyecto.Integrador.Aplicacion.Contratos.Repositorio;
using Proyecto.Integrador.Infraestructura.Persistencia;
using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Infraestructura.Repositorios
{
    public class BaseRepositorio<T> : IBaseRepositorioAsync<T> where T : TablaBase
    {
        ProyectoIntegradorDbContext _ProyectoIntegradorDbContext;
        public BaseRepositorio(ProyectoIntegradorDbContext proyectoIntegradorDbContext) {
            _ProyectoIntegradorDbContext = proyectoIntegradorDbContext;
        }
        
        public async Task<T> AddAsync(T entity)
        {
            _ProyectoIntegradorDbContext.Set<T>().Add(entity);
            await _ProyectoIntegradorDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _ProyectoIntegradorDbContext.Set<T>().Remove(entity);
            await _ProyectoIntegradorDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _ProyectoIntegradorDbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicated)
        {
            return await _ProyectoIntegradorDbContext.Set<T>().Where(predicated).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _ProyectoIntegradorDbContext.Set<T>().Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _ProyectoIntegradorDbContext.Set<T>().Update(entity);
            await _ProyectoIntegradorDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
