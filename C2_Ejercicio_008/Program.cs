using System;

namespace C2_Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int anio;
            bool flag;
            bool fechaValida;
            int diasTranscurridos;

            do
            {
                do
                {
                    Console.Write("Ingrese el día de nacimiento: ");
                    flag = int.TryParse(Console.ReadLine(), out dia);
                    if (!flag || dia > 31 || dia < 1) Console.WriteLine("ERROR ¡Ingrese un día válido!");
                } while (!flag || dia > 31 || dia < 1);

                do
                {
                    Console.Write("Ingrese el mes de nacimiento: ");
                    flag = int.TryParse(Console.ReadLine(), out mes);
                    if (!flag || mes > 12 || mes < 1) Console.WriteLine("ERROR ¡Ingrese mes válido!");
                } while (!flag || mes > 12 || mes < 1);

                do
                {
                    Console.Write("Ingrese el anio de nacimiento: ");
                    flag = int.TryParse(Console.ReadLine(), out anio);
                    if (!flag || anio > DateTime.Now.Year) Console.WriteLine("ERROR ¡Ingrese un anio válido!");
                } while (!flag || anio > DateTime.Now.Year);

                try
                {
                    new DateTime(anio, mes, dia);
                    fechaValida = true;
                }
                catch (Exception)
                {
                    fechaValida = false;
                    Console.WriteLine("ERROR. La fecha ingresada no es válida. Intentelo nuevamente.\n");
                }
            } while (!fechaValida);

            Console.WriteLine("");
            diasTranscurridos = CalcularDiasTranscurridos(dia, mes, anio);
            Console.WriteLine("Dias transcurridos desde la fecha ingresada hasta el día de hoy: {0}", diasTranscurridos);
        }

        public static int CalcularDiasTranscurridos(int dia, int mes, int anio)
        {
            DateTime fechaNacimiento = new DateTime(anio, mes, dia);
            DateTime fechaActual = DateTime.Now.Date;
            int contadorDias = 0;

            while (DateTime.Compare(fechaNacimiento, fechaActual) != 0)
            {
                fechaNacimiento = fechaNacimiento.AddDays(1);
                contadorDias++;
            }

            return contadorDias;
        }
    }
}
