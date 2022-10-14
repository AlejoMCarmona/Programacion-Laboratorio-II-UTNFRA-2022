using System;

namespace C10_Ejercicio_00
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = 2;

            try
            {
                resultado = Funcion1();
                Console.WriteLine(resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error en el main: " + ex.Message);
                //Un objeto Exception tiene diferentes propiedades:
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                //se ejecuta siempre
                Console.WriteLine("Bloque finally.");
            }

        }

        public static double Funcion1()
        {
            int numero = 0;
            double resultado = 0;

            try
            {
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
                resultado = 5 / numero;    
            }
            //excepciones específicas
            catch (OverflowException ex)
            {
                //una vez que entró a un catch, ya no puede capturar nuevas excepciones lanzadas, porque es un try que ya se usó.
                Console.WriteLine("Ha ocurrido una excepción de overflow: " + ex.Message);
                throw new ArgumentNullException("Argumento nulo :("); //se lanza una nueva excepción, pero como ya se capturó una excepción en este catch, busca el siguiente catch disponible para capturarla.
                //la excepción ArgumentNullException se capturará en el try-catch del Main.
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Quisiste dividir por cero, y no se puede: " + ex.Message);
            }
            //Al lanzar una excepción, busca un bloque catch en este codigo. Al no encontrarlo, lo busca dónde fue llamado este método.

            return resultado;
        }
    }
}
