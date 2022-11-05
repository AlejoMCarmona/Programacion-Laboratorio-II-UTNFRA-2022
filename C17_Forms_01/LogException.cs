using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C17_Forms_01
{
    public static class LogException
    {
        public static void MostrarExcepcion(Exception exception, string titulo)
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Mensaje: {exception.Message}");
            mensaje.AppendLine($"Detalles:");
            mensaje.AppendLine(exception.StackTrace);
            MessageBox.Show(mensaje.ToString(), titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarExcepcion(Exception exception)
        {
            LogException.MostrarExcepcion(exception, "ERROR");
        }
    }
}
