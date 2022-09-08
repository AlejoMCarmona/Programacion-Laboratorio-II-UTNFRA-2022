using System;
//using SC = System.Console; //para usar alias

namespace C2_Ejercicio_01
{
    class Program
    {
        /*
        EJERCICIO 1:
         Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
         bool Validar(int valor, int min, int max)
         valor: dato a validar.
         min: mínimo valor incluido.
         max: máximo valor incluido.
         Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
         Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
        Importante
         Utilizar variables escalares, NO utilizar vectores/arrays.
        */
        static void Main(string[] args)
        {
            int numero;
            int numeroMinimo = 0;
            int numeroMaximo = 0;
            int acumulador = 0;
            double promedio;
            bool flag;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    numero = IngresarEntero();
                    flag = Validador.Validar(numero, -100, 100);
                    if (!flag) Console.WriteLine("ERROR. ¡Reingrese un número entero entre -100 y 100!");
                } while (!flag);

                if (i == 0)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                } else
                {
                    if (numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                    } else if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                }

                acumulador += numero;
            }

            promedio = (double)acumulador / 10;

            Console.WriteLine("Valor mínimo: {0}", numeroMinimo);
            Console.WriteLine("Valor máximo: {0}", numeroMaximo);
            Console.WriteLine("Promedio: {0}", promedio);
        }

        public static int IngresarEntero()
        {
            int numero;
            bool flag;

            do
            {
                Console.Write("Ingrese un número: ");
                flag = int.TryParse(Console.ReadLine(), out numero);
                if (!flag) Console.WriteLine("ERROR. ¡Reingrese el número nuevamente!");
            } while (!flag);

            return numero;
        }
    }
}
