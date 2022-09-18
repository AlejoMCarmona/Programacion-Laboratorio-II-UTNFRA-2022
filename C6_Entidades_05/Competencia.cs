using System;
using System.Collections.Generic;
using System.Text;

namespace C6_Entidades_05
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Cantidad de competidores: " + this.cantidadCompetidores);
            datos.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);
            datos.AppendLine("LISTA DE COMPETIDORES:");
            foreach (AutoF1 auto in this.competidores)
            {
                datos.AppendLine(auto.MostrarDatos());
            }

            return datos.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if (c is not null && a is not null) 
            {
                foreach (AutoF1 auto in c.competidores)
                {
                    if (auto == a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            Random random = new Random();

            if (c is not null && a is not null && c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)random.Next(15, 101);
                c.competidores.Add(a);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if (c is not null && a is not null && c == a)
            {
                c.competidores.Remove(a);
                retorno = true;
            }

            return retorno;
        }
    }
}
