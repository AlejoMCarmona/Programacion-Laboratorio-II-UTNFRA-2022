using System;
using System.Collections.Generic;

namespace C7_Entidades_02
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int index] 
        {
            get {
                string retorno = "";
                if (paginas.Count - 1 >= index)
                {
                    retorno = paginas[index];
                }
                return retorno;
            }
            set { 
                if (paginas.Count - 1 >= index)
                {
                    paginas[index] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }

    }
}
