using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_EntidadesCentralita_03
{
    public class Local : Llamada
    {
        #region Atributos
        private float costo;
        #endregion

        #region Constructores
        public Local(float duracion, string destino, string origen, float costo) : base (duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo) 
        { }
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
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
        #endregion
    }
}
