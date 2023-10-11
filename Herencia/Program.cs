using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(14);

            //Console.WriteLine(cuadrado.Area());

            Colaborador Colaborador = new Colaborador((decimal)125.2, "Dixon", "Raffe");


            Ejecutivo ejecutivo = new Ejecutivo((decimal)125.2, "Pedro", "Perez");


            Console.WriteLine(Colaborador.CalculodeSalario());
            Console.WriteLine(ejecutivo.CalculodeSalario());


        }


        static void Imprimir(Empleado colaborador)
        {
            Console.WriteLine(colaborador.CalculodeSalario());
        }

       
    }
}
