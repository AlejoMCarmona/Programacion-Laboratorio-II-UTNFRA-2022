using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Entidades_04
{
    public class Celsius
    {
        private double temperatura;

        public double Temperatura
        {
            get { return this.temperatura; }
            set { this.temperatura = value; }
        }

        public Celsius() : this(100) { }

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        #region SOBRECARGAS DE OPERADORES DE CONVERSION
        #region SOBRECARGAS EXPLÍCITAS
        public static explicit operator Fahrenheit(Celsius gradosCelsius)
        {
            double gradosFahrenheit = gradosCelsius.temperatura * (9 / 5.0) + 32;
            return new Fahrenheit(gradosFahrenheit);
        }

        public static explicit operator Kelvin(Celsius gradosCelsius)
        {
            double gradosKelvin = gradosCelsius.temperatura + 273.15;
            return new Kelvin(gradosKelvin);
        }

        #region SOBRECARGAS IMPLÍCITAS
        public static implicit operator double(Celsius gradosCelsius)
        {
            return gradosCelsius.temperatura;
        }

        public static implicit operator Celsius(double gradosCelsius)
        {
            return new Celsius(gradosCelsius);
        }
        #endregion

        #endregion
        #endregion
    }
}
