using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15_EntidadesIO_05
{
    public class PuntoTXT : Archivo, IArchivo<string>
    {
        protected override string Extension
        {
            get { return ".txt"; }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (base.ValidarSiExisteElArchivo(ruta))
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(contenido);
                }
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            if (base.ValidarExtension(ruta))
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(contenido);
                }
            }
        }

        public string Leer(string ruta)
        {
            string contenido = "";

            if (base.ValidarExtension(ruta) && base.ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    contenido = sr.ReadToEnd();
                }
            }

            return contenido;
        }
    }
}
