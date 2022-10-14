using System;

namespace C10_Entidades_01
{
    public static class Calculador
    {
        public static double Calcular(double kilometro, double litros)
        {
            if (litros == 0)
            {
                throw new DivideByZeroException("No puedes dividir por cero");
            }

            return kilometro / litros;
        }
    }
}
