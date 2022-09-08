using C4_Entidades_03;
using System;

namespace C4_Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDecimal;
            string numeroBinario;

            Console.WriteLine("PASAJES ENTRE SISTEMAS:");
            numeroBinario = Conversor.ConvertirDecimalABinario(169);
            numeroDecimal = Conversor.ConvertirBinarioADecimal(1101101);

            Console.WriteLine("Numero decimal en binario: {0} ", numeroBinario);
            Console.WriteLine("Numero binario en decimal: {0}", numeroDecimal);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("OPERADORES IMPLÍCITOS:");
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;
            Console.WriteLine("Numero binario creado con un operador implícito: {0} ", objBinario.Numero);
            Console.WriteLine("Numero decimal creado con un operador implícito: {0}", objDecimal.Numero);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("OPERADORES EXPLÍCITOS:");
            string binario = (string)objBinario;
            double nDecimal = (double)objDecimal;
            Console.WriteLine("string binario creado con un operador explícito: {0} ", binario);
            Console.WriteLine("double creado con un operador explícito: {0}", nDecimal);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("OPERACIONES:");
            objBinario = "10111010";
            objDecimal = 1684;
            Console.WriteLine($"10111010 + 1684 = {objBinario + objDecimal}");
            Console.WriteLine($"1684 + 10111010 = {objDecimal + objBinario}");
            Console.WriteLine($"10111010 - 1684 = {objBinario - objDecimal}");
            Console.WriteLine($"1684 - 10111010 = {objDecimal - objBinario}");
            Console.WriteLine($"10111010 == 1684 = {objBinario == objDecimal}");
            Console.WriteLine($"1684 == 10111010 = {objDecimal == objBinario}");
            Console.WriteLine($"1684 != 10111010 = {objDecimal != objBinario}");
            Console.WriteLine($"10111010 != 1684 = {objBinario != objDecimal}");

            objBinario = "10100000";
            objDecimal = 160;
            Console.WriteLine($"10100000 == 160 = {objBinario == objDecimal}");
            Console.WriteLine($"160 == 10100000 = {objDecimal == objBinario}");
            Console.WriteLine($"10100000 != 160 = {objBinario != objDecimal}");
            Console.WriteLine($"160 != 10100000 = {objDecimal != objBinario}");
            Console.WriteLine("----------------------------------");
        }
    }
}
