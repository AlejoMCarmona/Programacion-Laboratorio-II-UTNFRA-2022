using System;
using System.Threading;

namespace C7_Ejercicio_01
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private ePuesto puesto;

        static int NumeroActual
        {
            get {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual; //preguntar => rta: no se usa, medio raro el enunciado.
            }
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(ePuesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            bool retorno = false;
            if (cli is not null)
            {
                Thread.Sleep(2000);
                retorno = true;
            }
            return retorno;
        }

    }
}
