using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Cuadrado : Figura
    {
        public Cuadrado(int lado) : base(lado)
        {
        }

        public override int Area()
        {
            return lado * 4;
        }
    }
}
