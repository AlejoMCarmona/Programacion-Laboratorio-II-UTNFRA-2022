using C6_Entidades_05;
using System;

namespace C6_Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(10, 5);

            AutoF1 a1 = new AutoF1(1, "Ferrari");
            AutoF1 a2 = new AutoF1(2, "Volkswagen");
            AutoF1 a3 = new AutoF1(3, "Bugatti");
            AutoF1 a4 = new AutoF1(10, "Ferrari");
            AutoF1 a5 = new AutoF1(2, "Volkswagen");
            AutoF1 a6 = new AutoF1(2, "Ferrari");
            AutoF1 a7 = new AutoF1(2, "Bugatti");

            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");
            if (competencia + a1)
            {
                Console.WriteLine("Se agregó el auto. Número: 1; Marca: Ferrari");
            }
            else
            {
                Console.WriteLine("No se agregó el auto. Número: 1; Marca: Ferrari");
            }

            if (competencia + a2)
            {
                Console.WriteLine("Se agregó el auto. Número: 2; Marca: Volkswagen");
            }
            else
            {
                Console.WriteLine("No se agregó el auto. Número: 2; Marca: Volkswagen");
            }

            if (competencia + a3)
            {
                Console.WriteLine("Se agregó el auto. Número: 3; Marca: Bugatti");
            }
            else
            {
                Console.WriteLine("No se agregó el auto. Número: 3; Marca: Bugatti");
            }

            if (competencia + a4)
            {
                Console.WriteLine("Se agregó el auto. Número: 10; Marca: Ferrari");
            }
            else
            {
                Console.WriteLine("No se agregó el auto. Número: 10; Marca: Ferrari");
            }

            if (competencia + a5)
            {
                Console.WriteLine("Se agregó el auto. Número: 2; Marca: Volkswagen");
            }
            else
            {
                Console.WriteLine("No se agregó el auto. Número: 2; Marca: Volkswagen");
            }

            if (competencia + a6)
            {
                Console.WriteLine("Se agregó el auto. Número: 2; Marca: Ferrari");
            }
            else
            {
                Console.WriteLine("No se agregó el auto. Número: 2; Marca: Ferrari");
            }

            if (competencia + a7)
            {
                Console.WriteLine("Se agregó el auto. Número: 2; Marca: Bugatti");
            }
            else
            {
                Console.WriteLine("No se agregó el auto. Número: 2; Marca: Bugatti");
            }
            Console.WriteLine("*******************************");

            Console.WriteLine("*******************************");
            Console.WriteLine("DATOS DE LA COMPETENCIA: ");
            Console.Write(competencia.MostrarDatos());
            Console.WriteLine("*******************************");

            Console.WriteLine("*******************************");

            if (competencia - a7)
            {
                Console.WriteLine("Se quitó el auto. Número: 2; Marca: Bugatti");
            }
            else
            {
                Console.WriteLine("No se quitó el auto. Número: 2; Marca: Bugatti");
            }

            if (competencia - a6)
            {
                Console.WriteLine("Se quitó el auto. Número: 2; Marca: Ferrari");
            }
            else
            {
                Console.WriteLine("No se quitó el auto. Número: 2; Marca: Ferrari");
            }

            if (competencia - a2)
            {
                Console.WriteLine("Se quitó el auto. Número: 2; Marca: Volkswagen");
            }
            else
            {
                Console.WriteLine("No se quitó el auto. Número: 2; Marca: Volkswagen");
            }
            Console.WriteLine("*******************************");

            Console.WriteLine("*******************************");
            Console.WriteLine("COMPARACIONES:");
            if (a1 == a2)
            {
                Console.WriteLine("El auto a1 (Número: 1; Marca: Ferrari) es igual al a2 (Número: 2; Marca: Volkswagen)");
            } else
            {
                Console.WriteLine("El auto a1 (Número: 1; Marca: Ferrari) no es igual al a2 (Número: 2; Marca: Volkswagen)");
            }

            if (a2 == a5)
            {
                Console.WriteLine("El auto a2 (Número: 2; Marca: Volkswagen) es igual al a5 (Número: 2; Marca: Volkswagen)");
            }
            else
            {
                Console.WriteLine("El auto a5 (Número: 2; Marca: Volkswagen) no es igual al a5 (Número: 2; Marca: Volkswagen)");
            }

            if (a1 != a2)
            {
                Console.WriteLine("El auto a1 (Número: 1; Marca: Ferrari) no es igual al a2 (Número: 2; Marca: Volkswagen)");
            }
            else
            {
                Console.WriteLine("El auto a1 (Número: 1; Marca: Ferrari) es igual al a2 (Número: 2; Marca: Volkswagen)");
            }

            if (a2 != a5)
            {
                Console.WriteLine("El auto a5 (Número: 2; Marca: Volkswagen) no es igual al a5 (Número: 2; Marca: Volkswagen)");
            }
            else
            {
                Console.WriteLine("El auto a2 (Número: 2; Marca: Volkswagen) es igual al a5 (Número: 2; Marca: Volkswagen)");
            }

            Console.WriteLine("*******************************");

            Console.WriteLine("*******************************");
            Console.WriteLine("DATOS DE LA COMPETENCIA: ");
            Console.Write(competencia.MostrarDatos());
            Console.WriteLine("*******************************");
        }
    }
}
