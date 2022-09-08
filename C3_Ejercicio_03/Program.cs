using C3_Entidades_03;
using System;
using Utils = Utilidades.Utilidades;

namespace C3_Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaPrimerParcial;
            int notaSegundoParcial;
            string nombre;
            string apellido;
            string legajo;
            Estudiante[] estudiantes = new Estudiante[3]; //para ingresar 3 estudiantes sin repetir código.

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("ESTUDIANTE {0}:", i+1);
                nombre = Utils.IngresarSoloLetras("Ingrese el nombre del alumno: ", "ERROR ¡Reingrese un nombre válido!");
                apellido = Utils.IngresarSoloLetras("Ingrese el apellido del alumno: ", "ERROR ¡Reingrese un apellido válido!");
                legajo = Utils.IngresarEntero("Ingrese el legajo del alumno: ", "ERROR ¡Reingrese un legajo válido!").ToString();

                estudiantes[i] = new Estudiante(nombre, apellido, legajo);

                notaPrimerParcial = Utils.IngresarEnteroEntreRangos("Ingrese la nota del primer parcial: ", "ERROR ¡Reingrese una nota válida!", 1, 10);
                estudiantes[i].SetNotaPrimerParcial(notaPrimerParcial);

                notaSegundoParcial = Utils.IngresarEnteroEntreRangos("Ingrese la nota del segundo parcial: ", "ERROR ¡Reingrese una nota válida!", 1, 10);
                estudiantes[i].SetNotaSegundoParcial(notaSegundoParcial);
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("RESULTADOS:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(estudiantes[i].Mostrar());
                Console.WriteLine("--------------------------------");
            }
        }
    }
}

/*
carlos gomez 1234 4 6
martina perez 4321 8 9
ezequiel dos 1245 7 3

carlos gomez 1234 4 6 promedio: 5 notafinal: ?
martina perez 4321 8 9 promedio: 8.5 notafinal: ?
ezequiel dos 1245 7 3 promedio: 5 notafinal: desaprobado
*/