using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C6_Entidades_03
{
    public class Diccionario
    {
        private Dictionary<string, int> diccionarioPalabras;
        public Diccionario()
        {
            this.diccionarioPalabras = new Dictionary<string, int>();
        }

        public Diccionario(Dictionary<string, int> diccionarioPalabras)
        {
            this.diccionarioPalabras = diccionarioPalabras;
        }

        public Dictionary<string, int> DiccionarioPalabras { 
            get { return this.diccionarioPalabras;  }
        }

        /// <summary>
        /// Agrega nuevas palabras al diccionario. Basándose en una cadena de texto conformada por distintas palabras separadas por un espacio en blanco o un salto de línea.
        /// </summary>
        /// <param name="textoPalabras">Cadena de texto conformada por distintas palabras separadas por un espacio en blanco o un salto de línea.</param>
        public void AgregarPalabras(string textoPalabras)
        {
            string palabra;
            int indice = 0;
            bool masPalabras;

            do
            {
                masPalabras = false;
                if (textoPalabras.Contains(" "))
                {
                    indice = textoPalabras.LastIndexOf(" "); //ultima ocurrencia de un espacio en blanco
                    masPalabras = true;
                }
                if (textoPalabras.Contains("\n"))
                {
                    if (!masPalabras || indice < textoPalabras.LastIndexOf("\n")) //ultima ocurrencia de un salto de línea
                    {
                        indice = textoPalabras.LastIndexOf("\n");
                    }
                    masPalabras = true;
                }

                if (masPalabras)
                {
                    palabra = textoPalabras.Substring(indice + 1, (textoPalabras.Length - 1 - indice)); //obtengo la palabra
                    textoPalabras = textoPalabras.Substring(0, indice); //la saco del string
                }
                else
                {
                    palabra = textoPalabras;
                }

                if (!this.diccionarioPalabras.ContainsKey(palabra))
                {
                    this.diccionarioPalabras.Add(palabra, 1);
                }
                else
                {
                    this.diccionarioPalabras[palabra] = this.diccionarioPalabras[palabra] + 1;
                }
            } while (masPalabras);
        }

        /// <summary>
        /// Ordena las palabras del diccionario basándose en la cantidad de veces que se utilizan.
        /// </summary>
        /// <param name="tipoOrdenamiento">
        ///     Parámetro que indica tipo de ordenamiento a realizar. Por defecto se ordena de manera ascendente.
        ///         1. Ordenamiento descendente.
        ///         0. Ordenamiento ascendente.
        /// </param>
        public void OrdenarPalabrasPorUso(int tipoOrdenamiento = 0)
        {
            if (tipoOrdenamiento == 0)
            {
                this.diccionarioPalabras = this.diccionarioPalabras.OrderBy(palabra => palabra.Value).ToDictionary(palabra => palabra.Key, palabra => palabra.Value);
            } else
            {
                this.diccionarioPalabras = this.diccionarioPalabras.OrderBy(palabra => palabra.Value).Reverse().ToDictionary(palabra => palabra.Key, palabra => palabra.Value);
            }
        }

        /// <summary>
        /// Devuelve un string con la cantidad de palabras más usadas indicada por parámetro.
        /// </summary>
        /// <param name="top">Parámetro que indica cantidad de palabras a mostrar.</param>
        /// <returns>Cadena con las palabras más usadas ordenadas en forma de columna.</returns>
        public string MostrarPalabrasMasUsadas(int top)
        {
            StringBuilder sb = new StringBuilder();

            if (top > this.diccionarioPalabras.Count)
            {
                sb.Append("ERROR! El top es más grande que la cantidad de palabras.");
            } else
            {
                this.OrdenarPalabrasPorUso(1);
                for (int i = 0; i < top; i++)
                {
                    sb.AppendLine($"{i+1} - {this.diccionarioPalabras.ElementAt(i).Key}");
                }
            }

            return sb.ToString();
        }
    }
}
