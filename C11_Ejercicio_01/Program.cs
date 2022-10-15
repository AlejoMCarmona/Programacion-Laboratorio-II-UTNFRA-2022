using C11_Entidades_01;
using System;

namespace C11_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;

            try
            {
                resultado = Calculadora.Add("1");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1,2");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1,2,3,4");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1,2,3");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1,023,3");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1,023,31,29,4,7,9,4,2,5");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1,6,");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1,6, "); //excepción en parte dos
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("  1,  6,   "); //excepción en parte dos
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("  1,  6,   "); //excepción en parte dos
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1 \n2,3");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1 \n2");
                Console.WriteLine($"Resultado: {resultado}");

                resultado = Calculadora.Add("1, \n"); //excepcion
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
