﻿using Proyecto.Integrador.Modelo.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacions.Contratos.Repositorio
{
    public interface IRepositorioBase<T> where T : ModeloBase
    {

        Task<IReadOnlyList<T>> GetAllAsync();

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicated);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicated = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        bool disabledTranking = true
                                        );
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicated = null,
                                      Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                     List<Expression<Func<T, object>>> includes = null,
                                      bool disabledTranking = true
                                      );
        Task<T> GetByIdAsync(int id);


        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<T> DeleteAsync(T entity);
    }
}
