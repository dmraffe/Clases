using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelo.Tablas
{
    public class Usuario : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public ICollection<Ordenes> Ordenes { get; set; }

        public ICollection<Rate> Rates { get; set; }

    }
}
