using System;
using System.Text;

namespace EmpresaTransporte
{
    public class Conductor
    {
        private string nombre;
        private int[] kmRecorridos;

        public string Nombre { 
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int[] KmRecorridos
        {
            get { return this.kmRecorridos; }
            set { this.kmRecorridos = value; }
        }

        public Conductor()
        {
            this.nombre = "";
            this.kmRecorridos = new int[7];
            for (int i = 0; i < 7; i++)
            {
                this.kmRecorridos[i] = 0;
            }
        }

        public Conductor(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Conductor(string nombre, int[] kmRecorridos) : this(nombre)
        {
            this.kmRecorridos = kmRecorridos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            for (int i = 0; i < 7; i++)
            {
                sb.AppendLine($"Dia {i+1}: {this.kmRecorridos[i]}");
            }

            return sb.ToString();
        }
    }
}
