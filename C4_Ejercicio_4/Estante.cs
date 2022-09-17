using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_Entidades_4
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad]; 
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] Productos { get { return this.productos; } }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder informacionEstante = new StringBuilder();

            if (e is not null)
            {
                informacionEstante.AppendLine("UBICACIÓN DEL ESTANTE: " + e.ubicacionEstante);
                informacionEstante.AppendLine("*********Productos*********");

                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is not null)
                    {
                        informacionEstante.AppendLine(Producto.MostrarProducto(e.productos[i]));
                    }
                }
            } else
            {
                informacionEstante.AppendLine("");
            }

            return informacionEstante.ToString();
        }

        public static bool operator ==(Estante e, Producto p) 
        {
            bool retorno = false;

            if (e is not null && p is not null)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }
        public static bool operator !=(Estante e, Producto p) 
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;

            if (e is not null && p is not null && e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static bool operator -(Estante e, Producto p)
        {
            bool retorno = false;

            if (e is not null && p is not null && e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }
    }
}
