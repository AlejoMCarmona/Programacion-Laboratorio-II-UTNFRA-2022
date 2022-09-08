using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio_07
{
    public static class Calculadora
    {
        public static double CalcularHipotenusa (double alturaTriangulo, double baseTriangulo)
        {
            return Math.Sqrt((Math.Pow(alturaTriangulo, 2) + Math.Pow(baseTriangulo, 2)));
        }
    }
}
