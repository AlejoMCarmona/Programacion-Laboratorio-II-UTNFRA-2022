using System;
using System.Text;

namespace C3_Entidades_02
{
    public class Persona
    {
        //ATRIBUTOS:
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        //CONSTRUCTOR:
        public Persona ()
        {
            nombre = "Persona";
            fechaDeNacimiento = DateTime.Now.Date;
            dni = 44000000;
        }

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento.Date;
            this.dni = dni;
        }

        //GETTERS:
        public string GetNombre()
        {
            return this.nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public int GetDni()
        {
            return this.dni;
        }

        //METODOS:
        private int CalcularEdad()
        {
            //TODO: mejorar metodo ; se puede usar TimeSpan
            int edadActual = 0;
            DateTime fechaActual = DateTime.Now.Date;
            DateTime nacimientoPersona = this.fechaDeNacimiento;

            while (nacimientoPersona.Year < fechaActual.Year)
            {
                nacimientoPersona = nacimientoPersona.AddYears(1);
                if (nacimientoPersona.Year != fechaActual.Year)
                    edadActual++;
            }

            if (DateTime.Compare(fechaActual, nacimientoPersona) > 0 || DateTime.Compare(fechaActual, nacimientoPersona) == 0)
            {
                edadActual++;
            }

            return edadActual;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento}");
            sb.AppendLine($"Edad: {this.CalcularEdad()}");
            sb.Append($"DNI: {this.dni}");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            string mensaje = "Es mayor de edad";

            if (this.CalcularEdad() < 18)
            {
                mensaje = "No es mayor de edad";
            }

            return mensaje;
        }
    }
}
