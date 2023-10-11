using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Colaborador : Empleado
    {
        private const int CoeficienteSalario =5;
        public Colaborador(decimal sueldo, string nombre, string apellido) : base(sueldo, nombre, apellido)
        {
        }

        public override decimal CalculodeSalario()
        {
           return base.sueldo * CoeficienteSalario;
        }
    }
}
