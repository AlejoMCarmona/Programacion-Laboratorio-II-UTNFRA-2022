using C13_Ejercicio_00A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_Ejercicio_00
{
    class Persona : ICazador
    {
        public string Cazador()
        {
            return "Salgo con la escopeta";
        }
    }
}
