using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_Entidades_02
{
    public class Jugador : Persona
    {
        #region ATRIBUTOS
        private int partidosJugados;
        private int totalGoles;
        #endregion

        #region PROPIEDADES
        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        public float PromedioGoles
        {
            get {
                float promedio = 0;
                if (this.partidosJugados > 0)
                {
                    promedio = (float)this.totalGoles / this.partidosJugados;
                }
                return promedio; 
            }   
        }
        #endregion

        #region CONSTRUCTORES

        public Jugador(int dni, string nombre) : base(dni, nombre) { }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        #region METODOS
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Goles totales: {this.totalGoles}");
            sb.AppendLine($"Promedio de gol: {this.PromedioGoles}");

            return sb.ToString();
        }
        
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
