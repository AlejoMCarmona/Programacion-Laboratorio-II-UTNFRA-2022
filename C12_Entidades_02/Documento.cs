using System;

namespace C12_Entidades_02
{
    public class Documento
    {
        private int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }

        public override string ToString()
        {
            return $"Número de documento: {this.numero}";
        }
    }
}
