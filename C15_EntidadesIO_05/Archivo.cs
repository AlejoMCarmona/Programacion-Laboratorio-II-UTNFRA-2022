using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15_EntidadesIO_05
{
    public abstract class Archivo
    {
        //Método que valida la extensión del archivo
        public bool ValidarExtension(string ruta)
        {
            bool retorno = true;
            string extension;

            extension = Path.GetExtension(ruta);

            if (extension != this.Extension)
            {
                retorno = false;
                throw new ArchivoIncorrectoException($"El archivo no tiene la extensión {extension}");
            }

            return retorno;
        }

        //Método que valida que exista el archivo
        public bool ValidarSiExisteElArchivo(string ruta)
        {
            bool retorno = true;

            if (!File.Exists(ruta))
            {
                retorno = false;
                throw new ArchivoIncorrectoException();
            }

            return retorno;
        }

        //Propiedad a implementar en las clases hijas, que determina la extensión del archivo
        protected abstract string Extension { get; }
    }
}
