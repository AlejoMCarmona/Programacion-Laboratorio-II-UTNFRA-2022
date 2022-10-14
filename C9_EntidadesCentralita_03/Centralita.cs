using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_EntidadesCentralita_03
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(eTipoLlamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(eTipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(eTipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        private float CalcularGanancia(eTipoLlamada tipo)
        {
            float ganancia = 0;
            string tipoLlamadaActual = "";

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                tipoLlamadaActual = llamada.GetType().Name.ToString();

                if (tipoLlamadaActual == eTipoLlamada.Local.ToString() && (tipo == eTipoLlamada.Todas || tipo == eTipoLlamada.Local))
                {
                    ganancia += ((Local)llamada).CostoLlamada * llamada.Duracion;
                } else if (tipoLlamadaActual == eTipoLlamada.Provincial.ToString() && (tipo == eTipoLlamada.Todas || tipo == eTipoLlamada.Provincial))
                {
                    ganancia += ((Provincial)llamada).CostoLlamada * llamada.Duracion;
                }
            }

            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder datosCentralita = new StringBuilder();

            datosCentralita.AppendLine("********************************");
            datosCentralita.AppendLine("Razón social: " + this.razonSocial);
            datosCentralita.AppendLine("********Llamadas********");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                datosCentralita.Append(llamada.Mostrar());
            }
            datosCentralita.AppendLine("************************");
            datosCentralita.AppendLine("Ganancia por total: " + this.GananciasPorTotal);
            datosCentralita.AppendLine("Ganancias por local: " + this.GananciasPorLocal);
            datosCentralita.AppendLine("Ganancias por provincial: " + this.GananciasPorProvincial);
            datosCentralita.AppendLine("********************************");

            return datosCentralita.ToString();
        }

        public void OrdenarLlamadas ()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }
}
