using System;
using System.Text;

namespace C13_Entidades_02
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        private string destino;
        private string origen;
        private double pesoKg;
        protected decimal costoEnvio;

        public Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get; }

        public decimal Impuestos //De la interfaz "IAduana"
        {
            get
            {
                return costoEnvio * (decimal)0.35;
            }
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder informacionPaquete = new StringBuilder();

            informacionPaquete.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            informacionPaquete.AppendLine($"Destino: {this.destino}");
            informacionPaquete.AppendLine($"Origen: {this.origen}");
            informacionPaquete.AppendLine($"Peso en KG: {this.pesoKg}");
            informacionPaquete.AppendLine($"Costo de envío: {this.costoEnvio} kg");
            informacionPaquete.Append($"¿Tiene prioridad?: ");
            if (this.TienePrioridad)
            {
                informacionPaquete.AppendLine("Sí");
            }
            else
            {
                informacionPaquete.AppendLine("No");
            }

            return informacionPaquete.ToString();
        }

        public virtual decimal AplicarImpuestos() //De la interfaz "IAduana"
        {
            return this.costoEnvio + this.Impuestos;
        }
    }
}
