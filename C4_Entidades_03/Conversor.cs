using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_Entidades_03
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
            int acumuladorResultado = 0;
            string cadenaNumeroBinario;
            int numeroEntero;
            int potencia = 0;

            cadenaNumeroBinario = numeroBinario.ToString();
            for (int i = cadenaNumeroBinario.Length-1; i >= 0; i--)
            {
                numeroEntero = int.Parse(cadenaNumeroBinario[i].ToString());
                acumuladorResultado += (int)Math.Pow(2, potencia)*numeroEntero;
                potencia++;
            }

            return acumuladorResultado;
        }
    }
}
