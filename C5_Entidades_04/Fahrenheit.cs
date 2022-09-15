using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Entidades_04
{
    public class Fahrenheit
    {
        private double temperatura;

        public double Temperatura {
            get { return this.temperatura; }
            set { this.temperatura = value; }
        }

        public Fahrenheit() : this(212) { }

        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        #region SOBRECARGAS DE OPERADORES DE CONVERSION
        #region SOBRECARGAS EXPLÍCITAS
        public static explicit operator Celsius(Fahrenheit gradosFahrenheit)
        {
            double gradosCelsius = (gradosFahrenheit.temperatura - 32) * (5/9.0);
            return new Celsius(gradosCelsius);
        }

        public static explicit operator Kelvin(Fahrenheit gradosFahrenheit)
        {
            double gradosKelvin = (gradosFahrenheit.temperatura + 459.67) * 5 / 9.0;
            return new Kelvin(gradosKelvin);
        }

        #endregion

        #region SOBRECARGAS IMPLÍCITAS
        public static implicit operator double(Fahrenheit gradosFahrenheit)
        {
            return gradosFahrenheit.temperatura;
        }

        public static implicit operator Fahrenheit(double gradosFahrenheit)
        {
            return new Fahrenheit(gradosFahrenheit);
        }
        #endregion
        #endregion
    }
}
