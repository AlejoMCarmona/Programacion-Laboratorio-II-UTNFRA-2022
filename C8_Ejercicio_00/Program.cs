using C8_Entitades_00;
using System;

namespace C8_Ejercicio_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("Clifford", 4, "Masculino"); //Perro sin raza
            Console.WriteLine(perro.Saludar()); //metodo de la clase Mascota.
            Console.WriteLine(perro.Ladrar()); //metodo de la clase Perro.
            //La siguiente línea muestra el funcionamiento de "protected" da un error porque la clase Main no hereda de la clase "Mascota", por lo que para ella, es un atributo privado.
            //perro.nombre; 

            Perro perroDeRaza = new Perro("Clifford", 4, "Masculino", "Boxer"); //Perro de raza
            Console.WriteLine(perroDeRaza.Saludar()); //metodo de la clase Mascota.
            Console.WriteLine(perroDeRaza.Ladrar()); //metodo de la clase Perro.

            //Podría instanciar un objeto de la clase padre:
            Mascota mascota = new Mascota("Mascota", 5, "Femenino");
            mascota.Saludar(); //Puede saludar por ser una mascota
            //mascota.Ladrar(); //No puede ladrar ´porque no es un perro.
            //Principio de Leukis: todo lo que puede hacer un animal lo puede hacer un perro, pero no todo lo que puede hacer un perro lo puede hacer un animal.

            //Si fuera una clase sellada:
            //No puedo instanciarla, porque la clase es una de tipo abstracta, lo que provoca que no la pueda instanciar.


            //Instancia de Gato:
            Gato gato = new Gato("Michi", 5, "Femenino");

            //
        }
    }
}
