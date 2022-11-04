using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C15_EntidadesCentralita_06
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        #region Atributos
        private eFranja franjaHoraria;
        private string rutaDeArchivo;
        #endregion

        #region Constructores
        public Provincial () : this (eFranja.Franja_1, 0, "0", "0") { }  //TODO: Constructor público sin parámetros para serializar a XML.  Preguntar porque lo deserializa mal.

        public Provincial(eFranja miFranja, float duracion, string destino, string origen) : base(duracion, destino, origen)
        {
            this.rutaDeArchivo = $"Provincial-{this.NroOrigen}-{this.NroDestino}.xml";
            this.franjaHoraria = miFranja;
        }

        public Provincial(eFranja miFranja, Llamada llamada) : this(miFranja, llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
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
            datosLocal.AppendLine("Franja horaria: " + this.franjaHoraria);
            datosLocal.AppendLine("Costo: " + this.CostoLlamada);

            return datosLocal.ToString();
        }

        private float CalcularCosto()
        {
            float costoPorSegundo = 0;

            switch (this.franjaHoraria)
            {
                case eFranja.Franja_1:
                    costoPorSegundo = 0.99f;
                    break;
                case eFranja.Franja_2:
                    costoPorSegundo = 1.25f;
                    break;
                case eFranja.Franja_3:
                    costoPorSegundo = 0.66f;
                    break;
            }

            return this.duracion * costoPorSegundo;
        }
        public override bool Equals(object obj)
        {
            return String.Equals(obj.GetType().Name.ToString(), eTipoLlamada.Provincial.ToString());
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            bool retorno = false;

            using (StreamWriter sw = new StreamWriter(this.rutaDeArchivo))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Provincial));
                xml.Serialize(sw, this);
                retorno = true;
            }

            return retorno;
        }

        public Provincial Leer()
        {
            Provincial provincialDeserializado;

            using (StreamReader sr = new StreamReader(this.rutaDeArchivo))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Provincial));
                provincialDeserializado = xml.Deserialize(sr) as Provincial;
            }

            return provincialDeserializado;
        }
        #endregion
    }
}
