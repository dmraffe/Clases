using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Collecciones.Program;

namespace Collecciones
{
    internal class Program
    {

        enum Dias{ Otro, Sab, Dom, Lun, Mar, Mie, Jue, Vie  };
    static void Main(string[] args)
        {




            int x = (int)Dias.Dom;
            int y = (int)Dias.Vie;
            Console.WriteLine("Dom = {0}", x);
            Console.WriteLine("Vie = {0}", y);
            Console.ReadKey();
            

                        GalaxiasEjemplo();
            OperacionesSobreListas();




            var artesMarciales = new List<string>();
            var artesmarciales3 = new List<string>();
            artesMarciales.Add("Taekwondo");
            artesMarciales.Add("KungFu");
            artesMarciales.Add("Karate");
            artesMarciales.Add("Aikido");

            foreach (var item in artesMarciales)
            {
                artesmarciales3.Add(new string(item.ToCharArray()));
            }
            var artestMarciales2   = new List<string>{ "Taekwondo", "KungFu", "Karate", "Aikido" };
            var res =  from a in artesMarciales where a.ToLower().Contains("u")  select a;
            artesMarciales.Remove("KungFu");

            
            
            foreach (var arte in res)
            {
                Console.WriteLine(arte + " ");
            }

            // Iterar cada elemento de la lista.
            foreach (var arte in artesMarciales.Where(a=>a.ToLower().Contains("u")).ToList())
            {
                Console.WriteLine(arte + " ");
            }

            for (var index = 0; index < artesMarciales.Count; index++)
            {
                Console.WriteLine(artesMarciales[index] + " ");
            }
     

    Console.Read();
        }

        private static void OperacionesSobreListas()
        {
            var numbers = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                      numbers.RemoveAt(index); 
                }
            }
            // Iterar la lista 
            numbers.ForEach(number => Console.Write(number + " "));

            Console.Read();
        }


        private static void GalaxiasEjemplo()
        {
             
                List<Galaxia> lasGalaxias = new List<Galaxia> {
                    new Galaxia() { Nombre = "Tadpole", MegaAniosLuz = 400}, 
                    new Galaxia() { Nombre = "Pinwheel", MegaAniosLuz = 25}, 
                    new Galaxia() { Nombre = "MilkyWay", MegaAniosLuz = 0}, 
                    new Galaxia() { Nombre = "Andromeda", MegaAniosLuz = 3}
                };
                foreach (Galaxia laGalaxia in lasGalaxias)
                {
                    Console.WriteLine(laGalaxia.Nombre + " " + laGalaxia.MegaAniosLuz);
                }
                Console.ReadKey();
            
        }


        public class Galaxia
        { 
        public string Nombre { get; set; }
        public int MegaAniosLuz{ get; set; }
        } 



    }
}
