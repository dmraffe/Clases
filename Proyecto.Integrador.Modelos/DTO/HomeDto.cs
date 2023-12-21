using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelos.DTO
{
    public class HomeDto
    {

        public List<Categoria> Categorias { get; set; }

        public List<Producto> Tops { get; set; }
        public List<Producto> Vendidos { get; set; }

        public List<Producto> Nuevos { get; set; }
        

    }
}
