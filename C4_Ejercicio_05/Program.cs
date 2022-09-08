using C4_Entidades_05;
using System;

namespace C4_Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("CREO 3 TEMPERATURAS SIN PARÁMETROS:");
            Fahrenheit fahrenheit = new Fahrenheit();
            Celsius celsius = new Celsius();
            Kelvin kelvin = new Kelvin();

            Console.WriteLine("Fahrenheit: {0}", fahrenheit.Temperatura);
            Console.WriteLine("Celsius: {0}", celsius.Temperatura);
            Console.WriteLine("Kelvin: {0}", kelvin.Temperatura);
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("CREO 3 TEMPERATURAS CON PARÁMETROS:");
            fahrenheit = new Fahrenheit(100);
            celsius = new Celsius(100);
            kelvin = new Kelvin(100);

            Console.WriteLine("Fahrenheit: {0}", fahrenheit.Temperatura);
            Console.WriteLine("Celsius: {0}", celsius.Temperatura);
            Console.WriteLine("Kelvin: {0}", kelvin.Temperatura);
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("PASAJES (SOBRECARGAS EXPLÍCITAS):");
            Console.WriteLine("100 grados fahrenheit a celsius: {0}", ((Celsius)fahrenheit).Temperatura);
            Console.WriteLine("100 grados fahrenheit a kelvin: {0}", ((Kelvin)fahrenheit).Temperatura);
            Console.WriteLine("100 grados celsius a fahrenheit: {0}", ((Fahrenheit)celsius).Temperatura);
            Console.WriteLine("100 grados celsius a kelvin: {0}", (((Kelvin)celsius).Temperatura));
            Console.WriteLine("100 grados kelvin a fahrenheit: {0}", ((Fahrenheit)kelvin).Temperatura);
            Console.WriteLine("100 grados kelvin a celsius: {0}", ((Celsius)kelvin).Temperatura);
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("SOBRECARGAS IMPLÍCITAS:");
            Console.WriteLine("Creo un fahrenheit de 150");
            fahrenheit = 150;
            Console.WriteLine("Creo un celsius de 25.5");
            celsius = 25.5;
            Console.WriteLine("Creo un fahrenheit de 300");
            kelvin = 150;
            Console.WriteLine("CREACIONES:");
            Console.WriteLine("Fahrenheit: {0}", fahrenheit.Temperatura);
            Console.WriteLine("Celsius: {0}", celsius.Temperatura);
            Console.WriteLine("Kelvin: {0}", kelvin.Temperatura);
            Console.WriteLine("---------------------------------------");
        }
    }
}
