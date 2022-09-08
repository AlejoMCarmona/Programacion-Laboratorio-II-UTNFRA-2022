using System;
using System.Text;

namespace C3_Entidades_04
{
    public class Boligrafo
    {
        public short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            int nuevaCantidadDeTinta = (int)this.tinta + (int)tinta;

            if (nuevaCantidadDeTinta >= 0 && nuevaCantidadDeTinta <= this.cantidadTintaMaxima)
            {
                this.tinta = (short)nuevaCantidadDeTinta;
            }
        }

        public void Recargar()
        {
            int cantidadARecargar = (int)this.cantidadTintaMaxima - (int)this.tinta;

            this.SetTinta((short)cantidadARecargar);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            StringBuilder sb = new StringBuilder();

            while (this.tinta > 0 && gasto > 0)
            {
                sb.Append("*");
                this.SetTinta(-1);
                gasto--;
                retorno = true;
            }

            dibujo = sb.ToString();
            return retorno;
        }
    }
}
