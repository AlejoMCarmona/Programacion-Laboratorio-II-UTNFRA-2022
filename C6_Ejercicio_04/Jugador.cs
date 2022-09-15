using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Ejercicio_04
{
    public class Jugador
    {
        #region ATRIBUTOS
        private int dni;
        private int partidosJugados;
        private int totalGoles;
        private float promedioGoles;
        private string nombre;
        #endregion

        #region PROPIEDADES
        public int Dni
        {
            get { return this.dni; }
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public float PromedioGoles
        {
            get {
                if (this.partidosJugados > 0)
                {
                    float promedio = (float)this.totalGoles / this.partidosJugados;
                    this.promedioGoles = promedio;
                }
                return this.promedioGoles; 
            } //GetPromedioGoles();
        }
        #endregion

        #region CONSTRUCTORES
        private Jugador()
        {
            this.totalGoles = 0;
            this.promedioGoles = 0;
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
            sb.AppendLine($"Promedio de gol: {this.PromedioGoles}"); //uso la propiedad y no el atributo privado porque hago una validación obligatoria en el get de la propiedad.

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
