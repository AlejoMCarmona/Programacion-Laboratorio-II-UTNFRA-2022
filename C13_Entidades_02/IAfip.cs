using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_Entidades_02
{
    public interface IAfip
    {
        decimal Impuestos { get; }

        decimal AplicarImpuestos();
    }
}
