using C12_Entidades_02;
using System;

namespace C12_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo un documento:
            Documento documento = new Documento(2);
            //Creo una factura con el número 10
            Factura factura1 = new Factura(10);
            //Creo un recibo con el número 1
            Recibo recibo1 = new Recibo(1);
            //Creo otro recibo pero con el número 26
            Recibo recibo2 = new Recibo(26);

            /*
            **RECORDAR QUE**
            where T : Documento
            where U : Documento, new()           
            */

            //Creo una instancia de la clase genérica contabilidad. Me permite crearla porque Factura (T) es una clase derivada de Documento, y Recibo (U) es una clase derivada
            //  de Documento que tiene un constructor público sin parámetros.
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            //Intento crear una instancia de la clase genérica contabilidad. No me permite crearla porque, si bien Recibo (T) es una clase derivada de Documento, y Documento (U) es la
            //  clase misma, no tiene constructor sin parámetros.
            //Contabilidad<Recibo, Documento> contabilidad2 = new Contabilidad<Recibo, Documento>();

            //Creo una instancia de la clase genérica contabilidad. Me permite crearla porque Documento (T) es en sí la clase Documento, y Recibo (U) es una clase derivada
            //  de Documento que tiene un constructor público sin parámetros.
            Contabilidad<Documento, Recibo> contabilidad3 = new Contabilidad<Documento, Recibo>();

            //Intento crear una instancia de la clase genérica contabilidad. No me permite crearla porque, si bien Recibo (T) es una clase derivada de documento, y Factura (U) es una
            //  clase derivada de Documento, esta no posee un constructor público sin parámetros.
            //Contabilidad<Recibo, Factura> contabilidad4 = new Contabilidad<Recibo, Factura> ();

            //Cargo los documentos y los muestro en contabilidad:
            contabilidad = contabilidad + factura1;
            contabilidad = contabilidad + recibo1;
            Console.WriteLine($"Primera contabilidad:\n{contabilidad.ToString()}");
            Console.WriteLine("***********************");

            //Cargo los documentos y los muestro en contabilidad3:
            contabilidad3 = contabilidad3 + factura1;
            contabilidad3 = contabilidad3 + documento;
            contabilidad3 = contabilidad3 + recibo1;
            contabilidad3 = contabilidad3 + recibo2;
            Console.WriteLine($"Segunda contabilidad:\n{contabilidad3.ToString()}");
            Console.WriteLine("***********************");

        }
    }
}
