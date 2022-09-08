using System;
using C3_Entidades_01;

namespace C3_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //No hice un menu para no perder mucho tiempo.
            Cuenta cuenta1 = new Cuenta("123SA", 1000);

            Console.WriteLine($"Datos de la cuenta por defecto:\nTitular: {cuenta1.Titular()}\nMonto: {cuenta1.Cantidad()}");
            Console.WriteLine("");
            Console.WriteLine("Ingreso 250.99 pesos: ");
            cuenta1.Ingresar(250.99M);
            Console.WriteLine($"Datos de la cuenta luego de ingresar dinero:\nTitular: {cuenta1.Titular()}\nMonto: {cuenta1.Cantidad()}");

            Console.WriteLine("");
            Console.WriteLine("Retiro 800 pesos: ");
            cuenta1.Retirar(800);
            Console.WriteLine($"Datos de la cuenta luego de retirar dinero:\nTitular: {cuenta1.Titular()}\nMonto: {cuenta1.Cantidad()}");

            Console.WriteLine("");
            Console.WriteLine("Retiro 600 pesos: ");
            cuenta1.Retirar(800);
            Console.WriteLine($"Datos de la cuenta luego de retirar dinero:\nTitular: {cuenta1.Titular()}\nMonto: {cuenta1.Cantidad()}");
        }
    }
}
