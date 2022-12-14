using C14_EntidadesCentralita_05;
using System;

namespace C14_EjercicioCentralita_05
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

            Console.ReadKey();
        }
    }
}
