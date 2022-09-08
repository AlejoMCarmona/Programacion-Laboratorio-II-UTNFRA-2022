using System;
using System.Text;

namespace C3_Entidades_03
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante ()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.notaPrimerParcial = 0;
            this.notaSegundoParcial = 0;
        }

        public void SetNotaPrimerParcial (int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaPrimerParcial = nota;
            }
        }

        public void SetNotaSegundoParcial (int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaSegundoParcial = nota;
            }
        }

        private float CalcularNotaFinal ()
        {
            float notaFinal = -1;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11); //genera un número entre 6 y 10
            }

            return notaFinal;
        }

        public float CalcularPromedio()
        {
            float promedio = -1;

            if (this.notaPrimerParcial > 0 && this.notaSegundoParcial > 0)
            {
                promedio = ((float)notaPrimerParcial + notaSegundoParcial) / 2;
            }

            return promedio;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            float notaFinal;

            sb.AppendLine("Datos del alumno:");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota del primer parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");

            notaFinal = this.CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.Append($"Nota final: {notaFinal}");
            } else
            {
                sb.Append($"Alumno desaprobado.");
            }

            return sb.ToString();
        }
    }
}
