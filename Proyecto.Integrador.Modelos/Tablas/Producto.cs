﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelos.Tablas
{
    public class Producto : TablaBase
    {
        public int  rate { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Imagen { get; set; }
        public decimal Precio { get; set; } 
        public int Cantidad { get; set; }

        public bool EsPrimario { get; set; }
        public int CategoriaID { get; set; }
        public bool EsNuevo { get; set; }
    }
}
