using System;
using System.Text;

namespace C2_Ejercicio_05
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;
            string tablaDeMultiplicar;
            bool flag;

            do
            {
                Console.Write("Ingrese un número entero para hallar su tabla de multiplicación: ");
                flag = int.TryParse(Console.ReadLine(), out numeroEntero);
                if (!flag) Console.WriteLine("ERROR ¡Reingrese un número entero!");
            } while (!flag);

            Console.WriteLine($"Tabla de multiplicar del número {numeroEntero}:");
            tablaDeMultiplicar = Program.CalcularTablaDeMultiplicacion(numeroEntero);
            Console.WriteLine(tablaDeMultiplicar);

        }

        public static string CalcularTablaDeMultiplicacion(int numeroEntero) {
            StringBuilder tablaDeMultiplicar = new StringBuilder();

            for (int i = 1; i < 10; i++)
            {
                tablaDeMultiplicar.Append($"{numeroEntero} x {i} = {numeroEntero*i}\n");
            }

            return tablaDeMultiplicar.ToString();
        }
    }
}
