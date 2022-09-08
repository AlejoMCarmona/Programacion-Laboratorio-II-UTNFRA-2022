using System;

namespace C2_Ejercicio_02
{
    class Program
    {
        /*
        EJERCICIO 2:
         Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
         Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas
         El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor. 
        */
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            bool flag;
            string opcion;

            do
            {
                Console.WriteLine("-------------------\nSUMADOR DE ENTEROS");
                //cada uno de estos do-while podrian ser una función "IngresarEntero"
                do
                {
                    Console.Write("Ingrese el primer operando entero: ");
                    flag = int.TryParse(Console.ReadLine(), out primerNumero);
                    if (!flag) Console.WriteLine("ERROR ¡Reingrese el número nuevamente!\n"); 
                } while (!flag);
                do
                {
                    Console.Write("Ingrese el segundo operando entero: ");
                    flag = int.TryParse(Console.ReadLine(), out segundoNumero);
                    if (!flag) Console.WriteLine("ERROR ¡Reingrese el número nuevamente!\n");
                } while (!flag);

                Console.WriteLine("RESULTADO: {0}\n", primerNumero + segundoNumero);

                Console.Write("¿Deseas continuar? (S/N): ");
                opcion = Console.ReadLine();
                Console.WriteLine("");
            } while (Validador.ValidarRespuesta(opcion));

            Console.WriteLine("Programa finalizado.");
        }
    }
}
