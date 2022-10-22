using System;

namespace C21_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero = 0;
            string ingreso = "";

            do
            {
                try
                {
                    Console.Write("Ingrese un número entero: ");
                    ingreso = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(ingreso))
                    {
                        Console.WriteLine("Operación cancelada.");
                        continue;
                    }
                    numero = long.Parse(ingreso);
                    Console.WriteLine($"Número de                 {numero.ContarCantidadDeDigitos()} dígitos");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!String.IsNullOrWhiteSpace(ingreso));

            Console.WriteLine("");
            Console.WriteLine("¡Programa finalizado!");
        }
    }
}
