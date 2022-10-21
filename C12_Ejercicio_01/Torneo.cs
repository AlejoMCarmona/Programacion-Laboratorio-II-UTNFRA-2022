using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Ejercicio_01
{
    public class Torneo <T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo (string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        public string JugarPartido 
        { 
            get
            {
                Random random = new Random();

                T e1 = this.equipos[random.Next(0, this.equipos.Count-1)];
                T e2 = this.equipos[random.Next(0, this.equipos.Count-1)];

                return CalcularPartido(e1, e2);
            } 
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            if (torneo is null || equipo is null) throw new ArgumentNullException("No se aceptan torneos ni equipos nulos");

            bool retorno = false;

            foreach (T e in torneo.equipos)
            {
                if (e == equipo)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo is null || equipo is null) throw new ArgumentException("No se aceptan torneos ni equipos nulos");

            bool retorno = false;

            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }

            return retorno;
        }

        private string Mostrar()
        {
            StringBuilder datosTorneo = new StringBuilder();

            datosTorneo.AppendLine("Nombre del torneo: " + this.nombre);
            datosTorneo.AppendLine("*******************Equipos participantes*******************: ");
            foreach (Equipo equipo in this.equipos)
            {
                datosTorneo.AppendLine(equipo.ObtenerFicha());
            }

            return datosTorneo.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public string CalcularPartido(T equipo1, T equipo2)
        {
            if (equipo1 is null || equipo2 is null) throw new ArgumentException("No se aceptan equipos nulos.");

            Random random = new Random();
            StringBuilder resultadoPartido = new StringBuilder();

            resultadoPartido.Append(equipo1.Nombre);
            resultadoPartido.Append(random.Next(1, 6));
            resultadoPartido.Append(" - ");
            resultadoPartido.Append(random.Next(1, 6));
            resultadoPartido.Append(equipo2.Nombre);

            return resultadoPartido.ToString();
        }
    }
}
