using System;

namespace C8_Entitades_00
{
    //APLICACIÓN DE UNA TIENDA DE MASCOTAS
    //public abstract class Mascota //No permite ser instanciada
    //public sealed class Mascota //No permite tener clases hijos
    public class Mascota //CLASE PADRE (CLASE BASE)
    {
        //Atributo protected: permite que este atributo sea conocido tanto por los objetos de tipo "Mascota" como aquellos objetos que hereden de esta clase.
        protected string nombre; //Atributo conocido para la clase Mascota y para todas sus clases hijas.
        //Atributos privados: no podrán ser accedidos utilizando una instancia de la clase hija
        private int patas;
        private string sexo;

        public Mascota(string nombre, int patas, string sexo)
        {
            this.nombre = nombre;
            this.patas = patas;
            this.sexo = sexo;
        }

        public string Saludar()
        {
            return "Saludo";
        }
    }
}
