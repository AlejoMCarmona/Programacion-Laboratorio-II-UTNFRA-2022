using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_Ejercicio_03
{
    public class Jugador
    {
        #region ATRIBUTOS
        private int dni;
        private int partidosJugados;
        private int totalGoles;
        private string nombre;
        #endregion

        #region PROPIEDADES
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

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
        private Jugador()
        {
            this.totalGoles = 0;
            this.partidosJugados = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

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

            sb.AppendLine("DATOS DEL JUGADOR:");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Goles totales: {this.totalGoles}");
            sb.AppendLine($"Promedio de gol: {this.PromedioGoles}");

            return sb.ToString();
        }
        
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
