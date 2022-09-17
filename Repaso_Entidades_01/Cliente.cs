using System;
using System.Text;

namespace Repaso_Entidades_01
{
    public class Cliente
    {
        #region ATRIBUTOS
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;
        #endregion

        #region PROPIEDADES
        public string AliasParaIncognito { 
            get {
                if (String.Compare(this._aliasParaIncognito, "Sin alias") == 0)
                {
                    this.CrearAlias();
                }
                return this._aliasParaIncognito;
            }
        }
        #endregion

        #region CONSTRUCTORES
        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente) : this()
        {
            this._tipoDeCliente = tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._nombre = nombre;
        }
        #endregion

        #region MÉTODOS
        private void CrearAlias()
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            sb.Append(random.Next(1000, 10000).ToString());
            sb.Append(this._tipoDeCliente);

            this._aliasParaIncognito = sb.ToString();
        }

        private string RetornarDatos()
        {
            return RetornarDatos(this);
        }

        public static string RetornarDatos(Cliente unCliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + unCliente._nombre);
            sb.AppendLine("Tipo: " + unCliente._tipoDeCliente);
            sb.Append("Alias: " + unCliente._aliasParaIncognito);

            return sb.ToString();
        }
        #endregion
    }
}
