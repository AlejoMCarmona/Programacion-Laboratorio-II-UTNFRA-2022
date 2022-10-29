using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C15_Forms_01
{
    public static class Serializador<T>
        where T : class
    {
        public static T DeserializarXML(string rutaArchivo)
        {
            T objeto = null;

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo)) // al usar using(), no hace falta hacer un sr.Close();
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    objeto = xml.Deserialize(sr) as T;
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return objeto;
        }

        public static bool SerializarXML(T objeto, string nombreArchivo)
        {
            bool retorno;

            try
            {
                using (StreamWriter wr = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(wr, objeto);
                }
                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
                throw new Exception(ex.Message);
            }

            return retorno;
        }
    }
}
