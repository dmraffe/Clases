using Microsoft.EntityFrameworkCore;
using Modulos.Avanzado.Sabados.Dominio;
using Modulos.Avanzados.Sabados.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Repositorio
{
    public class BaseRepositorio<T> : IAsyncBaseRepositorio<T> where T : ModeloBase
    {
        ModulosAvanzadoDBContext modulosAvanzadoDBContext {  get; set; }

        public BaseRepositorio(ModulosAvanzadoDBContext modulosAvanzadoDBContext)
        {
            this.modulosAvanzadoDBContext = modulosAvanzadoDBContext;
        }

        public async Task<bool> Add(T model)
        {
            this.modulosAvanzadoDBContext.Add(model);
           await this.modulosAvanzadoDBContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(T model)
        {
            this.modulosAvanzadoDBContext.Set<T>().Remove(model);
            await this.modulosAvanzadoDBContext.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.modulosAvanzadoDBContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicated)
        {
            return await this.modulosAvanzadoDBContext.Set<T>().Where(predicated).ToListAsync();
        }

        public async Task<T> GetById(int Id)
        {
            return await this.modulosAvanzadoDBContext.Set<T>().Where(a => a.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<bool> Update(T model)
        {
            this.modulosAvanzadoDBContext.Set<T>().Update(model);
            await this.modulosAvanzadoDBContext.SaveChangesAsync();

            return true;
        }

        public async Task<T> GetById(int Id, string dependencia)
        {
            return await this.modulosAvanzadoDBContext.Set<T>().Include(dependencia).Where(a => a.Id == Id).FirstOrDefaultAsync();
        }
    }
}
