    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio_01
{
    public static class Validador
    {
        static public bool Validar (int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            return false;
        }
    }
}
