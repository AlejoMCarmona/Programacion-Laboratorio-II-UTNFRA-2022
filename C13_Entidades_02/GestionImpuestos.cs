using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_Entidades_02
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal totalImpuestos = 0;

            foreach (IAduana impuestoAduana in this.impuestosAduana)
            {
                totalImpuestos += impuestoAduana.Impuestos;
            }

            return totalImpuestos;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal totalImpuestos = 0;

            foreach (IAfip impuestoAfip in this.impuestosAfip)
            {
                totalImpuestos += impuestoAfip.Impuestos;
            }

            return totalImpuestos;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            if (paquetes is null) throw new ArgumentNullException("La lista de paquetes no puede ser nula.");

            foreach (Paquete paquete in paquetes)
            {
                this.RegistrarImpuestos(paquete);
            }
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            if (paquete is null) throw new ArgumentNullException("El paquete a agregar no puede ser nulo.");

            this.impuestosAduana.Add(paquete);
            if (paquete.GetType().GetInterface("IAfip") is not null)
            {
                this.impuestosAfip.Add((IAfip)paquete);
            }
        }
    }
}
