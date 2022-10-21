using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_Entidades_01.Excepciones
{
    public class CadenaVaciaException : Exception
    {
        public CadenaVaciaException(string mensaje, Exception innerException) : base(mensaje, innerException) { }
        public CadenaVaciaException(string mensaje) : this(mensaje, null) { }
        public CadenaVaciaException() : this("La cadena está vacía.") { }
    }
}
