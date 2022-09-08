using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_Entidades_03
{
    public class NumeroDecimal
    {
        #region ATRIBUTOS/PROPIEDADES
        private double numero;

        public double Numero {
            get { return this.numero;  }
            set { this.numero = value; } 
        }

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        #endregion

        #region SOBRECARGAS DE OPERADORES
        public static double operator +(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            string resultadoBinario;
            double resultadoBinarioEntero;

            resultadoBinario = numBinario + numDecimal;
            double.TryParse(resultadoBinario, out resultadoBinarioEntero);

            return Conversor.ConvertirBinarioADecimal(resultadoBinarioEntero);
        }

        public static double operator -(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            double numBinarioEnDecimal;
            double resultadoDecimal = 0;
            double numBinarioDouble;

            if (double.TryParse(numBinario.Numero, out numBinarioDouble))
            {
                numBinarioEnDecimal = Conversor.ConvertirBinarioADecimal(numBinarioDouble);
                resultadoDecimal = numDecimal.numero - numBinarioEnDecimal;
            }

            return resultadoDecimal;
        }

        public static bool operator ==(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return numBinario == numDecimal;
        }

        public static bool operator !=(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return !(numDecimal == numBinario);
        }
        #endregion

        #region SOBRECARGAS DE OPERADORES DE CONVERSIÓN
        #region SOBRECARGAS IMPLÍCITAS
        public static implicit operator NumeroDecimal(int numeroDecimal)
        {
            return new NumeroDecimal(numeroDecimal);
        }
        #endregion
        #region SOBRECARGAS EXPLÍCITAS
        public static explicit operator double(NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.numero;
        }
        #endregion
        #endregion
    }
}
