using C7_Entidades_02;
using System;

namespace C7_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro l1 = new Libro();
            Console.WriteLine(l1[0]);
            l1[0] = "Primera página del libro";
            l1[99] = "Segunda página del libro";
            Console.WriteLine(l1[16]);
            l1[1] = "Segunda página del libro sobreescrita";
            l1[99] = "Tercera página del libro";
            Console.WriteLine(l1[0]);
            Console.WriteLine(l1[1]);
            Console.WriteLine(l1[2]);
        }
    }
}
