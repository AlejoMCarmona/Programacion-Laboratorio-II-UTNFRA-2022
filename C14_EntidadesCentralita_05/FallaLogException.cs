using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14_EntidadesCentralita_05
{
    public class FallaLogException : Exception
    {
        public FallaLogException() : this("No ha podido realizar el logueo de la bitácora") { } 
        public FallaLogException(string mensaje) : this(mensaje, null) { } 
        public FallaLogException(string mensaje, Exception innerException) : base(mensaje, innerException) { } 
    }
}
