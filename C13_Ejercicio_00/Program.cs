using System;

namespace C13_Ejercicio_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Leon l = new Leon();
            Arana a = new Arana();

            Console.WriteLine(l.Cazador());
            Console.WriteLine(a.Cazador());
            Console.WriteLine(p.Cazador());
        }
    }
}
