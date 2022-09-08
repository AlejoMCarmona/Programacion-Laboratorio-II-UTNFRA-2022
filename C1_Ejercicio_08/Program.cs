using System;

namespace C1_Ejercicio_08
{
    class Program
    {
        /*
        EJERCICIO 8:
         Escribir un programa que imprima por consola un triángulo como el siguiente
         *
         ***
         *****
         *******
         *********
         El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
        Importante
         Utilizar sentencias de iteración y selectivas. 
        */
        static void Main(string[] args)
        {
            int altura;
            string triangulo = "";
            string filaAnterior = "";
            bool flag;

            Console.WriteLine("TRIANGULO:");

            do
            {
                Console.Write("Ingrese la altura deseada para el triangulo: ");
                flag = int.TryParse(Console.ReadLine(), out altura);
                if (!flag || altura < 0) Console.WriteLine("ERROR ¡Ingrese una altura válida (solo números enteros)!");
            } while (!flag || altura < 0);

            for (int i = 0; i < altura; i++)
            {
                if (i == 0)
                {
                    filaAnterior = "*";
                    triangulo = filaAnterior + "\n";
                    continue;
                }
                triangulo += filaAnterior + "**\n";
                filaAnterior += "**";
            }

            Console.WriteLine("Triangulo de altura {0}:", altura);
            Console.WriteLine(triangulo);
        }
    }
}
