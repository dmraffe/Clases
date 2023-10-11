using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEstaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var pr = PruebaEstatica.GetPruebaEstatica("Jose fernandez");

            Console.WriteLine(pr.valor);

            var pr2 = PruebaEstatica.GetPruebaEstatica();

            Console.WriteLine(pr2.valor);

            Console.Read();
        }




    }


    class PruebaEstatica
    {

        public string valor { get; set; }


        private PruebaEstatica(string _valor) {
            this.valor = _valor;    
        }

        private PruebaEstatica()
        {
            
        }

        private static PruebaEstatica _pruebaEstatica;
        public static PruebaEstatica GetPruebaEstatica(string valor)
        {
            if (_pruebaEstatica == null)
                _pruebaEstatica = new PruebaEstatica(valor);

            return _pruebaEstatica;
        }


        public static PruebaEstatica GetPruebaEstatica()
        {
            if (_pruebaEstatica == null)
                _pruebaEstatica = new PruebaEstatica();

            return _pruebaEstatica;
        }

    }
}
