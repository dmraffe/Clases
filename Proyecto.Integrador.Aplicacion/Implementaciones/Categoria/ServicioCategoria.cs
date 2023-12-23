using Proyecto.Integrador.Aplicacion.Contratos.Repositorio;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;
using Proyecto.Integrador.Aplicacion.Implementaciones.ServicioBase;
using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion.Implementaciones.Categoria
{
    public class ServicioCategoria : ServicioBase<Proyecto.Integrador.Modelos.Tablas.Categoria>, IservicioCategoria,IBaseServicio<Proyecto.Integrador.Modelos.Tablas.Categoria >
    {

        IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.Categoria> baseRepositorio;

        public ServicioCategoria(IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.Categoria> baseRepositorio):   base(baseRepositorio)  
        {

           
            this.baseRepositorio = baseRepositorio;
        }

        public Task<Modelos.Tablas.Categoria> AddCategoria(Modelos.Tablas.Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Modelos.Tablas.Categoria>> ObtenerTodo()
        {
            var result = await this.baseRepositorio.GetAllAsync();

            return result.ToList();
        }
    }
}
