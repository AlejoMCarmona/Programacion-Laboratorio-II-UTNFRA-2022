using System;

namespace C1_Ejercicio_03
{
    class Program
    {
        /*
        EJERCICIO 3:
         Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
         Validar que el dato ingresado por el usuario sea un número.
         Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
         Si ingresa "salir", cerrar la consola.
         Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
        */
        static void Main(string[] args)
        {
            int numero = 0;
            string datoIngresado = "";
            bool flag;
            bool esPrimo = true;

            do
            {
                do
                {
                    Console.Write("Ingrese un número para hallar todos sus primos hasta él; o 'salir' para finalizar: ");
                    datoIngresado = Console.ReadLine();
                    if (datoIngresado == "salir") goto Final;
                    flag = int.TryParse(datoIngresado, out numero);
                    if (!flag || numero <= 1) Console.WriteLine("ERROR. ¡Reingrese el número!"); 
                } while (!flag || numero <=  1);

                for (int i = 2; i <= numero; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0) {
                            esPrimo = false;
                            break;
                        }
                        esPrimo = true;
                    }

                    if (esPrimo) Console.WriteLine(i);
                }

                Console.Write("¿Desea seguir operando? (s para continuar): ");
                datoIngresado = Console.ReadLine();
            } while (datoIngresado == "s");

        Final:
            Console.WriteLine("Programa finalizado.");
        }
    }
}
