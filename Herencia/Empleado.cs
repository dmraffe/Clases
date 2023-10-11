using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public abstract class Empleado
    {
        public decimal sueldo { get;private set; }

        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        protected Empleado(decimal sueldo, string nombre, string apellido)
        {
            this.sueldo = sueldo;
            Nombre = nombre;
            Apellido = apellido;
        }

        public abstract decimal CalculodeSalario();
    }
}
