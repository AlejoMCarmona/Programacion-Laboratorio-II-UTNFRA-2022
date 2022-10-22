using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ejercicio_02
{
    public static class IntExtension
    {
        public static Int64 ContarCantidadDeDigitos(this Int64 digito)
        {
            return digito.ToString().Length;
        }
    }
}
