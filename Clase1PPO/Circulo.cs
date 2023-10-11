using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1PPO
{
    internal class Circulo:Figura
    {
        public Circulo(double _lado) : base(_lado)
        {
        }

        public string Nombre { get; set; }

        public override double GetPerimeter()
        {
            return Lado *2*Math.PI;
        }
    }
}
