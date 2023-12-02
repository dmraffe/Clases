using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Dominio
{
    public class Pais : ModeloBase
    {
        public string Nombre {  get; set; }

        public string Code { get; set; }

        public ICollection<Ciudad> Ciudad { get; set; }
    }
}
