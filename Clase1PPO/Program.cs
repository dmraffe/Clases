using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Clase1PPO
{
    internal class Program
    {



        void recorrer(int[] arreglo)
        {
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }
        void recorrer(int[] arreglo, int starindex)
        {
            for (int i = starindex; i < arreglo.Length; i++)
            {
               Suma(25, 25, 25, 25, 25, 25, 25, 25, 25);
            }
        }

        public static int Suma(params int[] intArr)
        {
            int sum = 0;
            foreach (int i in intArr) sum += i;
            return sum;
        }


        void recorrer(int[] arreglo, int starindex, int endindex)
        {
            for (int i = starindex; i < endindex; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }

        public static void FuncionParametros(int valor ,Singleton singleton)
        {
            valor = 6;
            singleton.Caption = "Dixon";


            Console.WriteLine(valor);
            Console.WriteLine(singleton.Caption);
        }
        static void Main(string[] args)
        {


            int[] numeros = new int[10];

            numeros[20] = 123;


            ArrayList lista = new ArrayList();


            List<int> numm = new List<int>();

            int num = 2147483647;
            long bigNum = num;

            Figura F  = new Figura(25);

            var Cuad = (Cuadrado)F;

          

             



            int h = int.Parse("adasdasdasd");
          
            double x = 1234.7;
            int a;
            // Castdoubletoint.
            a = (int)x;
            System.Console.WriteLine(a);



            ObjetoEstatico objetoEstatico = new ObjetoEstatico();

            objetoEstatico = null;

            int parametro = -1;


             if(Int32.TryParse("-1",out parametro))
            {
                // algo
            }else
            {

            }

            List<Figura> list = new List<Figura>();

            list.Add(new Figura(2));
            list.Add(new Figura(2));

            list.Add(new Figura(2));
            list.Add(new Figura(2));

            list.Add(new Figura(2));
            list.Add(new Figura(2));

            var lista2 = new List<Figura>();

            lista2.Add(new Figura(2));

            foreach (var item in list)
            {
                lista2.Add(new Figura(item.Lado));
            }
            
            
            
            var lista3 = new List<Figura>();
           
            
            foreach (var item in list)
            {
                lista3.Add(item);
            }


            foreach (var item in lista3)
            {
                item.Lado = 9;
            }





            var figura1 = new Figura(23);

            var figura2 = figura1;

            figura2.Lado = 25;

            var lado = figura1.Lado;
                
            var single = Singleton.GetSingleton(25);
            FuncionParametros(parametro, single);
            Console.WriteLine(parametro);
            Console.WriteLine(single.Caption);


            ejemploConversion();

            ejemploListas();

            EjemploListaOrdenada();
           



            double xa  = 1234.7;
            int ax;
            // Castdoubletoint.
            ax = (int)xa;
            System.Console.WriteLine(a);




            int i = 123; 
// Thefollowing line boxes i.
object o = i; 
 o = 123; 
 i = (int)o; // unboxing 



            var Cuadrado = new Cuadrado(9);
            var triangulo = new Triangulo(8);
            var poligono = new Poligono(5, 9);
            var Circulo = new Circulo(8);
            var cuad = new Cuadrado();

            var fg = new Figura(5);

            fg = Cuadrado;

            




            Index test = new Index();
             var valor =  test[0];

            Circulo.Nombre = "Scarlet";
            MiemborsEstaticos.valor = 909090;

            Circulo.ToString();
            var cd = new Circulo(8);
            cd.Nombre = "Andres";
            /*Console.WriteLine(cd.Nombre);
            Console.WriteLine(Circulo.Nombre);
            Console.ReadKey();  */
            ShowData(Cuadrado);
            ShowData(triangulo);
            ShowData(poligono);
            ShowData(Circulo);

             int valorPrueba = 0;

            EjmploParametros(ref valorPrueba, Cuadrado);


            Console.WriteLine($" El valor es {valorPrueba}  el nombre del cuadrado es {Cuadrado.Pueba}");


            Console.ReadKey();
        }

        private static void EjemploListaOrdenada()
        {
            SortedList<string, int> ListaOrdenada = new SortedList<string, int>();
            ListaOrdenada.Add("C", 300);
            ListaOrdenada.Add("A", 100);
            ListaOrdenada.Add("B", 200);

            foreach (KeyValuePair<string, int> item in ListaOrdenada)
            {
                Console.WriteLine("Clave: {0}. Valor: {1}",item.Key, item.Value);
            }


            Console.WriteLine("Arranca la Cola ");
            Queue<Persona> Cola = new Queue<Persona>();
            Cola.Enqueue(new Persona("Ana", "González"));
            Cola.Enqueue(new Persona("Pedro", "Benítez"));
            Cola.Enqueue(new Persona("Isabel", "Pérez"));

            while (Cola.Count > 0)
            {
                Console.WriteLine("Elementos en la cola " + Cola.Count);
                Persona item = Cola.Dequeue();
                Console.WriteLine("{0}, {1}", item.Apellido, item.Nombre);
            }


          
        }

        private static void ejemploListas()
        {
            ArrayList ListaA = new ArrayList();

            object obj = 98;

            ListaA.Add(1);
            ListaA.Add("A");
            ListaA.Add(obj);

            Persona ob =  new Persona("Joselo","Ramirez");

            ListaA.Insert(1, 2);
            ListaA.Insert(1, "B");
            ListaA.Insert(1, ob);

            foreach (object item in ListaA)
            {
                //Se muestra el tipo de objeto
                Console.Write("Tipo de objeto: {0}.", item.GetType().FullName);
                //Se decide como mostrar el item segun sea el tipo de objeto
                if (item.GetType() == typeof(System.Int32))
                {
                    Console.WriteLine("Valor: {0}", (int)item);
                }
                if (item.GetType() == typeof(string))
                {
                    Console.WriteLine("Valor: {0}", item.ToString());
                }
                if (item.GetType() == typeof(Persona))
                {
                    Persona objPersona = (Persona)item;
                    Console.WriteLine("Valor: {0}", objPersona.Nombre + " " +objPersona.Apellido);
                }
            }

        }

        private static void ejemploConversion()
        {
           // String.Concatexample.
// String.Concat has manyversions. Restthe mouse pointer on
// Concat in thefollowingstatementtoverifythattheversion// 
//thatisusedheretakesthreeobjectarguments.Both 42 and// true must be boxed.
        Console.WriteLine(String.Concat("Answer", 42, true));
            // Listexample.
            // Create a listofobjectstohold a heterogeneouscollection// ofelements.
            List<object> mixedList = new List<object>();
            // Add a stringelementtothelist. 
            mixedList.Add("FirstGroup:");
            // Addsomeintegerstothelist. 
            for (int j = 1; j < 5; j++)  
            {  
                mixedList.Add(j);
            }
            // Addanotherstring and more integers.
            mixedList.Add("SecondGroup:");
            for (int j = 5; j < 10; j++)
            {
                mixedList.Add(j);
            }
            // Displaytheelements in thelist. Declare theloop variable by// usingvar, so 
           // thatthecompilerassignsitstype.
                foreach (var item in mixedList)
            {
                // Restthe mouse pointer overitemtoverifythattheelements// ofmixedList are objects.
                Console.WriteLine(item);
            } 
 
// Thefollowingloopsumsthesquaresofthefirstgroupofboxed
// integers in mixedList. Thelistelements are objects, and cannot
// be multipliedoraddedtothe sum untilthey are unboxed. The
// unboxingmust be done explicitly.
            var sum = 0;
            for (var j = 1; j < 5; j++)
            {
               sum += (int)mixedList[j] * (int)mixedList[j];
            }

        }

        public static void EjmploParametros(ref int valor,Cuadrado fr)
        {
            fr.Pueba = "CAmbio";
            valor = valor + 1;
        }

        private static void ShowData(Figura Cuadrado)
        {
            Console.WriteLine($"El lado es {Cuadrado.Lado} y El Perimetro toal es:{Cuadrado.GetPerimeter()}");

        }
        private static void ShowData()
        {
             

        }

        private static void ShowData(int valor)
        {


        }

        private static void ShowData(int valor, Figura figura)
        {


        }

    }

    public class TrianguloEquilatero
    { 
      
    }
}
