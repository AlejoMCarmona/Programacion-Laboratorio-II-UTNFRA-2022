using System;

namespace C2_Ejercicio_03
{
    class Program
    {
        /*
        EJERCICIO 3:
         Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
         El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario
          + public string ConvertirDecimalABinario(int numeroEntero) {}
        El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal
          + public int ConvertirBinarioADecimal(int numeroEntero) {}
        */
        static void Main(string[] args)
        {
            int numeroDecimal;
            string numeroBinario;

            numeroBinario = Conversor.ConvertirDecimalABinario(169);
            numeroDecimal = Conversor.ConvertirBinarioADecimal(1101101);

            Console.WriteLine("Numero decimal en binario: {0} ", numeroBinario);
            Console.WriteLine("Numero binario en decimal: {0}", numeroDecimal);
        }
    }
}
