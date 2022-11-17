using System;

namespace C20_Entidades_01
{
    public delegate void DelegadoString(string s);

    public class Persona
    {
        private string nombre;
        private string apellido;
        public event DelegadoString EventoString;

        public Persona()
        { }

        public string Nombre
        {
            get { return this.nombre; }
            set 
            { 
                this.nombre = value;
                if (this.EventoString is not null)
                {
                    this.EventoString.Invoke("Nombre cambiado a " + value); //this.EventoString(value);
                }
            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set 
            {
                this.apellido = value;
                if (this.EventoString is not null)
                {
                    this.EventoString.Invoke("Apellido cambiado a " + value);
                }
            }
        }

        public string Mostrar()
        {
            return this.nombre + " " + this.apellido;
        }
    }
}
