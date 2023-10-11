using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Ejecutivo : Empleado,IAdministrar,ISubcontratado
    {

        private const int CoeficienteSalario = 10;
        public Ejecutivo(decimal sueldo, string nombre, string apellido) : base(sueldo, nombre, apellido)
        {
        }

        public string Empresa { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Activo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal CalculodeSalario()
        {
            return base.sueldo * CoeficienteSalario;
        }

        public void Crear()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
