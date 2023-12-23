using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelo.Tablas
{
    public class Categoria : ModeloBase
    {
        public string Nombre { get; set; }

         public string Imagen { get; set; }
        public bool EsPromocion {  get; set; }  


        public virtual ICollection<Producto> Productos { get; set; }
    }
}
