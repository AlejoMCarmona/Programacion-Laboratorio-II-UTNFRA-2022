using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace C19_Entidades_02
{
    public delegate void delegadoClienteAtendido(Caja c, string s); //podría ser un Action

    public class Caja
    {
        static Random random;
        public Queue<String> clientesALaEspera;
        public string nombreCaja;
        private delegadoClienteAtendido delegado;

        static Caja()
        {
            Caja.random = new Random();
        }

        public Caja(string nombreCaja, delegadoClienteAtendido delegado)
        {
            this.clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            this.delegado = delegado;
        }

        public string NombreCaja 
        {
            get { return this.nombreCaja; } 
        }

        public int CantidadDeClientesALaEspera
        {
            get { return this.clientesALaEspera.Count; }
        }

        internal void AgregarCliente(string cliente)
        {
            if (!String.IsNullOrEmpty(cliente))
            {
                this.clientesALaEspera.Enqueue(cliente);
            }
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(() =>
            {
                while (true)
                {
                    if (this.clientesALaEspera.Any())
                    {
                        string nombreCliente = this.clientesALaEspera.Dequeue();
                        this.delegado(this, nombreCliente);
                        Thread.Sleep(random.Next(1, 6) * 1000);
                    }
                }
            });
        }

    }
}
