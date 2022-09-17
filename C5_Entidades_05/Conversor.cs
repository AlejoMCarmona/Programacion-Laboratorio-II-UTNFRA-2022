using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Entidades_05
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(double numero)
        {
            string resultado = "";
            int numeroEntero = (int)numero;

            while (numeroEntero > 0) {
                resultado = resultado.Insert(0, (numeroEntero % 2).ToString());
                numeroEntero /= 2; 
            }

            return resultado;
        }

        public static int ConvertirBinarioADecimal(double numeroBinario)
        {
            int acumuladorResultado = -1;
            string cadenaNumeroBinario;
            int numeroEntero;
            int potencia = 0;

            cadenaNumeroBinario = numeroBinario.ToString();

            if (Conversor.validarNumeroBinario(cadenaNumeroBinario))
            {
                acumuladorResultado = 0;
                for (int i = cadenaNumeroBinario.Length - 1; i >= 0; i--)
                {
                    numeroEntero = int.Parse(cadenaNumeroBinario[i].ToString());
                    acumuladorResultado += (int)Math.Pow(2, potencia) * numeroEntero;
                    potencia++;
                }
            }          

            return acumuladorResultado;
        }

        private static bool validarNumeroBinario(string numeroBinario)
        {
            bool retorno = true;

            if (numeroBinario.Contains("2") || numeroBinario.Contains("3") || numeroBinario.Contains("4") ||
                numeroBinario.Contains("5") || numeroBinario.Contains("6") || numeroBinario.Contains("7") ||
                numeroBinario.Contains("8") || numeroBinario.Contains("9"))
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
