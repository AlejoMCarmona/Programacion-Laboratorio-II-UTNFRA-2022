using System;

namespace C21_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fecha: " + "05/20/2020");
            DateTime fecha1 = new DateTime(2020, 05, 20);

            Console.WriteLine(fecha1.ObtenerPlacaCronicaTV(eEstaciones.Otono));
            Console.WriteLine(fecha1.ObtenerPlacaCronicaTV(eEstaciones.Invierno));
            Console.WriteLine(fecha1.ObtenerPlacaCronicaTV(eEstaciones.Primavera));
            Console.WriteLine(fecha1.ObtenerPlacaCronicaTV(eEstaciones.Verano));
            Console.WriteLine("**************************************");

            Console.WriteLine("Fecha: " + "21/12/2022");
            DateTime fecha2 = new DateTime(2022, 12, 21);

            Console.WriteLine(fecha2.ObtenerPlacaCronicaTV(eEstaciones.Otono));
            Console.WriteLine(fecha2.ObtenerPlacaCronicaTV(eEstaciones.Invierno));
            Console.WriteLine(fecha2.ObtenerPlacaCronicaTV(eEstaciones.Primavera));
            Console.WriteLine(fecha2.ObtenerPlacaCronicaTV(eEstaciones.Verano));
            Console.WriteLine("**************************************");

            Console.WriteLine("Fecha: " + "01/01/2009");
            DateTime fecha3 = new DateTime(2009, 01, 01);

            Console.WriteLine(fecha3.ObtenerPlacaCronicaTV(eEstaciones.Otono));
            Console.WriteLine(fecha3.ObtenerPlacaCronicaTV(eEstaciones.Invierno));
            Console.WriteLine(fecha3.ObtenerPlacaCronicaTV(eEstaciones.Primavera));
            Console.WriteLine(fecha3.ObtenerPlacaCronicaTV(eEstaciones.Verano));
            Console.WriteLine("**************************************");

            Console.WriteLine("Fecha: " + "08/31/2022");
            DateTime fecha4 = new DateTime(2022, 08, 31);

            Console.WriteLine(fecha4.ObtenerPlacaCronicaTV(eEstaciones.Otono));
            Console.WriteLine(fecha4.ObtenerPlacaCronicaTV(eEstaciones.Invierno));
            Console.WriteLine(fecha4.ObtenerPlacaCronicaTV(eEstaciones.Primavera));
            Console.WriteLine(fecha4.ObtenerPlacaCronicaTV(eEstaciones.Verano));
            Console.WriteLine("**************************************");

            Console.WriteLine("Fecha: " + "20/06/2021");
            DateTime fecha5 = new DateTime(2021, 06, 20);

            Console.WriteLine(fecha5.ObtenerPlacaCronicaTV(eEstaciones.Otono));
            Console.WriteLine(fecha5.ObtenerPlacaCronicaTV(eEstaciones.Invierno));
            Console.WriteLine(fecha5.ObtenerPlacaCronicaTV(eEstaciones.Primavera));
            Console.WriteLine(fecha5.ObtenerPlacaCronicaTV(eEstaciones.Verano));
            Console.WriteLine("**************************************");
        }
    }
}
