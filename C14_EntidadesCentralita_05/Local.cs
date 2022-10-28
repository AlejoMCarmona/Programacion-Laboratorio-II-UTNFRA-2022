using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14_EntidadesCentralita_05
{
    public class Local : Llamada, IGuardar<Local>
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

        public string RutaDeArchivo { get; set; }
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
            throw new NotImplementedException();
        }

        public Local Leer ()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
