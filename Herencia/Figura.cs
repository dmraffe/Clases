using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public abstract class Figura
    {
       public int lado { get; set; }

        protected Figura(int lado)
        {
            this.lado = lado;
        }

        abstract public int Area();
    }
}
