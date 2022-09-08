using System;

namespace C1_Ejercicio_05
{
    class Program
    {
        /*
        EJERCICIO 5:
         Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
         El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
         El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
         Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
        Importante
         Utilizar sentencias de iteración y selectivas.
        */
        static void Main(string[] args)
        {
            int numero;
            int acumuladorUno = 0;
            int acumuladorDos = 0;
            bool flag; 

            Console.WriteLine("CALCULADORA DE CENTROS NUMÉRICOS:");
            Console.Write("Ingrese un número por consola: ");
            flag = int.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i < numero; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    acumuladorDos = 0;
                    for (int k = j + 1; k <= i; k++)
                    {
                        acumuladorDos += k;
                    }

                    if (acumuladorUno == acumuladorDos)
                    {
                        Console.WriteLine(j);
                    }

                    acumuladorUno += j;
                }
                acumuladorUno = 0;
            }

        }
    }
}
