using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAvanzado.Modelos.DBModel
{
    public class Producto  :  BaseModel
    {
        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        public int CategoriaId {  get; set; }

        public virtual Categoria   Categoria { get; set; }  
                                                
    }
}
