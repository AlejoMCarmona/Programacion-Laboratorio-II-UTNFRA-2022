using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    public class Empresa
    {
        private string nombre;
        private Conductor[] conductores; //lo haría con una lista, pero el enunciado dice que es un array.

        public string Nombre { 
            get { return this.nombre; }
        }

        public Conductor[] Conductores
        {
            get { return this.conductores; }
        }

        public Empresa()
        {
            this.nombre = "Sin nombre";
            this.conductores = new Conductor[5]; //5 conductores máximo solamente.
            for (int i = 0; i < 5; i++)
            {
                conductores[i] = new Conductor();
            }
        }

        public Empresa(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Empresa(string nombre, Conductor[] conductores) : this(nombre)
        {
            this.conductores = conductores;
        }

        public bool SetNuevoConductor(string nombre, int[] kmRecorridos)
        {
            bool retorno = false;

            for (int i = 0; i < this.conductores.Length; i++)
            {
                if (this.conductores[i].Nombre.Equals(""))
                {
                    this.conductores[i].Nombre = nombre;
                    kmRecorridos.CopyTo(this.conductores[i].KmRecorridos, 0);
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public Conductor HallarConductorConMaximoKMEnUnDia(int dia)
        {
            int maximoKM = -1;
            int contador = 0;
            int indiceConductorMaximo = 0;
            Conductor conductor = null;
            dia--;

            while (contador < this.conductores.Length && !this.conductores[contador].Nombre.Equals(""))
            {
                if (contador == 0 || this.conductores[contador].KmRecorridos[dia] > maximoKM)
                {
                    maximoKM = this.conductores[contador].KmRecorridos[dia];
                    indiceConductorMaximo = contador;
                }
                contador++;
            }

            if (maximoKM != -1)
            {
                conductor = this.conductores[indiceConductorMaximo];
            }

            return conductor;
        }

        public Conductor HallarConductorConMaximoKMEnLaSemana()
        {
            int acumuladorKM = 0;
            int maximosKMSemanales = -1;
            int indiceMaximoConductor = 0;
            Conductor conductor = null;

            for (int i = 0; i < this.conductores.Length; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    acumuladorKM += this.conductores[i].KmRecorridos[j];
                }

                if (i == 0 || acumuladorKM > maximosKMSemanales)
                {
                    indiceMaximoConductor = i;
                    maximosKMSemanales = acumuladorKM;
                }
                acumuladorKM = 0;
            }

            if (maximosKMSemanales != -1)
            {
                conductor = this.conductores[indiceMaximoConductor];
            }

            return conductor;
        }
    }
}
