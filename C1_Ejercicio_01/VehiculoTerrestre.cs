using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_Entidades_01
{
    public abstract class VehiculoTerrestre //lo hice abstracto porque no quiero que se pueda instanciar un VehiculoTerresto
    {
        //atributos que solo podrán ser accedidos por las clases hijas y por si misma
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
    }
}
