using C13_Entidades_01.Excepciones;
using System;
using System.Text;

namespace C13_Entidades_01
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura 
        {
            get { return this.tinta; } 
            set 
            {
                if (value < 0) 
                    throw new Exception("No se puede asignar un numero negativo como unidad de escritura.");
                this.tinta = value; 
            } 
        }
         
        public EscrituraWrapper Escribir(string texto)
        {
            if (String.IsNullOrEmpty(texto)) throw new CadenaVaciaException();

            foreach (char caracter in texto)
            {
                if (!Char.IsWhiteSpace(caracter))
                {
                    this.tinta -= 0.3f;
                    if (this.tinta < 0.3) throw new CantidadInsuficienteException("La cantidad de tinta disponible no es suficiente para escribir.");
                }
            }

            return new EscrituraWrapper(texto, this.colorTinta);
        }

        public bool Recargar(int unidades)
        {
            bool retorno = false;

            if (unidades > 0)
            {
                this.tinta += unidades;
                retorno = true;
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append("Es un boligrafo");
            datos.Append($" de color {this.colorTinta}");
            datos.Append($" y con un nivel de tinta de {this.tinta}");

            return datos.ToString();
        }
    }
}
