using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Ejercicio_0
{
    public class Empleado
    {
        private int id;
        private string nombre;
        private string apellido;
        private int idPuesto;
        private double sueldo;
        private bool estaActivo;
        private string fecha_alta;

        public Empleado(int id, string nombre, string apellido, int idPuesto, double sueldo, bool estaActivo, string fecha_alta)
        {
            this.id = id;
            this.nombre = nombre;
            this.idPuesto = idPuesto;
            this.apellido = apellido;
            this.estaActivo = estaActivo;
            this.fecha_alta = fecha_alta;
            this.sueldo = sueldo;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int IdPuesto 
        {
            get { return this.idPuesto; }
            set { this.idPuesto = value; }
        }
        public double Sueldo 
        {
            get { return this.sueldo; }
            set { this.sueldo = value; }
        }
        public bool EstaActivo
        {
            get { return this.estaActivo; }
            set { this.estaActivo = value; }
        }

        public string FechaAlta
        {
            get { return this.fecha_alta; }
            set { this.fecha_alta = value; }
        }

        public string CalcularSueldo()
        {
            return "sueldo";
        }

        public double Facturar()
        {
            return 100;
        }

    }
}
