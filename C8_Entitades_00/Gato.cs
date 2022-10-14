using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_Entitades_00
{
    public class Gato : Mascota
    {
        private int vidas;

        public Gato(string nombre, int patas, string sexo) : base(nombre, patas, sexo)
        {
        }

        public Gato(string nombre, int patas, string sexo, int vidas) : this(nombre, patas, sexo)
        {
            this.vidas = vidas;
        }
    }
}
