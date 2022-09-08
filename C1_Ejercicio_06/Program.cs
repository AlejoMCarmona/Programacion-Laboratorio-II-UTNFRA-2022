using System;

namespace C1_Ejercicio_06
{
    /*
    EJERCICIO 6:
     Escribir un programa que determine si un año es bisiesto.
     Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.
     Por ejemplo: el año 2000 es bisiesto pero 1900 no.
     Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
    Importante
     Utilizar sentencias de iteración, selectivas y el operador módulo (%).
    */
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;
            bool flag;

            do
            {
                Console.Write("Ingrese un anio de inicio: ");
                flag = int.TryParse(Console.ReadLine(), out anioInicio);
                if (!flag) Console.WriteLine("ERROR. ¡Reingrese el anio nuevamente!");
            } while (!flag);

            do
            {
                Console.Write("Ingrese un anio de finalización: ");
                flag = int.TryParse(Console.ReadLine(), out anioFin);
                if (!flag) Console.WriteLine("ERROR. ¡Reingrese el anio nuevamente!");   
            } while (!flag);

            Console.WriteLine("\nAnios bisiestos del {0} al {1}:", anioInicio, anioFin);
            for (int i = anioInicio; i <= anioFin; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0 && i % 400 != 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }

        }
    }
}
