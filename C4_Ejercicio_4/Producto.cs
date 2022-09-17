using System;
using System.Text;

namespace C4_Entidades_4
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public float Precio { get { return this.precio; } }
        public string Marca { get { return this.marca; } }

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder producto = new StringBuilder();

            if (p is not null)
            {
                producto.AppendLine("Marca: " + p.marca);
                producto.AppendLine("Precio: " + p.precio);
                producto.AppendLine("Código de barras: " + p.codigoDeBarra);
            } else
            {
                producto.Append("");
            }

            return producto.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;

            if (p is not null && String.Compare(p.marca, marca) == 0)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto p, string marca) 
        {
            return !(p == marca);
        }


        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if (p1 is not null && p2 is not null && String.Compare(p1.marca, p2.marca) == 0 && String.Compare(p1.codigoDeBarra, p2.codigoDeBarra) == 0)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
