using System;

namespace C5_Entidades_04
{
    public class Kelvin
    {
        private double temperatura;

        public double Temperatura
        {
            get { return this.temperatura; }
            set { this.temperatura = value; }
        }

        public Kelvin() : this(373) { }

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        #region SOBRECARGAS DE OPERADORES DE CONVERSION
        #region SOBRECARGAS EXPLÍCITAS
        public static explicit operator Celsius(Kelvin gradosKelvin)
        {
            double gradosCelsius = gradosKelvin.temperatura - 273.15;
            return new Celsius(gradosCelsius);
        }

        public static explicit operator Fahrenheit(Kelvin gradosKelvin)
        {
            double gradosFahrenheit = gradosKelvin.temperatura * 9 / 5 - 459.67;
            return new Fahrenheit(gradosFahrenheit);
        }
        #endregion

        #region SOBRECARGAS IMPLÍCITAS
        public static implicit operator double(Kelvin gradosKelvin)
        {
            return gradosKelvin.temperatura;
        }

        public static implicit operator Kelvin(double gradosKelvin)
        {
            return new Kelvin(gradosKelvin);
        }
        #endregion
        #endregion
    }
}
