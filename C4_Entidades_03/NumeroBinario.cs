using System;

namespace C4_Entidades_03
{
    public class NumeroBinario
    {
        #region ATRIBUTOS/PROPIEDADES
        private string numero;

        public string Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        #endregion

        #region CONSTRUCTORES
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        #endregion

        #region SOBRECARGAS DE OPERADORES
        public static string operator +(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            double numBinarioEnDecimal;
            double numBinarioDouble;
            string resultadoBinario = "";
        
            if (double.TryParse(numBinario.numero, out numBinarioDouble))
            {
                numBinarioEnDecimal = Conversor.ConvertirBinarioADecimal(numBinarioDouble);
                numBinarioDouble = (int)(numBinarioEnDecimal + numDecimal.Numero);
                resultadoBinario = Conversor.ConvertirDecimalABinario(numBinarioDouble);
            }

            return resultadoBinario;
        }

        public static string operator -(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            double numBinarioEnDecimal;
            double numBinarioDouble;
            string resultadoBinario = "Numero negativo";

            if (double.TryParse(numBinario.numero, out numBinarioDouble))
            {
                numBinarioEnDecimal = Conversor.ConvertirBinarioADecimal(numBinarioDouble);
                numBinarioDouble = numBinarioEnDecimal - numDecimal.Numero;
                if (numBinarioDouble >= 0)
                {
                    resultadoBinario = Conversor.ConvertirDecimalABinario(numBinarioDouble);
                }
            }

            return resultadoBinario;
        }

        public static bool operator ==(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            string numeroDecimalEnBinario;
            bool retorno = false;

            numeroDecimalEnBinario = Conversor.ConvertirDecimalABinario(numDecimal.Numero);
            if (numBinario.numero.Equals(numeroDecimalEnBinario))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            return !(numBinario == numDecimal);
        }
        #endregion

        #region SOBRECARGA DE OPERADORES DE CONVERSION
        #region SOBRECARGA IMPLICITA
        public static implicit operator NumeroBinario(string numeroBinario)
        {
            return new NumeroBinario(numeroBinario);
        }
        #endregion
        #region SOBRECARGA EXPLICITA
        public static explicit operator string(NumeroBinario numeroBinario)
        {
            return numeroBinario.numero;
        }
        #endregion
        #endregion
    }
}
