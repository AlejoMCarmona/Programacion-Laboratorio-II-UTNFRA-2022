using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        private eFranja franjaHoraria;

        public Provincial(eFranja miFranja, float duracion, string destino, string origen) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(eFranja miFranja, Llamada llamada) : this(miFranja, llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        { }

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        public string Mostrar()
        {
            StringBuilder datosLocal = new StringBuilder();

            datosLocal.Append(base.Mostrar());
            datosLocal.AppendLine("Franja horaria: " + this.franjaHoraria);
            datosLocal.AppendLine("Costo: " + this.CostoLlamada);

            return datosLocal.ToString();
        }

        private float CalcularCosto()
        {
            float costoPorSegundo = 0;

            switch (this.franjaHoraria)
            {
                case eFranja.Franja_1:
                    costoPorSegundo = 0.99f;
                    break;
                case eFranja.Franja_2:
                    costoPorSegundo = 1.25f;
                    break;
                case eFranja.Franja_3:
                    costoPorSegundo = 0.66f;
                    break;
            }

            return this.duracion * costoPorSegundo;
        }
    }
}
