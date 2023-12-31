﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Modelo.Tablas
{
    public class Ordenes : ModeloBase
    {

        
        public string Estado {  get; set; }

        public string CookieID { get; set; }

        public decimal Total { get; set; }

        public decimal Impuestos { get; set; }

        public virtual ICollection<Detalle>   detalles { get; set; }

        public string   UserId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Rate Rate { get; set; }
    }
}
