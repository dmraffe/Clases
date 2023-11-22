using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestEntityModelFirst testEntityModelFirst = new TestEntityModelFirst();
            testEntityModelFirst.Cateogorias.Add(new Cateogorias
            {
               Imagen =  "asda",
               Nombre = "Dixon"

            });
            testEntityModelFirst.SaveChanges();

            var cat   = testEntityModelFirst.Cateogorias.ToList();

            foreach (var cat2 in cat)
            {
                Console.WriteLine(cat2.Nombre);
            }

            Console.ReadKey();
        }
    }
}
