using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelo.Tablas
{
    public  class Rate : ModeloBase
    {

        public string UserId { get; set; }

        public float rate { get; set; }

        public string comentario { get; set; }

        public DateTime Fecha { get; set; }

        public int OrderId { get; set; }

        public virtual Ordenes Ordenes { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
