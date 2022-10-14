using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_Entidades_01
{
    public class Camion : VehiculoTerrestre
    {
        private int pesoCarga;

        public Camion (short cantidadRuedas, short cantidadPuertas, Colores color) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.pesoCarga = 0;
        }

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, int pesoCarga) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.pesoCarga = pesoCarga;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cantidad de ruedas: " + base.cantidadRuedas);
            sb.AppendLine("Cantidad de puertas: " + base.cantidadPuertas);
            sb.AppendLine("Color: " + base.color);
            sb.AppendLine("Peso de carga: " + this.pesoCarga);

            return sb.ToString();
        }
    }
}
