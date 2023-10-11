using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargadeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 1,2,3,4,5,6,7,8,9};



            recorrer(lista);
            recorrer(lista,2);
            recorrer(lista,2,5);
        }

        static void recorrer(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }
        static void recorrer(int[] arreglo, int starindex)
        {
            for (int i = starindex; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }

        static void recorrer(int[] arreglo, int starindex, int endindex)
        {
            for (int i = starindex; i < endindex; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }

    }
}
