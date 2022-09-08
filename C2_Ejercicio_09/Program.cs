
using System;

namespace C2_Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int factorial;
            bool flag;
            string respuesta;

            do
            {
                do
                {
                    Console.Write("Ingrese un número para calcular su factorial: ");
                    flag = int.TryParse(Console.ReadLine(), out numero);
                    if (!flag || numero < 0) Console.WriteLine("ERROR ¡Ingrese un número válido!");
                } while (!flag || numero < 0);

                factorial = Calculadora.CalcularFactorial(numero);
                Console.WriteLine("El factorial de {0} es {1}\n", numero, factorial);

                Console.Write("¿Desea seguir calculando factoriales? (S para continuar): ");
                respuesta = Console.ReadLine();
                Console.WriteLine("\n------------------------------------------\n");
            } while (respuesta.Equals("S"));

            Console.WriteLine("Programa finalizado");
        }
    }
}
