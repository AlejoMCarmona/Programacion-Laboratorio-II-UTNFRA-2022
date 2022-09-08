using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio_02
{
    public static class Validador
    {
        public static bool ValidarRespuesta(string opcion)
        {
            if (opcion == "S")
            {
                return true;
            }
            return false;
        }
    }
}
