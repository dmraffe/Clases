using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1PPO
{
    internal class Poligono:Figura
    {
        public int NumerodeLados { get;private set; }
        public Poligono(int _numerodeLados, double _lados):base(_lados) { 
            NumerodeLados = _numerodeLados;
        }

        public override double GetPerimeter()
        {
            return Lado * NumerodeLados;
        }
    }
}
