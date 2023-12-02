using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Dominio
{
    public class Ciudad : ModeloBase
    {
        public string Nombre { get; set; }

        public int PaisId { get; set; }

        public virtual Pais Pais {  get; set; }

        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}
