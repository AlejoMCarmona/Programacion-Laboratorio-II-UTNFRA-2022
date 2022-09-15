using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_Ejercicio_01
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get {
                Cliente c = null;
                if (clientes.Count > 0)
                {
                    c = clientes.Peek();
                }
                return c;
            }
            set {
                //  esta clase (negocio) + value;
                //  negocio + cliente => se agrega el cliente a la cola clientes
                _ = this + value; //no hago un enqueue por temas de enunciado ().
                }
        }

        public int ClientesPendientes { 
            get {
                return this.clientes.Count;
            } 
        }

        private Negocio()
        {
            this.caja = new PuestoAtencion(ePuesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator == (Negocio n, Cliente c) 
        {
            bool retorno = false;

            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator != (Negocio n, Cliente c) 
        {
            return !(n == c);
        }
        
        public static bool operator ~ (Negocio n) 
        {
            bool retorno = false;

            if (n.ClientesPendientes > 0)
            {
                retorno = n.caja.Atender(n.Cliente);
            }

            if (retorno)
            {
                n.clientes.Dequeue();
            }

            return retorno;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;

            if (n != c) //el c == c se usa en el n != c
            {
                n.clientes.Enqueue(c);
                retorno = true;
            };

            return retorno;
        }
    }
}
