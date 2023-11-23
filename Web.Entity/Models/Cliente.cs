﻿namespace Web.Entity.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get;set; }

        public string Correo { get; set; }

        public string Password { get; set; }

        public DateTime? FechadeNacimiento { get; set; }

        public Genero genero {  get; set; } 

        public string Pais { get; set; }

        public Guid Guid { get; set; }   

    }


    public enum Genero { 
      Masculino,
      Femenino,
      Otro
    }
}
