using Proyecto.Integrador.Modelo.Tablas;

namespace Proyecto.Integrador.Web.Models.DTO
{
    public class HomeDto
    {
      
        public  IReadOnlyCollection<Categoria> Categorias { get; set; }
        public IReadOnlyCollection<Producto> ProductosNuevos { get;   set; }
    }
}
