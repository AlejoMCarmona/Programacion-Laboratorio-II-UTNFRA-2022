using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             EJERCICIO 1:
             Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: 
                - el valor máximo
                - el valor mínimo
                - el promedio.
            */
            double numero;
            double valorMaximo = 0; //lo inicializo sí o sí porque si no VS lo detecta como error.
            double valorMinimo = 0;
            double acumulador = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + " - Ingrese un número: ");
                numero = double.Parse(Console.ReadLine());

                if (i == 1)
                {
                    valorMaximo = numero;
                    valorMinimo = numero;
                } else
                {
                    if (numero > valorMaximo)
                    {
                        valorMaximo = numero;
                    } else if (numero < valorMinimo)
                    {
                        valorMinimo = numero;
                    }
                }
                acumulador += numero;
            }

            Console.WriteLine("\nRESULTADOS:");
            Console.WriteLine("Valor maximo: {0}", valorMaximo);
            Console.WriteLine("Valor minimo: {0}", valorMinimo);
            Console.WriteLine("Promedio: {0}", acumulador/5);
        }
    }
}
