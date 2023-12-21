using Proyecto.Integrador.Aplicacion.Contratos.Repositorio;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;
using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion.Implementaciones.Categoria
{
    public class ServicioCategoria : IservicioCategoria
    {

        IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.Categoria> baseRepositorio;

        public ServicioCategoria(IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.Categoria> baseRepositorio)
        {
            this.baseRepositorio = baseRepositorio;
        }

        public async Task<List<Modelos.Tablas.Categoria>> ObtenerTodo()
        {
            var result = await this.baseRepositorio.GetAllAsync();

            return result.ToList();
        }
    }
}
