using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelos.Tablas
{
    public class Categoria : TablaBase
    {
        public string Nombre { get; set; }

        public bool EsPromocional { get; set; }

        public string Imagen {  get; set; }

    }
}
