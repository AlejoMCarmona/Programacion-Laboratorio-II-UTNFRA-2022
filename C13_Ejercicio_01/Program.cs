using C13_Entidades_01;
using System;
using System.Collections.Generic;

namespace C13_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primera parte:
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola, qué tal?");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola, cómo estás?");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();

            //Segunda parte:
            Lapiz lapiz1 = new Lapiz(10);
            Lapiz lapiz2 = new Lapiz(5);
            Boligrafo boligrafo1 = new Boligrafo(5, ConsoleColor.Red);
            Boligrafo boligrafo2 = new Boligrafo(3, ConsoleColor.Green);

            List<IAcciones> elementos = new List<IAcciones>();
            elementos.Add(lapiz1);
            elementos.Add(boligrafo1);
            elementos.Add(lapiz2);
            elementos.Add(boligrafo2);
            CartucheraMultiuso cartucheraM = new CartucheraMultiuso(elementos);

            List<Lapiz> lapices = new List<Lapiz>();
            lapices.Add(lapiz1);
            lapices.Add(lapiz2);
            List<Boligrafo> boligrafos = new List<Boligrafo>();
            boligrafos.Add(boligrafo1);
            boligrafos.Add(boligrafo2);
            CartucheraSimple cartucheraS = new CartucheraSimple(boligrafos, lapices);

            bool resultado = true;

            //Recorro la cartuchera multiuso:
            Console.WriteLine("Recorrido de la cartuchera multiuso:");
            do
            {
                resultado = cartucheraM.RecorrerElementos();
                Console.WriteLine(resultado);
            } while (resultado);

            //Recorro la cartuchera simple:
            Console.WriteLine("Recorrido de la cartuchera simple:");
            do
            {
                resultado = cartucheraS.RecorrerElementos();
                Console.WriteLine(resultado);
            } while (resultado);

            //Creo nuevos lápices y una nueva cartuchera simple:
            List<Lapiz> lapices2 = new List<Lapiz>();
            Lapiz lapiz3 = new Lapiz(6);
            Lapiz lapiz4 = new Lapiz(7);
            lapices2.Add(lapiz3);
            lapices2.Add(lapiz4);
            List<Boligrafo> boligrafos2 = new List<Boligrafo>();
            Boligrafo boligrafo3 = new Boligrafo(20, ConsoleColor.Red);
            Boligrafo boligrafo4 = new Boligrafo(20, ConsoleColor.Green);
            boligrafos2.Add(boligrafo3);
            boligrafos2.Add(boligrafo4);
            CartucheraSimple cartucheraS2 = new CartucheraSimple(boligrafos2, lapices2);

            Console.WriteLine("Recorrido de la segunda cartuchera simple:");
            do
            {
                resultado = cartucheraS2.RecorrerElementos();
                Console.WriteLine(resultado);
            } while (resultado);
        }
    }
}
