using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelos.Tablas
{
    public class TablaBase
    {

        public int Id { get; set; }

        public string CreadoPor {  get; set; }
        public string ActualizadoPor { get; set; }

        public DateTime? FechaCreado { get; set; }
        public DateTime? FechaEditado { get; set; }


    }
}
