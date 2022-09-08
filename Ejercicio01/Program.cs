using System;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
            //--DIFERENTES TIPOS DE DATOS:
            int numero1 = 2;
            float numero2 = 2;
            string cadena = "Alejo";
            bool boolean = true;
            double numeroDouble = 20;
            //numero1 = numeroDouble; //no se puede porque hacer una conversión implicita aunque parezca que sí.
            numero1 = (int)numeroDouble; //mediante un cast, puedo.
            numero1 = int.Parse("1"); //para parsear de un string a un entero:

            //MOSTRAR MENSAJES:
            Console.WriteLine("MOSTRAR MENSAJES:");
            Console.WriteLine("Hello World! I show number " + numero1 + "\n" +
                              "This is a float: " + 2 + "\n" +
                              "My name is: " + cadena + "\n" +
                              "This is: " + boolean + "\n");

            //RECIBIR DATOS DESDE CONSOLA:
            Console.WriteLine("\nRECIBIR DATOS DESDE CONSOLA");
            Console.WriteLine("Escribi un numero: ");
            cadena = Console.ReadLine();
            Console.WriteLine("Primera forma: Ingresaste " + cadena);
            Console.WriteLine("Ingresaste {0}", cadena);

            //PARA TOMAR LA TECLA PULSADA (para saber nada más):
            Console.WriteLine("\nPARA TOMAR LA TECLA PULSADA");
            cadena = Console.ReadKey().Key.ToString();
            Console.WriteLine("Pulsaste la tecla " + cadena);

            //ESTRUCTURAS ITERATIVAS:
            Console.WriteLine("\nESTRUCTURAS ITERATIVAS");
            //FOREACH: sirve para recorrer una lista, array, cadena, sin necesidada de especificar indices.
            foreach (char letra in cadena)
            {
                Console.WriteLine(letra); //obtengo las letras de la cadena por separado.
            }
            //YA CONOCIDAS:
            /*
            for (int i = 0; i < 10; i++)
            while (true)
            do
            {

            } while (true);
            */

            //ARRAYS:
            Console.WriteLine("\nARRAYS");
            int[] arrayNumeros = new int[10]; //defino un array de enteros de 10 elementos.
            //el 'new' dice "reservame memoria para esta cantidad de este tipo de dato".
        }
    }
}
