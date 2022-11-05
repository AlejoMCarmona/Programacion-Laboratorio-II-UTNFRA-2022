using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Entidades_02
{
    public class Usuario
    {
        #region Atributos
        private int codigoUsuario;
        private string username;
        #endregion

        #region Constructores
        public Usuario(string username, int codigoUsuario)
        {
            this.username = username;
            this.codigoUsuario = codigoUsuario;
        }
        #endregion

        #region Propiedades
        public int CodigoUsuario 
        {
            get { return this.codigoUsuario; } 
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return this.username;
        }
        #endregion
    }
}
