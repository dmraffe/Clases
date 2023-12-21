using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelo.Tablas
{
    public class Detalle : ModeloBase
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Impuesto { get; set; }

        public decimal Descuento { get; set; }

        public int OrdenId { get; set; }

        public decimal TotalDetalle { get; set; }


        public virtual  Ordenes  Orden { get; set; }

    }
}
