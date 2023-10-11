using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1PPO
{
    internal class Triangulo : Figura
    {
        public Triangulo(double _lado) : base(_lado)
        {
        }

        public override double   GetPerimeter()
        {
            return Lado * 3;
        }

    }
}
