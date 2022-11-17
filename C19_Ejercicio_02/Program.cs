using C19_Entidades_02;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace C19_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //[Hora actual con formato HH:MM:ss] - Hilo [Id del hilo actual (usar `Task.CurrentId`)] - [Nombre de la caja] - Atendiendo a [nombre del cliente].
            //Quedan [cantidad de clientes a la espera] clientes en esta caja.
            delegadoClienteAtendido delegado = (Caja caja, string cliente) =>
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(DateTime.UtcNow + " - ");
                sb.Append($"Hilo {Task.CurrentId} - ");
                sb.Append($"{caja.NombreCaja} - ");
                sb.Append($"Atendiendo a {cliente}. ");
                sb.Append($"Quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja");
                Console.WriteLine(sb.ToString());
            };
            

            Caja caja1 = new Caja("Caja 01", delegado);
            Caja caja2 = new Caja("Caja 02", delegado);

            List<Caja> listaCajas = new List<Caja>();
            listaCajas.Add(caja1);
            listaCajas.Add(caja2);

            Negocio negocio = new Negocio(listaCajas);

            Console.WriteLine("Asignando cajas...");

            List<Task> listaTareasNegocio = negocio.ComenzarAtencion();

            Task.WaitAll(listaTareasNegocio.ToArray());
        }
    }
}
