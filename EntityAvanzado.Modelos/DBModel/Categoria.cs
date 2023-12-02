using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAvanzado.Modelos.DBModel
{
    public  class Categoria : BaseModel
    {
         public  string Nombre { get; set; }

        public bool EnPromocion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }

    }
}
