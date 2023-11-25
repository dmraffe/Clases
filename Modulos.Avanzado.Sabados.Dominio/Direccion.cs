using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Dominio
{
    public class Direccion : ModeloBase
    {
        public string Calle { get; set; }

        public int NumerodeCalle { get; set; } 

        public string Provincia { get; set; }

        public string Pais {  get; set; }

        public string? Apartamento { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

    }
}
