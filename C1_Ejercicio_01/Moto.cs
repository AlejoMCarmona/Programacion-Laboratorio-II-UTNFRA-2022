using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_Entidades_01
{
    public class Moto : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private short cilindrada;

        public Moto (short cantidadRuedas, short cantidadPuertas, Colores color) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = 0;
            this.cilindrada = 0;
        }

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
        }

        public Moto(short cantidadRuedas, short cantidadPuertas, short cilindrada, Colores color) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, short cilindrada) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cilindrada = cilindrada;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cantidad de ruedas: " + base.cantidadRuedas);
            sb.AppendLine("Cantidad de puertas: " + base.cantidadPuertas);
            sb.AppendLine("Color: " + base.color);
            sb.AppendLine("Cantidad de marchas: " + this.cantidadMarchas);
            sb.AppendLine("Cilindrada: " + this.cilindrada);

            return sb.ToString();
        }
    }
}
