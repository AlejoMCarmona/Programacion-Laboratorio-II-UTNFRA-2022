using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio_09
{
    public static class Calculadora
    {
        public static int CalcularFactorial(int numero)
        {
            int resultadoFactorial = 1;

            for (int i = numero; i > 1; i--)
            {
                resultadoFactorial *= i;
            }

            return resultadoFactorial;
        }
    }
}
