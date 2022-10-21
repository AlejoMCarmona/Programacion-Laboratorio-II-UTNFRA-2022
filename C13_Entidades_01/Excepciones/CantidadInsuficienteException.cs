using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_Entidades_01.Excepciones
{
    public class CantidadInsuficienteException : Exception
    {
        public CantidadInsuficienteException(string mensaje, Exception innerException) : base(mensaje, innerException) { }
        public CantidadInsuficienteException(string mensaje) : this(mensaje, null) { }
        public CantidadInsuficienteException() : this("No se puede escribir con la cantidad de recursos actuales.") { }
    }
}
