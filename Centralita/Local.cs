using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        private float costo;

        public Local(float duracion, string destino, string origen, float costo) : base (duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo) 
        { }

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        public string Mostrar()
        {
            StringBuilder datosLocal = new StringBuilder();

            datosLocal.Append(base.Mostrar());
            datosLocal.AppendLine("Costo: " + this.costo);

            return datosLocal.ToString();
        }

        private float CalcularCosto ()
        {
            return this.costo * this.duracion;
        }
    }
}
