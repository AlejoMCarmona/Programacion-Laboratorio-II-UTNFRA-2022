using System;

namespace C2_Ejercicio_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola mundo!";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
        }
    }
}
