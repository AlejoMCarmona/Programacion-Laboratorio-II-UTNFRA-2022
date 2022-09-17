using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Entidades_01
{
    public class CuentaOffShore
    {
        #region ATRIBUTOS
        private Cliente _duenio;
        private int _numeroCuenta;
        private double _saldo;
        #endregion

        #region PROPIEDADES
        public Cliente Duenio {
            get
            {
                return this._duenio;
            }
        }

        public double Saldo {
            get {
                return this._saldo;
            }
            set {
                this._saldo = value;
            }
        }
        #endregion

        #region CONSTRUCTORES
        public CuentaOffShore(Cliente duenio, int numero, double saldoInicial)
        {
            this._duenio = duenio;
            this._numeroCuenta = numero;
            this._saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre, eTipoCliente tipo, int numero, double saldoInicial)
                      : this(new Cliente(tipo, nombre), numero, saldoInicial) { }

        public static explicit operator int(CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool retorno = false;

            if (String.Compare(cos1._duenio.AliasParaIncognito, cos2._duenio.AliasParaIncognito) == 0 && cos1._numeroCuenta == cos2._numeroCuenta)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }
        #endregion
    }
}
