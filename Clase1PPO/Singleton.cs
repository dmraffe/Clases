

using System;

namespace Clase1PPO
{
    public class Singleton
    {
        private static Singleton instance;

        
        public int SexId { get;  set; }

        public virtual Sexo Sexo { get; set; }
     


        public const int Default = 0;

        public readonly int Valor;

        public static string Nombre;
        public static string Apellido;
        public string name { get;set; }


        private string caption;

        public string Caption
        {
            get { return caption; } 
 
           set
            {    if(string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");   
                caption = value;  
            }
        }

          
        const  string _cadena2 ="Database 2";
        readonly string _cadena; 
       private Singleton(int valor)
        {
            
            Valor = valor;
            Caption = _cadena2;
        }

        private Singleton(string cadena)
        {

            _cadena = cadena;
        }

        public static Singleton GetSingleton(int valor)
        {
            if (valor > 50)
                throw new ArgumentException();

            if(instance == null)
                instance = new Singleton(valor);

            return instance;
        }

    }
}
