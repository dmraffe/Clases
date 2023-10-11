using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Clase1PPO
{
    public class PruebaReadOnly
    {

        private string Test;

        public readonly string Cadena;

        public string testert { get;private set; }

        

        private string valor;
        public string Valor
        {
            get { return valor; } 
 
        set
            {
                valor = value;

                Verificar();
            }
        }

        private void Verificar()
        {
            if(string.IsNullOrEmpty(valor))
            {
                throw new Exception("asdas");
            }
        }

        public PruebaReadOnly(string test, string cadena)
        {
            Test = test;
            Cadena = cadena;
        }


        public void ChangeCadena(string cadena)
        {
            Test = cadena;
        }
    }
}
