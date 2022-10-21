using Duda_Entidades;
using System;

namespace Duda
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            int numero1;
            int numero2;

            numero1 = 2;
            numero2 = 0;

            //Capturo las excepciones:
            try
            {
                resultado = Clase.DividirSinTryCatch(numero1, numero2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                resultado = Clase.DividirConTryCatch(numero1, numero2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
