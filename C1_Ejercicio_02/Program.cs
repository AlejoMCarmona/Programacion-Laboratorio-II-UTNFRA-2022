using System;

namespace C1_Ejercicio_02
{
    class Program
    {
        /*
            EJERCICIO 2 - Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
            Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
        */
        static void Main(string[] args)
        {          
            double numero;
            double cuadrado;
            double cubo;
            bool flag;

            do
            {
                Console.Write("Ingrese un número para calcular su potencia y cubo: ");
                flag = double.TryParse(Console.ReadLine(), out numero); //el TryParse devuelve verdadero/falso según si pudo parsear el dato o no; si se pudo realizar, el valor parseado se devuelve en la variable numero de salida.
                if (!flag || numero <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            } while (!flag || numero <= 0);

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El número es: {0}\n" +
                              "Potencia: {1}\n" +
                              "Cubo: {2}\n",
                              numero, cuadrado, cubo);
        }
    }
}
