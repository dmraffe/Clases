using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAvanzado.Modelos.DBModel
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set;}

        public string? CreatedFor {  get; set; }
        public string? UpdatedFor { get; set;}
    }
}
