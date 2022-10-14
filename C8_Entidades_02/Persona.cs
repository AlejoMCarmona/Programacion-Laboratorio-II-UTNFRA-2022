using System;
using System.Text;

namespace C8_Entidades_02
{
    public class Persona
    {
        private long dni;

        public long Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Persona(string nombre)
        {
            this.dni = 0;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            this.nombre = nombre;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Nombre: " + this.nombre);
            datos.AppendLine("DNI: " + this.dni);

            return datos.ToString();
        }

    }
}
