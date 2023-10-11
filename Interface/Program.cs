using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var pr1 = new PruebaTest1();
            var pr2 = new PruebaTest2();

            MostrarValor(pr1);
            MostrarValor(pr2);

            Console.Read();
        }


        public static void MostrarValor(Prueba prueba)
        {
            Console.WriteLine(prueba.getValue());


        }

        public static void MostrarValor(IPrueba prueba)
        {
            Console.WriteLine(prueba.getValue());


        }
    }
}
