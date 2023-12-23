using Proyecto.Integrador.Aplicacion.Contratos.Repositorio;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;
using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion.Implementaciones.ServicioBase
{
    public class ServicioBase<T> : IBaseServicio<T> where T : TablaBase
    {
        private IBaseRepositorioAsync<T> baseRepositorio;

        public ServicioBase(IBaseRepositorioAsync<T> baseRepositorio)
        {
            this.baseRepositorio = baseRepositorio;
        }
        public async Task<T> AddAsync(T entity)
        {
            await   baseRepositorio.AddAsync(entity);
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            await baseRepositorio.DeleteAsync(entity);
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await baseRepositorio.UpdateAsync(entity);
            return entity;
        }
    }
}
