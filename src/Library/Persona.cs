using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        public int edad {get; set;}
        public string nombre {get; set;}

        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }
    }
}