using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1PPO
{
    internal class Figura:Abuelo
    {
        public double Lado { get; set; }

        public Figura(double _lado) { 
        
            Lado = _lado;
        }

        public virtual double GetPerimeter()
        {
            return Lado * 4;
        }

    }
}
