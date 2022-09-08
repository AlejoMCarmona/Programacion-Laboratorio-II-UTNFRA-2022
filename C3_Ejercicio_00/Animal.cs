using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_Ejercicio_00
{
    public class Animal //Creamos una clase Animal
    {
        //Nos abstraemos de lo que es un animal como tal, para poder definir sus atributos y métodos.
        //Utilizamos un alto nivel de abstracción para poder hacer un ejemplo sencillo.
        //Atributos: caracteristicas compartidas por todos los animales.
        //  nombre
        //  edad
        //  tipo de animal
        //  contadorDeAnimales

        //Metodos: acciones que pueden realizar todos los animales.
        //  hablar
        //  comer

        //Entonces:
        public string nombre;
        public int edad;
        public string tipoDeAnimal;

        //El atributo estático se comparte con TODAS las instancias.
        public static int contadorDeAnimales;

        //Constructor de la clase:
        public Animal()
        {
            //valores por defecto de los atributos:
            this.nombre = "Sin nombre";
            this.edad = 2;
            this.tipoDeAnimal = "Desconocido";
            //ahora, por más que no le hayamos asignado nada al objeto luego de instanciarlo, tendrá esos valores por defecto.
        }

        //Constructor estático de una clase: su única función es darle valor a los atributos estáticos.
        //Solo se llama LA PRIMERA VEZ que entro en contacto con la clase.
        static Animal()
        {
            Animal.contadorDeAnimales = 0;
        }

        public Animal(string nombre, int edad, string tipoDeAnimal)
        {
            //constructor con parámetros.
            //se debe utilizar la palabra reservada "this" para indicar que se refiere al atributo de la clase.
            Animal.contadorDeAnimales++;
            this.nombre = nombre;
            this.edad = edad;
            this.tipoDeAnimal = tipoDeAnimal;
            //la palabra reservada "this" solo existe para las clases NO ESTÁTICAS.
        }

        //Constructor, otro ejemplo (no es la mejor forma):
        //public Animal(string nombre, int edad, string tipoDeAnimal = "Perro")
        //{
        //constructor con parámetros. por defecto, si no le pasamos el tipoDeAnimal, le asignará que es un perro.
        //se debe utilizar la palabra reservada "this" para indicar que se refiere al atributo de la clase.
        //Animal.contadorDeAnimales++;
        //this.nombre = nombre;
        //this.edad = edad;
        //this.tipoDeAnimal = tipoDeAnimal;
        //la palabra reservada "this" solo existe para las clases NO ESTÁTICAS.
        //}

        public string Hablar() {
            //usamos el StringBuilder porque es mejor que un string comun; puesto que cada vez que concatenamos con un + cuando creamos un string, nos va a reservar un espacio en memoria para cada uno. de esta forma no.
            StringBuilder sb = new StringBuilder();
            //Esta manera es mejor:
            //sb.Append("Hola, me llamo " + this.nombre + etc...);

            sb.Append("Hola, me llamo ");
            sb.AppendLine(this.nombre);
            sb.Append("Tengo ");
            sb.Append(this.edad.ToString());
            sb.AppendLine(" anios");
            sb.Append("Soy un ");
            sb.AppendLine(this.tipoDeAnimal);

            return sb.ToString();
        }

        public void Comer()
        {
            
        }

    }
}
