using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Entidades_05
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private short vueltasRestantes;
        private short numero;
        private string escuderia;
        private bool enCompetencia;

        //No uso métodos como getters y setters, sino propiedades
        public short CantidadCombustible {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; } 
        }
        public short VueltasRestantes {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }
        public bool EnCompetencia {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Número: " + this.numero);
            datos.AppendLine("Escudería: " + this.escuderia);
            datos.AppendLine("Cantidad de combustible: " + this.cantidadCombustible);
            if (this.enCompetencia)
            {
                datos.AppendLine("El auto se encuentra en competencia:");
                datos.AppendLine(" - Vueltas restantes: " + this.vueltasRestantes);
            } else
            {
                datos.AppendLine("El auto no se encuentra en competencia.");
            }

            return datos.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;

            if (a1 is not null & a2 is not null && a1.numero == a2.numero && String.Compare(a1.escuderia, a2.escuderia) == 0)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
