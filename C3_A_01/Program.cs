using EmpresaTransporte;
using System;
using Utils = Utilidades.Utilidades;

namespace C3_A_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa;
            string nombre;
            int[] kmsRecorridos = new int[7];

            nombre = Utils.IngresarSoloLetras("Ingrese el nombre de la empresa: ", "¡ERROR! Reingrese el nombre de la empresa: ");
            empresa = new Empresa(nombre);
            
            for (int i = 0; i < 3; i++) //El enunciado me pide 3 conductores.
            {
                Console.WriteLine("Conductor n°{0}", i + 1);
                nombre = Utils.IngresarSoloLetras("Ingrese el nombre del conductor: ", "¡ERROR! Reingrese el nombre del conductor: ");

                for (int j = 0; j < 7; j++)
                {
                    kmsRecorridos[j] = Utils.IngresarEnteroPositivo($"Ingrese la cantidad de KMs recorridos en el día {j+1}: ", $"¡ERROR! Reingrese la cantidad de KMs recorridos en el día {j+1}: ");
                }

                empresa.SetNuevoConductor(nombre, kmsRecorridos);

                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("Conductor que hizo más km en esa semana: {0}", empresa.HallarConductorConMaximoKMEnLaSemana().Mostrar());
            Console.WriteLine("Conductor que hizo más km el día 3: {0}", empresa.HallarConductorConMaximoKMEnUnDia(3).Mostrar());
            Console.WriteLine("Conductor que hizo más km el día 5: {0}", empresa.HallarConductorConMaximoKMEnUnDia(5).Mostrar());
        }
    }

    /*
     * DATOS USADOS PARA PROBAR:
     * 
     * Conductor 1:
     * nombre: Juan
     * kmsRecorridos = { 100, 200, 150, 300, 600, 120, 100 } ; totales de la semana = 1570
     * Conductor 2:
     * nombre: Pedro
     * kmsRecorridos = { 0, 0, 201, 400, 60, 10, 1000 } ; totales de la semana = 1671
     * Conductor 3:
     * nombre: Ernesto
     * kmsRecorridos = { 700, 220, 940, 210, 500, 321, 800 } ; totales de la semana = 3691 
     */
}
