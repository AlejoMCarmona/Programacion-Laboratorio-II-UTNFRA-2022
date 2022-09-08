using System;
using C3_Entidades_02;

namespace C3_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan Perez", new DateTime(1970, 09, 01), 20159751);
            Persona persona2 = new Persona("Alejo Carmona", new DateTime(1999, 09, 20), 42146540);
            Persona persona3 = new Persona("Martina Gomez", new DateTime(2005, 04, 29), 43015237);

            Console.WriteLine("---------------");
            Console.WriteLine("Persona 1:");
            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());
            
            Console.WriteLine("---------------");
            Console.WriteLine("Persona 2:");
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());

            Console.WriteLine("---------------");
            Console.WriteLine("Persona 3:");
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());
        }
    }
}
