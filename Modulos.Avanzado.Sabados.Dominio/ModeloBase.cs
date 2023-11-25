﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzado.Sabados.Dominio
{
    public class ModeloBase
    {
        public int Id {  get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set;}

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set;}
    }
}
