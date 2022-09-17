using System;

namespace C7_Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resultadoAgregarJugador;
            Equipo equipo = new Equipo(4, "Lanús");
            Jugador j1 = new Jugador(12456789, "Lautaro Acosta");
            Jugador j2 = new Jugador(15935728, "Jose Sand", 300, 800);
            Jugador j3 = new Jugador(12456789, "Luis Acosta");
            Jugador j4 = new Jugador(12345678, "Pepo De La Vega", 12, 30);
            Jugador j5 = new Jugador(15735978, "Diego Valeri", 240, 700);
            Jugador j6 = new Jugador(14725836, "Lautaro Morales");

            Console.WriteLine($"Cantidad de jugadores del equipo actual: {equipo.Jugadores.Count}");

            resultadoAgregarJugador = equipo + j1;
            Console.WriteLine($"¿El jugador se agrego?: {resultadoAgregarJugador}");
            Console.WriteLine($"Cantidad de jugadores del equipo actual: {equipo.Jugadores.Count}");

            resultadoAgregarJugador = equipo + j2;
            Console.WriteLine($"¿El jugador se agrego?: {resultadoAgregarJugador}");
            Console.WriteLine($"Cantidad de jugadores del equipo actual: {equipo.Jugadores.Count}");

            resultadoAgregarJugador = equipo + j3;
            Console.WriteLine($"¿El jugador se agrego?: {resultadoAgregarJugador}");
            Console.WriteLine($"Cantidad de jugadores del equipo actual: {equipo.Jugadores.Count}");

            resultadoAgregarJugador = equipo + j4;
            Console.WriteLine($"¿El jugador se agrego?: {resultadoAgregarJugador}");
            Console.WriteLine($"Cantidad de jugadores del equipo actual: {equipo.Jugadores.Count}");

            resultadoAgregarJugador = equipo + j5;
            Console.WriteLine($"¿El jugador se agrego?: {resultadoAgregarJugador}");
            Console.WriteLine($"Cantidad de jugadores del equipo actual: {equipo.Jugadores.Count}");

            resultadoAgregarJugador = equipo + j6;
            Console.WriteLine($"¿El jugador se agrego?: {resultadoAgregarJugador}");
            Console.WriteLine($"Cantidad de jugadores del equipo actual: {equipo.Jugadores.Count}");

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("PROMEDIO DE GOLES:");
            Console.WriteLine($"{equipo.Jugadores[0].Nombre}: {equipo.Jugadores[0].PromedioGoles}");
            Console.WriteLine($"{equipo.Jugadores[1].Nombre}: {equipo.Jugadores[1].PromedioGoles}");
            Console.WriteLine($"{equipo.Jugadores[2].Nombre}: {equipo.Jugadores[2].PromedioGoles}");
            Console.WriteLine($"{equipo.Jugadores[3].Nombre}: {equipo.Jugadores[3].PromedioGoles}");

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("DATOS DE JUGADORES:");
            Console.WriteLine($"{equipo.Jugadores[0].MostrarDatos()}");
            Console.WriteLine($"{equipo.Jugadores[1].MostrarDatos()}");
            Console.WriteLine($"{equipo.Jugadores[2].MostrarDatos()}");
            Console.WriteLine($"{equipo.Jugadores[3].MostrarDatos()}");

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("COMPARACION DE JUGADORES:");
            Console.WriteLine($"¿Son iguales?: {equipo.Jugadores[0] == j3}");
            Console.WriteLine($"¿Son iguales?: {equipo.Jugadores[0] == j2}");
            Console.WriteLine($"¿Son iguales?: {equipo.Jugadores[0] == j1}");
            Console.WriteLine($"¿Son iguales?: {equipo.Jugadores[3] == j4}");
        }
    }
}
