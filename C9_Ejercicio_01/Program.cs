using System;

namespace C9_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //**PARTE 1**
            //Console.Title = "Ejercicio Sobre-Sobrescrito";
            //Sobrescrito objetoSobrescrito = new Sobrescrito();

            //Console.WriteLine(objetoSobrescrito.ToString());

            //string objeto = "¡Este es mi método ToString sobrescrito!";

            //Console.WriteLine("----------------------------------------------");
            //Console.Write("Comparación Sobrecargas con String: ");
            //Console.WriteLine(objetoSobrescrito.Equals(objeto));

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine(objetoSobrescrito.GetHashCode());

            //**PARTE 2**
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobrescrito objetoSobreSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobreSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobreSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobreSobrescrito.GetHashCode());

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobreSobrescrito.MiMetodo());

            Console.ReadKey();
        }
    }
}
