
using C15_EntidadesCentralita_06;
using System;

namespace C15_EjercicioCentralita_06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retorno;

            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local(30, "Bernal", "Rosario", 2.65f);
            Provincial l2 = new Provincial(eFranja.Franja_1, 21, "Morón", "Bernal");
            Local l3 = new Local(45, "Lanús", "San Rafael", 1.99f);
            Provincial l4 = new Provincial(eFranja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            try
            {
                retorno = c + l1;
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                retorno = c + l2;
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                retorno = c + l3;
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                retorno = c + l4; // No se agregará porque l2 == l4 y l2 está en centralita
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Ordeno todas las llamadas por duración
            c.OrdenarLlamadas();

            // Muestro los datos de la centralita
            Console.WriteLine(c.ToString());

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Datos del archivo 'bitácora':");
            Console.WriteLine(c.Leer());
            Console.WriteLine("**************************************************************");

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Leo del archivo XML la primer llamada a local realizada:");
            try
            {
                Console.WriteLine(((Local)c.Llamadas[1]).Leer());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("**************************************************************");

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Leo del archivo XML la primer llamada a provincial realizada:");
            try
            {
                Console.WriteLine(((Provincial)c.Llamadas[0]).Leer());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("**************************************************************");

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Intento leer del archivo XML la primer llamada a local, pero lanzará una excepción porque la ruta corresponde a una llamada provincial:");
            try
            {
                Local l = (Local)c.Llamadas[0];
                l.RutaDeArchivo = "Provincial-Moron-Bernal.xml";
                Console.WriteLine(l.Leer());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("**************************************************************");

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Intento leer del archivo XML la primer llamada a provincial, pero lanzará una excepción porque la ruta corresponde a una llamada local:");
            try
            {
                Provincial p = (Provincial)c.Llamadas[1];
                p.RutaDeArchivo = "Local-Bernal-Rosario.xml";
                Console.WriteLine(p.Leer());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("**************************************************************");

            Console.ReadKey();
        }
    }
}
