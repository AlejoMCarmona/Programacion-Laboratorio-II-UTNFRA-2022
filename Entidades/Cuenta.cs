using System;
using System.Text;

namespace C3_Entidades_01
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta (string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular()
        {
            return this.titular;
        }

        public decimal Cantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos de la cuenta:");
            sb.AppendLine($"Titular: {this.titular}");
            sb.AppendLine($"Cantidad: {this.cantidad}");

            return sb.ToString();
        }

        public bool Ingresar(decimal cantidad)
        {
            bool retorno = false;
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
                retorno = true;
            }
            return retorno;
        }

        public bool Retirar(decimal cantidad)
        {
            bool retorno = false;
            if (cantidad > 0)
            {
                this.cantidad -= cantidad;
                retorno = true;
            }
            return retorno;
        }
    }
}
