using C12_Ejercicio_01;
using System;

namespace C12_EjercicioM_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resultado;
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo futbol");
            EquipoFutbol ef1 = new EquipoFutbol("futbol1", DateTime.Now);
            EquipoFutbol ef2 = new EquipoFutbol("futbol2", DateTime.Now);
            EquipoFutbol ef3 = new EquipoFutbol("futbol3", DateTime.Now);

            resultado = torneoFutbol + ef1;
            resultado = torneoFutbol + ef2;
            resultado = torneoFutbol + ef3;

            Console.WriteLine(torneoFutbol.ToString());
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");

            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo basquet");
            EquipoBasquet eb1 = new EquipoBasquet("basquet1", DateTime.Now);
            EquipoBasquet eb2 = new EquipoBasquet("basquet2", DateTime.Now);
            EquipoBasquet eb3 = new EquipoBasquet("basquet3", DateTime.Now);

            resultado = torneoBasquet + eb1;
            resultado = torneoBasquet + eb2;
            resultado = torneoBasquet + eb3;

            Console.WriteLine(torneoBasquet.ToString());
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
        }
    }
}
