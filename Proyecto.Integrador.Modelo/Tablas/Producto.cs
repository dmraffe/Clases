using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelo.Tablas
{
    public class Producto  : ModeloBase
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set;}

        public decimal Precio { get; set;}
        public int Cantidad {  get; set;}

        public bool EsNuevo { get; set;}

        public  int CategoriaId { get; set;}

        

        public virtual Categoria Categoria { get; set;}
    }
}
