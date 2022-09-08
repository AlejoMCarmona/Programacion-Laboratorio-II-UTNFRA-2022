using C3_Entidades_04;
using System;
using Utils = Utilidades.Utilidades;

namespace C4_Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            //Boligrafo 1:
            Console.WriteLine("Boligrafo 1:");
            Console.WriteLine("Color: {0}", boligrafo1.GetColor());
            Console.WriteLine("Cantidad de tinta: {0}", boligrafo1.GetTinta());
            Console.WriteLine("Pinto con un gasto de 30: {0}", boligrafo1.Pintar(30, out dibujo));
            Console.Write("Dibujo realizado: ");
            Console.ForegroundColor = boligrafo1.GetColor();
            Console.WriteLine(dibujo);
            Console.ResetColor();
            Console.WriteLine("Cantidad de tinta: {0}", boligrafo1.GetTinta());
            Console.WriteLine("Recargo tinta");
            boligrafo1.Recargar();
            Console.WriteLine("Cantidad de tinta: {0}", boligrafo1.GetTinta());

            Console.WriteLine("------------------------------------------");
            //Boligrafo 2:
            Console.WriteLine("Boligrafo 2:");
            Console.WriteLine("Color: {0}", boligrafo2.GetColor());
            Console.WriteLine("Cantidad de tinta: {0}", boligrafo2.GetTinta());
            Console.WriteLine("Pinto con un gasto de 52: {0}", boligrafo2.Pintar(52, out dibujo));
            Console.Write("Dibujo realizado: ");
            Console.ForegroundColor = boligrafo2.GetColor();
            Console.WriteLine(dibujo);
            Console.ResetColor();
            Console.WriteLine("Cantidad de tinta: {0}", boligrafo2.GetTinta());
            Console.WriteLine("Recargo tinta");
            boligrafo2.Recargar();
            Console.WriteLine("Cantidad de tinta: {0}", boligrafo2.GetTinta());
        }
    }
}
