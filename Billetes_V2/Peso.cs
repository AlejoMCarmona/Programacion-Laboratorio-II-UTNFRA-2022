using System;

namespace Billetes_V2
{
    public class Peso
    {
        private static double cotizRespectDolar;
        private double cantidad;

        #region CONSTRUCTORES
        static Peso()
        {
            Peso.cotizRespectDolar = 139.1776; //102.65
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cotizRespectDolar, double cantidad) : this(cantidad)
        {
            Peso.cotizRespectDolar = cotizRespectDolar;
        }
        #endregion

        #region GETTERS
        public static double GetCotizacion()
        {
            return Peso.cotizRespectDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES DE CONVERSION
        #region SOBRECARGA EXPLICITA
        public static explicit operator Dolar(Peso p)
        {
            double conversion;
            Dolar d;

            conversion = p.cantidad / Peso.cotizRespectDolar;
            d = new Dolar(conversion);
            
            return d;
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)(Dolar)p;
        }
        #endregion

        #region SOBRECARGA IMPLICITA

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        #endregion
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return d == p;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return p == (Peso)e;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return (Peso)(d + p);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            double resultado = p.cantidad - ((Peso)d).cantidad;
            return new Peso(resultado);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            double resultado = p.cantidad + ((Peso)e).cantidad;
            return new Peso(resultado);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            double resultado = p.cantidad - ((Peso)e).cantidad;
            return new Peso(resultado);
        }
        #endregion

        #region METODOS
        public static void SetCotizacion(double cotizRespectDolar)
        {
            Peso.cotizRespectDolar = cotizRespectDolar;
        }
        #endregion

    }
}
