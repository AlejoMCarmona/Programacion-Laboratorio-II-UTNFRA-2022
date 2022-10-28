using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14_EntidadesCentralita_05
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) : base ($"ERROR: {mensaje}. Excepción lanzada en la clase '{clase}', en el método '{metodo}'", innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        { }

        public string NombreClase
        {
            get { return this.nombreClase; }
        }

        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
        }
    }
}
