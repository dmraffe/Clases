using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public interface ISubcontratado
    {
        string Empresa { get; set; }
        bool Activo { get; set; }

    }
}
