using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio_04
{
    public static class Calculadora
    {
        public static double Calcular (double primerOperando, double segundoOperando, string operacion)
        {
            double resultado = double.NaN;

            switch (operacion)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;
                case "/":
                    if (Calculadora.Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    break;
            }

            return resultado;
        }

        private static bool Validar(double numero)
        {
            if (numero == 0)
            {
                return false;
            }
            return true;
        }
    }
}
