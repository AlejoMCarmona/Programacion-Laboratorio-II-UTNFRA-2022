using System;

namespace C2_Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double alturaTriangulo;
            double baseTriangulo;
            double areaCalculada;
            string respuesta;

            do
            {
                Console.WriteLine("CALCULADORA DE HIPOTENUSAS");
                alturaTriangulo = Program.IngresarDoublePositivo("Ingrese la altura del triangulo en cm: ", "ERROR ¡Ingrese una altura válida!");
                baseTriangulo = Program.IngresarDoublePositivo("Ingrese la base del triangulo en cm: ", "ERROR ¡Ingrese una base válida!");

                Console.WriteLine("");
                areaCalculada = Calculadora.CalcularHipotenusa(alturaTriangulo, baseTriangulo);
                Console.WriteLine("Hipotenusa del triangulo: {0}cm\n", areaCalculada);
                
                Console.Write("¿Desea seguir calculando hipotenusas? (S para continuar): ");
                respuesta = Console.ReadLine();
                Console.WriteLine("\n------------------------------------------");
            } while (respuesta.Equals("S"));
        }

        public static double IngresarDoublePositivo(string mensaje, string mensajeError)
        {
            double numero;
            bool flag;

            do
            {
                Console.Write(mensaje);
                flag = double.TryParse(Console.ReadLine(), out numero);
                if (!flag || numero < 0) Console.WriteLine(mensajeError);
            } while (!flag || numero < 0);

            return numero;
        }
    }
}
