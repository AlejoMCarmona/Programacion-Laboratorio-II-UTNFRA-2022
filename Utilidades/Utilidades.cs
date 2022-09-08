using System;
using System.Linq;

namespace Utilidades
{
    public static class Utilidades
    {
        public static int IngresarEntero(string mensaje, string mensajeError)
        {
            int numero;
            bool flag;

            do
            {
                Console.Write(mensaje);
                flag = int.TryParse(Console.ReadLine(), out numero);
                if (!flag) Console.WriteLine(mensajeError);
            } while (!flag);

            return numero;
        }

        public static int IngresarEnteroPositivo(string mensaje, string mensajeError)
        {
            int numero;

            do
            {
                numero = IngresarEntero(mensaje, mensajeError);
                if (numero < 0) Console.WriteLine(mensajeError);
            } while (numero < 0);

            return numero;
        }

        public static int IngresarEnteroEntreRangos(string mensaje, string mensajeError, int minimo, int maximo)
        {
            int numero;
            bool flag;

            do
            {
                Console.Write(mensaje);
                flag = int.TryParse(Console.ReadLine(), out numero);
                if (!flag || numero < minimo || numero > maximo) Console.WriteLine(mensajeError);
            } while (!flag || numero < minimo || numero > maximo);

            return numero;
        }

        public static double IngresarDouble(string mensaje, string mensajeError)
        {
            double numero;
            bool flag;

            do
            {
                Console.Write(mensaje);
                flag = double.TryParse(Console.ReadLine(), out numero);
                if (!flag) Console.WriteLine(mensajeError);
            } while (!flag);

            return numero;
        }

        public static string IngresarSoloLetras (string mensaje, string mensajeError)
        {
            bool flag;
            string mensajeRetorno;

            do
            {
                Console.Write(mensaje);
                mensajeRetorno = Console.ReadLine();
                flag = mensajeRetorno.Any(c => char.IsDigit(c));
                if (flag || String.IsNullOrEmpty(mensajeRetorno)) Console.WriteLine(mensajeError);
            } while (flag || String.IsNullOrEmpty(mensajeRetorno));

            return mensajeRetorno;
        }
    }
}
