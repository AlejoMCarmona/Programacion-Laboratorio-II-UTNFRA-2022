using System;
using System.Text;
using Geometria;

namespace C3_Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo(new Punto(-2, 1), new Punto(-5, -4));
            Rectangulo r2 = new Rectangulo(new Punto(7, 30), new Punto(-5, 1));

            Console.WriteLine("Rectangulo 1:");
            Console.WriteLine(Program.MostrarRectangulo(r1));
            Console.WriteLine(Program.MostrarRectangulo(r1));

            Console.WriteLine("Rectangulo 2:");
            Console.WriteLine(Program.MostrarRectangulo(r2));
        }

        public static string MostrarRectangulo(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Perimetro del rectángulo: {rectangulo.Perimetro()}");
            sb.Append($"Area del rectángulo: {rectangulo.Area()}");

            return sb.ToString();
        }
    }
}
