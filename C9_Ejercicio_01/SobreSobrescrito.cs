using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Ejercicio_01
{
    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiAtributo 
        {
            get { return base.miAtributo; }
        }

        public override string MiMetodo()
        {
            return this.MiAtributo;
        }
    }
}
