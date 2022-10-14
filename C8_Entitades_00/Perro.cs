using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_Entitades_00
{
    //Decimos que la clase "Perro" hereda de la clase "Mascota"
    public sealed class Perro : Mascota
    {
        private string raza;
        //La siguiente línea da un "warning" porque dice que no tiene sentido declararlo puesto que ya está hecho en la clase padre. Lo sobreescribe en esta clase.
        private string nombre; //Sobreescribe el valor asignado a la clase padre. Nunca se debe hacer.

        //Necesitamos implementar sí o sí un constructor de mascota, porque si bien la clase hija hereda todos los atributo/metodos del padre, no hereda el constructor.
        public Perro(string nombre, int patas, string sexo) : base(nombre, patas, sexo) //Llamamos al constructor de la clase padre (clase base) para pasarle al constructor de esta última los parámetros para inicializar
        {
            this.raza = "Sin raza";
        }

        public Perro (string nombre, int patas, string sexo, string raza) : this(nombre, patas, sexo)
        {
            this.raza = raza;
        }

        public string Ladrar()
        {
            return base.Saludar() + "GUAU, me llamo " + base.nombre; //Método y atributo heredados de la clase padre
            //return this.Saludar() => No se recomienda.
        }
    }

    //No puedo hacer que Cachorro herede de Perro, porque este último es una clase sellada.
    //Si no fuese una clase sellada, Cachorro heredaría los atributos/métodos de Perro y Mascota. Puesto que es un perro y por ende, es también una Mascota.
    /*
    public class Cachorro : Perro
    {
        public Cachorro (string nombre, int patas, string sexo) : base (nombre, patas, sexo)
        {

        }
    }
    */
}
