using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Entidades_02
{
    public class Biblioteca
    {
        #region Atributos
        private int codigoJuego;
        private string genero;
        private string juego;
        private string usuario;
        #endregion

        #region Constructores
        public Biblioteca(string usuario, string genero, string juego, int codigoJuego)
        {
            this.usuario = usuario;
            this.genero = genero;
            this.juego = juego;
            this.codigoJuego = codigoJuego;
        }
        #endregion

        #region Propiedades
        public int CodigoJuego
        {
            get { return this.codigoJuego; }
        }

        public string Genero
        {
            get { return this.genero; }
        }

        public string Juego
        {
            get { return this.juego; }
        }

        public string Usuario
        {
            get { return this.usuario; }
        }
        #endregion
    }
}
