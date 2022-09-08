using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio_Extra
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        private static string ArmarFormatoMensaje()
        {
            string mensajeFormateado;

            mensajeFormateado = "\n*" + Sello.mensaje + "*\n";
            for (int i = 0; i < Sello.mensaje.Length+2; i++)
            {
                mensajeFormateado = mensajeFormateado.Insert(0, "*");
                mensajeFormateado = mensajeFormateado.Insert(mensajeFormateado.Length, "*");
            }

            return mensajeFormateado;
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }
    }
}
