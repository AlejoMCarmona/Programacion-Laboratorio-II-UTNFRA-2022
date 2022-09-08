using System;
using System.Text;

namespace C4_Entidades_01
{
    public class Sumador
    {
        private int cantidadSumas;

        public int CantidadSumas {
            get { return this.cantidadSumas; }
            set { this.cantidadSumas = value; }
        }

        public Sumador() : this(0) { }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long numero1, long numero2)
        {
            this.cantidadSumas++;
            return numero1 + numero2;
        }

        public string Sumar(string a1, string a2)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(a1 + " " + a2);
            this.cantidadSumas++;
            
            return sb.ToString();
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;

            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
