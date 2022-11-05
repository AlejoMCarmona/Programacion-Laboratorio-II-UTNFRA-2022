using System;

namespace C17_Entidades_02
{
    public class Juego
    {
        #region Atributos
        private int codigoJuego;
        private int codigoUsuario;
        private string genero;
        private string nombre;
        private double precio;
        #endregion

        #region Constructores
        public Juego(string nombre, double precio, string genero, int codigoJuego, int codigoUsuario) : this(nombre, precio, genero, codigoUsuario)
        {
            this.codigoJuego = codigoJuego;
        }

        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoUsuario = codigoUsuario;
        }
        #endregion

        #region Propiedades
        public int CodigoJuego
        {
            get { return this.codigoJuego; }
        }

        public int CodigoUsuario
        {
            get { return this.codigoUsuario; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Genero
        {
            get { return this.genero; }
        }

        public double Precio
        {
            get { return this.precio; }
        }
        #endregion
    }
}
