﻿
namespace Arrays
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }


        public Persona(int id, string nombre, string apellido, string sexo)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
        }
    }
}