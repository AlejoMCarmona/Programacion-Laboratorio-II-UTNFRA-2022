using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ejercicio_03
{
    public static class StringExtension
    {
        public static int ObtenerCantidadSignosPuntuacion(this string cadena)
        {
            int cantidad = 0;

            foreach (char caracter in cadena)
            {
                if (caracter.CompareTo(',') == 0 || caracter.CompareTo('.') == 0 || caracter.CompareTo(';') == 0)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }
    }
}
