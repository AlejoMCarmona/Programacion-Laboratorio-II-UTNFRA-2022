using C4_Entidades_01;
using System;

namespace C4_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Creo un objeto tipo sumador sin pasarle parámetros");
            Sumador sumador1 = new Sumador();
            Console.WriteLine("Cantidad de sumas: {0}", sumador1.CantidadSumas);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Creo un objeto tipo sumador pasándole como parámetro 100 sumas");
            Sumador sumador2 = new Sumador(100);
            Console.WriteLine("Cantidad de sumas: {0}", sumador2.CantidadSumas);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Sumo 10 y 20 utilizando sumador1: {0}", sumador1.Sumar(10, 20));
            Console.WriteLine("Cantidad de sumas: {0}", sumador1.CantidadSumas);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Sumo 15 y 30 con sumador2: {0}", sumador2.Sumar(15, 30));
            Console.WriteLine("Concateno dos cadenas utilizando sumador2: {0}", sumador2.Sumar("Hola", "me llamo Alejo"));
            Console.WriteLine("Cantidad de sumas: {0}", sumador2.CantidadSumas);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Pruebo sobrecarga de operadores:");
            Console.WriteLine("Cantidad de sumas del sumador1: {0}", (int)sumador1);
            Console.WriteLine("Cantidad de sumas del sumador2: {0}", (int)sumador2);
            Console.WriteLine("Cantidad de sumas entre el sumador1 y sumador2: {0}", sumador1 + sumador2);
            Console.WriteLine("Igualdad entre la cantidad de sumas de sumador1 y sumador2: {0}", sumador1 | sumador2);
            Console.WriteLine("--------------------------------------");

        }
    }
}
