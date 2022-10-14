using System;
using System.Text;

namespace C8_Entidades_01
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = 0;
            this.cantidadPasajeros = 0;
        }

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
        }

        public Automovil(short cantidadRuedas, short cantidadPuertas, int cantidadPasajeros, Colores color) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cantidad de ruedas: " + base.cantidadRuedas);
            sb.AppendLine("Cantidad de puertas: " + base.cantidadPuertas);
            sb.AppendLine("Color: " + base.color);
            sb.AppendLine("Cantidad de marchas: " + this.cantidadMarchas);
            sb.AppendLine("Cantidad de pasajeros: " + this.cantidadPasajeros);

            return sb.ToString();
        }
    }
}
