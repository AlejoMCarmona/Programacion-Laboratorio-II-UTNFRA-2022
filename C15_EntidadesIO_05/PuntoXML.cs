using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C15_EntidadesIO_05
{
    public class PuntoXML<T> : Archivo, IArchivo<T>
        where T : class
    {
        private XmlSerializer xml;

        public PuntoXML()
        {
            xml = new XmlSerializer(typeof(T));
        }

        protected override string Extension 
        { 
            get { return ".xml"; }        
        }

        public void Guardar(string ruta, T contenido)
        {
            if (base.ValidarSiExisteElArchivo(ruta))
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    xml.Serialize(sw, contenido);
                }
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (base.ValidarExtension(ruta))
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    xml.Serialize(sw, contenido);
                }
            }
        }

        public T Leer(string ruta)
        {
            T contenidoDeserializado = null;

            if (base.ValidarExtension(ruta) && base.ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    contenidoDeserializado = xml.Deserialize(sr) as T;
                }
            }

            return contenidoDeserializado;
        }
    }
}
