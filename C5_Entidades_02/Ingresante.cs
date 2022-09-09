using System;
using System.Text;

namespace C5_Entidades_02
{
    public class Ingresante
    {
        #region Atributos
        private string[] cursos;
        private string direccion;
        private string genero;
        private string nombre;
        private string pais;
        private int edad;
        #endregion

        #region Constructores
        public Ingresante(string nombre, string direccion, string genero, string pais, int edad, string[] cursos)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
            this.edad = edad;
        }
        #endregion

        #region Propiedades
        //Solo para prácticar la creación de propiedades, no es necesario.
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public string[] Cursos
        {
            get { return this.cursos; }
            set { this.cursos = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public string Pais
        {
            get { return this.pais; }
            set { this.pais = value; }
        }

        public string Genero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Datos del usuario:");
            retorno.AppendLine($"Nombre: {this.nombre}");
            retorno.AppendLine($"Genero:  {this.genero}");
            retorno.AppendLine($"Edad: {this.edad}");
            retorno.AppendLine($"Pais: {this.pais}");
            retorno.AppendLine($"Direccion: {this.direccion}");
            retorno.AppendLine("Cursos:");

            foreach (string curso in this.cursos)
            {
                if (!string.IsNullOrWhiteSpace(curso))
                {
                    retorno.AppendLine($"  {curso}");
                }
            }

            return retorno.ToString();
        }
        #endregion
    }
}
