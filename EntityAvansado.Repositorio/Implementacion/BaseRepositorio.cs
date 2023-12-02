using EntityAvansado.Repositorio.Interfaces;
using EntityAvanzado;
using EntityAvanzado.Modelos.DBModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityAvansado.Repositorio.Implementacion
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : BaseModel
    {

        private readonly EntityAvanzadoDBContext entityAvanzadoDBContext;

        public BaseRepositorio(EntityAvanzadoDBContext entityAvanzadoDBContext)
        {
            this.entityAvanzadoDBContext = entityAvanzadoDBContext;
        }

        public async Task<bool> Add(T entity)
        {
            this.entityAvanzadoDBContext.Add(entity);
            await this.entityAvanzadoDBContext.SaveChangesAsync();

            return  true;
        }

        public async Task<bool> Delete(T entity)
        {
            this.entityAvanzadoDBContext.Set<T>().Remove(entity);
            await this.entityAvanzadoDBContext.SaveChangesAsync();

            return true;
        }

        public async Task<T> Get(int id)
        {
           var entidad = await   this.entityAvanzadoDBContext.Set<T>().Where(a =>a.Id  == id).FirstOrDefaultAsync() ;

            return entidad;
        }

        public async Task<T> Get(int id, string relacion)
        {
            var entidad = await this.entityAvanzadoDBContext.Set<T>().Include(relacion).Where(a => a.Id == id).FirstOrDefaultAsync();

            return entidad;
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await this.entityAvanzadoDBContext.Set<T>().ToListAsync();
        }

        public async Task<ICollection<T>> GetAll(Expression<Func<T, bool>> predicated)
        {
            return await this.entityAvanzadoDBContext.Set<T>().Where(predicated).ToListAsync();
        }

        public async Task<ICollection<T>> GetAll(Expression<Func<T, bool>> predicated, string relacion)
        {
            return await this.entityAvanzadoDBContext.Set<T>().Include(relacion).Where(predicated).ToListAsync();
        }

        public async Task<bool> Update(T entity)
        {
            this.entityAvanzadoDBContext.Set<T>().Update(entity);
            await this.entityAvanzadoDBContext.SaveChangesAsync();

            return true;
        }
    }
}
