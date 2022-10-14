using System;
using System.Text;

namespace C9_EntidadesCentralita_03
{
    public abstract class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Propiedades
        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public abstract float CostoLlamada
        {
            get;
        }
        #endregion

        #region Métodos/Sobrecargas
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            } else if (llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }

            return retorno;
        }

        protected virtual string Mostrar()
        {
            StringBuilder datosLlamada = new StringBuilder();

            datosLlamada.AppendLine("Número de origen: " + this.nroOrigen);
            datosLlamada.AppendLine("Número de destino: " + this.nroDestino);
            datosLlamada.AppendLine("Duración: " + this.duracion);

            return datosLlamada.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;

            if (l1.Equals(l2) && l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
    }
}
