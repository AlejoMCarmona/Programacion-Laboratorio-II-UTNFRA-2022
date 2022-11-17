using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C19_Entidades_02
{
    public class Negocio
    {
        static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        List<Caja> cajas;

        static Negocio()
        {
            Negocio.realNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.clientes = new ConcurrentQueue<string>();
            this.cajas = cajas;
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> tareas = new List<Task>();

            foreach (Caja caja in this.cajas)
            {
                tareas.Add(caja.IniciarAtencion());
                tareas.Add(Task.Run(() =>
                {
                    while (true)
                    {
                        this.clientes.Enqueue(realNameGenerator.Generate());
                        Thread.Sleep(1000);
                    }
                }));
                tareas.Add(Task.Run(() => 
                {
                    while (true)
                    {
                        Caja cajaConMenosClientes = this.cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                        string cliente = "";
                        if (this.clientes.TryDequeue(out cliente))
                        {
                            caja.AgregarCliente(cliente);
                        }
                    }
                }));
            }

            return tareas;
        }
    }
}
