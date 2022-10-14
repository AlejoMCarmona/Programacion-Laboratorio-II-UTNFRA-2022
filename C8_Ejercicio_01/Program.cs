using C8_Entidades_01;
using System;

namespace C8_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(8, 2, Colores.Rojo, 500);
            Automovil automovil = new Automovil(4, 4, Colores.Rojo, 5, 5);
            Moto moto = new Moto(2, 0, Colores.Rojo, 5, 250);

            Console.WriteLine("****CAMION****");
            Console.WriteLine(camion.Mostrar());
            Console.WriteLine("****AUTOMOVIL****");
            Console.WriteLine(automovil.Mostrar());
            Console.WriteLine("****MOTO****");
            Console.WriteLine(moto.Mostrar());
        }
    }
}
