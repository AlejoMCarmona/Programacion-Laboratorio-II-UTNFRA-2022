using System;
using System.Collections.Generic;

namespace C7_Ejercicio_03
{
    public class Equipo
    {
        #region ATRIBUTOS
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region CONSTRUCTORES
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        #endregion

        #region PROPIEDADES
        public short CantidadDeJugadores
        {
            get { return this.cantidadDeJugadores; }
        }

        public List<Jugador> Jugadores
        {
            get { return this.jugadores; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
        #endregion


        #region METODOS
        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;

            if (e.jugadores.Count < e.cantidadDeJugadores && !e.jugadores.Exists(x => x.Dni == j.Dni))
            {
                e.jugadores.Add(j);
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}
