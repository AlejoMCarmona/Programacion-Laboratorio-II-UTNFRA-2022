using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12_Ejercicio_01
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre 
        { 
            get { return this.nombre; } 
        }

        public string ObtenerFicha()
        {
            return $"{nombre} fundado el {fechaCreacion.ToString()}";
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (e1 is null || e2 is null) throw new ArgumentNullException("No pueden haber equipos nulos.");

            bool retorno = false;

            if (String.Compare(e1.nombre, e2.nombre) == 0 && DateTime.Compare(e1.fechaCreacion, e2.fechaCreacion) == 0)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
    }
}
