using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes_V2
{
    public class Euro
    {
        private static double cotizRespectDolar;
        private double cantidad;

        #region CONSTRUCTORES
        static Euro()
        {
            cotizRespectDolar = 1.0048; //1.17
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectDolar = cotizacion;
        }
        #endregion

        #region GETTERS
        public static double GetCotizacion()
        {
            return Euro.cotizRespectDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region SOBRECARGAS DE OPERADORES DE CONVERSION
        #region SOBRECARGAS EXPLICITAS
        public static explicit operator Dolar(Euro e)
        {
            double conversion;
            Dolar dolar;

            conversion = e.cantidad / Euro.cotizRespectDolar;
            dolar = new Dolar(conversion);

            return dolar;
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)(Dolar)e;
        }
        #endregion

        #region SOBRECARGAS IMPLICITAS
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        #endregion
        #endregion

        #region SOBRECARGAS DE OPERADORES
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return d == e;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return p == e;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return (Euro)(d + e);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            double resultado = e.cantidad - ((Euro)d).cantidad;
            return new Euro(resultado);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return (Euro)(p + e);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            double resultado = e.cantidad - ((Euro)p).cantidad;
            return new Euro(resultado);
        }
        #endregion

        #region METODOS
        public static void SetCotizacion (double cotizRespectDolar)
        {
            Euro.cotizRespectDolar = cotizRespectDolar;
        }
        #endregion
    }
}
