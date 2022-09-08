using System;

namespace C1_Ejercicio_04
{
    /*
    EJERCICIO 4:
     Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
     El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
     Escribir una aplicación que encuentre los 4 primeros números perfectos.
    Importante
     Utilizar sentencias de iteración y selectivas.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int contadorNumerosPerfectos = 0;
            int contadorNumero = 1;
            int acumuladorDivisores = 0;

            Console.WriteLine("Primeros 4 números perfectos:");

            while (contadorNumerosPerfectos < 4)
            {
                for (int i = 1; i < contadorNumero; i++)
                {
                    if (contadorNumero % i == 0)
                    {
                        acumuladorDivisores += i;
                    }
                }

                if (acumuladorDivisores == contadorNumero)
                {
                    Console.WriteLine(contadorNumero);
                    contadorNumerosPerfectos++;
                }
                contadorNumero++;
                acumuladorDivisores = 0;
            }

        }
    }
}
