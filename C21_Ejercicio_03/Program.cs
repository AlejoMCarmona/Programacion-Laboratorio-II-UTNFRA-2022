using System;

namespace C21_Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "Hola, cómo estás? Yo muy bien, ansioso por empezar a programar; aunque tengo ganas de mirar una serie también. " +
                            "Qué tengas buena semana.";

            Console.WriteLine(mensaje);
            Console.WriteLine($"Cantidad de signos de puntuacion: {mensaje.ObtenerCantidadSignosPuntuacion()}");

            mensaje = "Hola";
            Console.WriteLine(mensaje);
            Console.WriteLine($"Cantidad de signos de puntuacion: {mensaje.ObtenerCantidadSignosPuntuacion()}");
        }
    }
}
