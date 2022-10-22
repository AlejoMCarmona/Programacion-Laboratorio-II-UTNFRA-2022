using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12_Entidades_02
{
    public class Contabilidad<T,U>
        where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> contabilidad, T documento)
        {
            if (contabilidad is null || documento is null) throw new ArgumentNullException("ERROR! Contabilidad o documento nulo");
            
            contabilidad.egresos.Add(documento);

            return contabilidad;
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T, U> contabilidad, U documento)
        {
            if (contabilidad is null || documento is null) throw new ArgumentNullException("ERROR! Contabilidad o documento nulo");

            contabilidad.ingresos.Add(documento);

            return contabilidad;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("****LISTA DE INGRESOS****");
            foreach (U ingreso in this.ingresos)
            {
                datos.AppendLine(ingreso.ToString());
            }

            datos.AppendLine("****LISTA DE EGRESOS****");
            foreach (T egreso in this.egresos)
            {
                datos.AppendLine(egreso.ToString());
            }

            datos.AppendLine("***********************");

            return datos.ToString();
        }
    }
}
