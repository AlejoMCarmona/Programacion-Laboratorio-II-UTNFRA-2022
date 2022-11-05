using System;

namespace C17_Entidades_01
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            this.id = id;
        }

        public Persona(string nombre, string apellido) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int ID
        {
            get { return this.id; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
    }
}
