using Billetes;
using System;

namespace C4_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Peso peso = new Peso(100);
            Euro euro = new Euro(120);
            Dolar dolar = new Dolar(20);

            //PROBANDO SOBRECARGAS EXPLICITAS DE OPERADORES DE CONVERSION
            Console.WriteLine("Sobrecargas explicitas de operadores de conversion");
            Console.WriteLine("Peso: ");
            //testeo las de peso
            Dolar auxDolar = (Dolar)peso;
            Console.WriteLine("100 pesos son {0} dolares", auxDolar.GetCantidad());
            Euro auxEuro = (Euro)peso;
            Console.WriteLine("100 pesos son {0} euros", auxEuro.GetCantidad());
            Console.WriteLine("----------------------------");

            //testeo las de euro
            Console.WriteLine("Euro: ");
            auxDolar = (Dolar)euro;
            Console.WriteLine("120 euros son {0} dolares", auxDolar.GetCantidad());
            Peso auxPeso = (Peso)euro;
            Console.WriteLine("120 euros son {0} pesos", auxPeso.GetCantidad());
            Console.WriteLine("----------------------------");

            //testeo las de dolar
            Console.WriteLine("Dolar: ");
            auxEuro = (Euro)dolar;
            Console.WriteLine("20 dolares son {0} euros", auxEuro.GetCantidad());
            auxPeso = (Peso)dolar;
            Console.WriteLine("20 dolares son {0} pesos", auxPeso.GetCantidad());
            Console.WriteLine("----------------------------");

            //PROBANDO SOBRECARGAS IMPLICITAS DE OPERADORES DE CONVERSION 
            Console.WriteLine("Sobrecargas implícitas de operadores de conversion");
            auxDolar = (Dolar)200;
            Console.WriteLine("Cantidad de dolar: {0}", auxDolar.GetCantidad());
            auxPeso = (Peso)100;
            Console.WriteLine("Cantidad de peso: {0}", auxPeso.GetCantidad());
            auxEuro = (Euro)300;
            Console.WriteLine("Cantidad de euro: {0}", auxEuro.GetCantidad());
            Console.WriteLine("----------------------------");

            //PROBANDO SOBRECARGAS DE OPERADORES
            //testeo las de peso
            Console.WriteLine("Peso: ");
            Console.WriteLine(peso == auxPeso);
            Console.WriteLine(peso != auxPeso);
            Console.WriteLine(peso == dolar);
            Console.WriteLine(peso != dolar);
            Console.WriteLine(peso == euro);
            Console.WriteLine(peso != euro);
            Console.WriteLine($"100 pesos + 20 dolares = {(peso + dolar).GetCantidad()}");
            Console.WriteLine($"100 pesos - 20 dolares = {(peso - dolar).GetCantidad()}");
            Console.WriteLine($"100 pesos + 120 euros = {(peso + euro).GetCantidad()}");
            Console.WriteLine($"100 pesos - 120 euros = {(peso - euro).GetCantidad()}");
            Console.WriteLine("----------------------------");

            //testeo las de dolar
            Console.WriteLine("Dolar: ");
            Console.WriteLine(dolar == auxDolar);
            Console.WriteLine(dolar != auxDolar);
            Console.WriteLine(dolar == peso);
            Console.WriteLine(dolar != peso);
            Console.WriteLine(dolar == euro);
            Console.WriteLine(dolar != euro);
            Console.WriteLine($"20 dolares + 100 pesos = {(dolar + peso).GetCantidad()}");
            Console.WriteLine($"20 dolares - 100 pesos = {(dolar - peso).GetCantidad()}");
            Console.WriteLine($"20 dolares + 120 euros = {(dolar + euro).GetCantidad()}");
            Console.WriteLine($"20 dolares - 120 euros = {(dolar - euro).GetCantidad()}");
            Console.WriteLine("----------------------------");

            //testeo las de euro
            Console.WriteLine("Euro: ");
            Console.WriteLine(euro == auxEuro);
            Console.WriteLine(euro != auxEuro);
            Console.WriteLine(euro == peso);
            Console.WriteLine(euro != peso);
            Console.WriteLine(euro == dolar);
            Console.WriteLine(euro != dolar);
            Console.WriteLine($"120 euros + 100 pesos = {(euro + peso).GetCantidad()}");
            Console.WriteLine($"120 euros - 100 pesos = {(euro - peso).GetCantidad()}");
            Console.WriteLine($"120 euros + 20 dolares = {(euro + dolar).GetCantidad()}");
            Console.WriteLine($"120 euros - 20 dolares = {(euro - dolar).GetCantidad()}");
            Console.WriteLine("----------------------------");
        }
    }
}
