using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C15_EntidadesCentralita_06
{
    public class Local : Llamada, IGuardar<Local>
    {
        #region Atributos
        private float costo;
        private string rutaDeArchivo;
        #endregion

        #region Constructores
        public Local() : this(1112, "15", "hola", 111) { } //TODO: Constructor público sin parámetros para serializar a XML. Preguntar porque lo deserializa mal.

        public Local(float duracion, string destino, string origen, float costo) : base (duracion, destino, origen)
        {
            this.rutaDeArchivo = $"Local-{this.NroOrigen}-{this.NroDestino}.xml";
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo) 
        { }
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
            set { _ = value; }
        }

        public string RutaDeArchivo 
        {
            get { return this.rutaDeArchivo; }
            set { this.rutaDeArchivo = value; } 
        }
        #endregion

        #region Métodos, Sobrescrituras
        protected override string Mostrar()
        {
            StringBuilder datosLocal = new StringBuilder();

            datosLocal.Append(base.Mostrar());
            datosLocal.AppendLine("Costo: " + this.CostoLlamada);

            return datosLocal.ToString();
        }

        private float CalcularCosto ()
        {
            return this.costo * this.duracion;
        }

        public override bool Equals(object obj)
        {
            return String.Equals(obj.GetType().Name.ToString(), eTipoLlamada.Local.ToString());
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            bool retorno = false;

            using (StreamWriter sw = new StreamWriter(this.rutaDeArchivo)) { 
                XmlSerializer xml = new XmlSerializer(typeof(Local));
                xml.Serialize(sw, this);
                retorno = true;
            }

            return retorno;
        }

        /*
        El método Leer de la implementación de IGuardar en Local deberá obtener los datos de un archivo conteniendo un objeto serializado en formato XML,
        comprobar que este sea del tipo Local y retornar el objeto deserializado. En caso de que no sea del tipo Local, lanzará la excepción InvalidCastException.        
        */
        public Local Leer()
        {
            Local localDeserializado;

            using (StreamReader sr = new StreamReader(this.rutaDeArchivo))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Local));
                localDeserializado = xml.Deserialize(sr) as Local;
            }

            return localDeserializado;
        }
        #endregion
    }
}
