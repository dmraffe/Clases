using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model1 model1 = new Model1();

            var listapersona = model1.Personas.ToList();

            foreach (var item in listapersona)
            {
                System.Console.WriteLine($"Model Context {item.Name}");
            }


            EntityExamplesEntities1 entityExamplesEntities1 = new EntityExamplesEntities1();
            var listapersona2 = entityExamplesEntities1.Personas.ToList();

            foreach (var item in listapersona2)
            {
                System.Console.WriteLine($"edmx Context {item.Name}");
            }


            System.Console.ReadKey();
        }
    }
}
