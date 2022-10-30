using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace C15_EntidadesIO_05
{
    public class PuntoJSON<T> : Archivo, IArchivo<T>
        where T : class
    {
        protected override string Extension
        {
            get { return ".json"; }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (base.ValidarSiExisteElArchivo(ruta))
            {
                string contenidoJSON;

                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    contenidoJSON = this.Serializar(contenido);
                    sw.WriteLine(contenidoJSON);
                }
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (base.ValidarExtension(ruta))
            {
                string contenidoJSON;

                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    contenidoJSON = this.Serializar(contenido);
                    sw.WriteLine(contenidoJSON);
                }
            }
        }

        public T Leer(string ruta)
        {
            T contenido = null;
            string contenidoArchivo = "";

            if (base.ValidarExtension(ruta) && base.ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    contenidoArchivo = sr.ReadToEnd();
                    contenido = this.Deserializar(contenidoArchivo);
                }
            }

            return contenido;
        }

        private string Serializar(T contenido)
        {
            string contenidoJSON = JsonSerializer.Serialize(contenido);
            return contenidoJSON;
        }

        private T Deserializar(string contenidoJSON)
        {
            return JsonSerializer.Deserialize<T>(contenidoJSON);
        }
    }
}
