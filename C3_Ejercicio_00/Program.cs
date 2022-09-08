using System;

namespace C3_Ejercicio_00
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio un objeto de la clase animal:
            Animal animal1 = new Animal();

            //Le asigno valores a los atributos nombre y edad:
            animal1.nombre = "Pepe";
            animal1.edad = 10;
            animal1.tipoDeAnimal = "Perro";

            //Ejecuto el método Hablar();
            Console.WriteLine(animal1.Hablar());
            Console.WriteLine("Edad del animal 1: {0}", animal1.edad);

            //Generamos un nuevo animal:
            Animal animal2 = new Animal("Juana", 5, "Gato");
        
            Console.WriteLine(animal2.Hablar());
        }
    }
}
