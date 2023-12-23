using Microsoft.EntityFrameworkCore;
using Proyecto.Integrador.Aplicacions.Contratos.Repositorio;
using Proyecto.Integrador.Infra.Persistencia;
using Proyecto.Integrador.Modelo.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Infra.Implementacion.Repositorio
{
    public class BaseRepositorio<T> : IRepositorioBase<T> where T : ModeloBase
    {
        private TiendaMIaDbContext streamerDbContext;

        public BaseRepositorio(TiendaMIaDbContext streamerDbContext)
        {
            this.streamerDbContext = streamerDbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            streamerDbContext.Set<T>().Add(entity);
            streamerDbContext.Entry(entity).State = EntityState.Added;
            await streamerDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            streamerDbContext.Set<T>().Remove(entity);
            await streamerDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await streamerDbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicated)
        {
            return await streamerDbContext.Set<T>().Where(predicated).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicated = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeString = null, bool disabledTranking = true)
        {
            IQueryable<T> query = streamerDbContext.Set<T>();
            if (disabledTranking) query = query.AsNoTracking();

            if (!string.IsNullOrEmpty(includeString)) query = query.Include(includeString);

            if (predicated != null) query = query.Where(predicated);

            if (orderBy != null) return await orderBy(query).ToListAsync();

            return await query.ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicated = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<Expression<Func<T, object>>> includes = null, bool disabledTranking = true)
        {
            IQueryable<T> query = streamerDbContext.Set<T>();
            if (disabledTranking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicated != null) query = query.Where(predicated);

            if (orderBy != null) return await orderBy(query).ToListAsync();

            return await query.ToListAsync();
        }

        public  async Task<T> GetByIdAsync(int id)
        {
            return await streamerDbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            streamerDbContext.Set<T>().Update(entity);
            streamerDbContext.Entry(entity).State = EntityState.Modified;
            await streamerDbContext.SaveChangesAsync();
            return entity;
        }
    }
     
}
