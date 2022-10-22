using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_EntidadesCentralita_03
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        #region Atributos
        private eFranja franjaHoraria;
        #endregion

        #region Constructores
        public Provincial(eFranja miFranja, float duracion, string destino, string origen) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(eFranja miFranja, Llamada llamada) : this(miFranja, llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        { }
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        public string RutaDeArchivo { get; set; }
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
            throw new NotImplementedException();
        }

        public Provincial Leer()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
