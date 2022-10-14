using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Ejercicio_01
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        //para poder definir miembros abstractos, la clase debe ser abstracta
        public abstract string MiAtributo { get; }

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj.GetType().Name == this.GetType().Name)
            {
                retorno = true;
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

        public abstract string MiMetodo();
    }
}
