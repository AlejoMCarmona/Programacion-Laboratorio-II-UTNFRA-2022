using System;

namespace Billetes_V2
{
    public class Dolar
    {
        private static double cotizRespectDolar;
        private double cantidad;

        #region CONSTRUCTORES
        static Dolar()
        {
            Dolar.cotizRespectDolar = 1;   
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        #endregion

        #region GETTERS
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES DE CONVERSION
        #region SOBRECARGA EXPLICITA
        public static explicit operator Euro(Dolar d)
        {
            double conversion;
            Euro euro;

            conversion = Euro.GetCotizacion() * d.cantidad;
            euro = new Euro(conversion);

            return euro;
        }

        public static explicit operator Peso(Dolar d)
        {
            double conversion;
            Peso peso;

            conversion = Peso.GetCotizacion() * d.cantidad;
            peso = new Peso(conversion);

            return peso;
        }
        #endregion

        #region SOBRECARGA IMPLICITA
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        #endregion
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            double resultado = d.cantidad + ((Dolar)e).cantidad;
            return new Dolar(resultado);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            double resultado = d.cantidad - ((Dolar)e).cantidad;
            return new Dolar(resultado);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            double resultado = d.cantidad + ((Dolar)p).cantidad;
            return new Dolar(resultado);
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            double resultado = d.cantidad - ((Dolar)p).cantidad;
            return new Dolar(resultado);
        }
        #endregion

    }
}
