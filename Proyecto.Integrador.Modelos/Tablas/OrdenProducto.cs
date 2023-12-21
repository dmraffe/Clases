using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelos.Tablas
{
    public class OrdenProducto : TablaBase
    {
        public int IdOrden { get; set; }
        public int IdProducto { get; set; }
    }
}
