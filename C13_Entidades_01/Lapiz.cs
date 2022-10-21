using C13_Entidades_01.Excepciones;
using System;
using System.Text;

namespace C13_Entidades_01
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { throw new NotImplementedException(); }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if (String.IsNullOrEmpty(texto)) throw new CadenaVaciaException("");

            foreach (char caracter in texto)
            {
                if (!Char.IsWhiteSpace(caracter))
                {
                    this.tamanioMina -= 0.1f;
                    if (this.tamanioMina <= 0.1) throw new CantidadInsuficienteException("El tamaño actual de mina no es suficiente para escribir.");
                }
            }

            return new EscrituraWrapper(texto, ConsoleColor.Gray);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append("Es un lápiz");
            datos.Append($" de color {ConsoleColor.Gray}");
            datos.Append($" y con un tamaño de mina de {this.tamanioMina}");

            return datos.ToString();
        }
    }
}
