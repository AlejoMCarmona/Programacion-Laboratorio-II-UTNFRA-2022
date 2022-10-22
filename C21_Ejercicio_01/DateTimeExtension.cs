using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21_Ejercicio_01
{
    public static class DateTimeExtension
    {
        public static string ObtenerPlacaCronicaTV(this DateTime fecha, eEstaciones estacion)
        {
            DateTime fechaCambioEstacion = ObtenerFechaCambioDeEstacion(estacion, fecha.Year);
            double cantidadDias = 0;

            if (fecha > fechaCambioEstacion)
            {
                fechaCambioEstacion = fechaCambioEstacion.AddYears(1);
            }

            cantidadDias = (fechaCambioEstacion - fecha).TotalDays;

            return $"Faltan {cantidadDias} para el {Enum.GetName(estacion)}";
        }

        private static DateTime ObtenerFechaCambioDeEstacion(eEstaciones estacion)
        {
            return DateTimeExtension.ObtenerFechaCambioDeEstacion(estacion, 0);
        }

        private static DateTime ObtenerFechaCambioDeEstacion(eEstaciones estacion, int anio)
        {
            DateTime fechaCambioEstacion;

            if (anio <= 0)
            {
                anio = DateTime.Now.Year;
            }

            switch (estacion)
            {
                case eEstaciones.Verano:
                    fechaCambioEstacion = new DateTime(anio, 12, 21);
                    break;
                case eEstaciones.Otono:
                    fechaCambioEstacion = new DateTime(anio, 03, 21);
                    break;
                case eEstaciones.Invierno:
                    fechaCambioEstacion = new DateTime(anio, 06, 21);
                    break;
                case eEstaciones.Primavera:
                    fechaCambioEstacion = new DateTime(anio, 09, 21);
                    break;
                default:
                    fechaCambioEstacion = new DateTime();
                    break;
            }

            return fechaCambioEstacion;
        }
    }
}
