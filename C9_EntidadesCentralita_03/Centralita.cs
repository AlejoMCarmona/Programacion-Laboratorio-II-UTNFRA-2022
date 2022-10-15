using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_EntidadesCentralita_03
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
        #endregion

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propiedades
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
        #endregion

        #region Métodos
        private float CalcularGanancia(eTipoLlamada tipo)
        {
            float ganancia = 0;
            string tipoLlamadaActual = "";

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                tipoLlamadaActual = llamada.GetType().Name.ToString();

                if (tipoLlamadaActual == eTipoLlamada.Local.ToString() && (tipo == eTipoLlamada.Todas || tipo == eTipoLlamada.Local))
                {
                    ganancia += ((Local)llamada).CostoLlamada;
                } else if (tipoLlamadaActual == eTipoLlamada.Provincial.ToString() && (tipo == eTipoLlamada.Todas || tipo == eTipoLlamada.Provincial))
                {
                    ganancia += ((Provincial)llamada).CostoLlamada;
                }
            }

            return ganancia;
        }

        private string Mostrar()
        {
            StringBuilder datosCentralita = new StringBuilder();

            datosCentralita.AppendLine("********************************");
            datosCentralita.AppendLine("Razón social: " + this.razonSocial);
            datosCentralita.AppendLine("********Llamadas********");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                datosCentralita.Append(llamada.ToString());
                datosCentralita.AppendLine("---------------------");
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

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada (Llamada nuevaLlamada)
        {
            if (nuevaLlamada is not null)
            {
                this.listaDeLlamadas.Add(nuevaLlamada);
            }
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool retorno = false;

            foreach (Llamada llamada in c.listaDeLlamadas)
            {
                if (llamada == l)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static bool operator +(Centralita c, Llamada l)
        {
            bool retorno = false;

            if (c is not null && l is not null && c != l)
            {
                retorno = true;
                c.AgregarLlamada(l);
            }

            return retorno;
        }

        #endregion
    }
}
