using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAvanzado.Modelos.DBModel
{
    public  class Direccion: BaseModel
    {

        public string Nombre {  get; set; }
        public int Numero {  get; set; } 

        public string Provincia { get; set; }

        public string? Apartamento {  get; set; }

        public int ClienteID { get; set; }

        public virtual Cliente Cliente { get; set; }    


    }
}
