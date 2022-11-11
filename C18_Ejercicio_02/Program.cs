using System;
using System.Collections.Generic;

namespace C18_Ejercicio_02
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            // Borrar o agregar la primera barra para switchear entre las pruebas fijas y el ingreso de texto por consola. 
            //*
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2

            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/
            //int a = String.Compare("alejo", "abril"); //string1 > string2 == 1
            //a = String.Compare("abril", "alejo"); //string1 < string2 == -1
            //a = String.Compare("abril", "abril"); //string1 == string2 == 0
            Console.WriteLine($"Texto mayor:");
            Program.Comparar(primerTexto, segundoTexto, String.Compare);
                
            Console.WriteLine($"1era Comparación - Texto con más caracteres:");
            // Punto 2
            Program.Comparar(primerTexto, segundoTexto, 
                (t1, t2) => 
                {
                    int retorno = 0;
                    int cantidadCaracteresPrimerTexto = Program.ContarVocales(t1) + Program.ContarSignosPuntuacion(t1);
                    int cantidadCaracteresSegundoTexto = Program.ContarVocales(t2) + Program.ContarSignosPuntuacion(t2);
                    if (cantidadCaracteresPrimerTexto > cantidadCaracteresSegundoTexto)
                    {
                        retorno = 1;
                    } else if (cantidadCaracteresPrimerTexto < cantidadCaracteresSegundoTexto)
                    {
                        retorno = -1;
                    }
                    return retorno;
                });

            Console.WriteLine($"2da Comparación - Texto con más palabras:");
            // Punto 3
            Program.Comparar(primerTexto, segundoTexto,
                (t1, t2) =>
                {
                    int cantidadPalabrasPrimerTexto = t1.Split(' ').Length + t1.Split('\n').Length;
                    int cantidadPalabrasSegundoTexto = t2.Split(' ').Length + t2.Split('\n').Length ;
                    int retorno = 0;
                    if (cantidadPalabrasPrimerTexto > cantidadPalabrasSegundoTexto)
                    {
                        retorno = 1;
                    } else if (cantidadPalabrasPrimerTexto < cantidadPalabrasSegundoTexto)
                    {
                        retorno = -1;
                    }
                    return retorno;
                });

            Console.WriteLine($"3era Comparación - Texto con más vocales:");
            // Punto 4
            Program.Comparar(primerTexto, segundoTexto,
                (t1, t2) =>
                {
                    int cantidadVocalesPrimerTexto = Program.ContarVocales(t1);
                    int cantidadVocalesSegundoTexto = Program.ContarVocales(t2);
                    int retorno = 0;
                    if (cantidadVocalesPrimerTexto > cantidadVocalesSegundoTexto)
                    {
                        retorno = 1;
                    }
                    else if (cantidadVocalesPrimerTexto < cantidadVocalesSegundoTexto)
                    {
                        retorno = -1;
                    }
                    return retorno;
                });

            Console.WriteLine($"4ta Comparación - Texto con más signos de puntuación:");
            // Punto 5
            Program.Comparar(primerTexto, segundoTexto,
                (t1, t2) =>
                {
                    int cantidadSignosPrimerTexto = Program.ContarSignosPuntuacion(t1);
                    int cantidadSignosSegundoTexto = Program.ContarSignosPuntuacion(t2);
                    int retorno = 0;
                    if (cantidadSignosPrimerTexto > cantidadSignosSegundoTexto)
                    {
                        retorno = 1;
                    }
                    else if (cantidadSignosPrimerTexto < cantidadSignosSegundoTexto)
                    {
                        retorno = -1;
                    }
                    return retorno;
                });
        }

        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }

        public static void Comparar(string texto1, string texto2, DelegadoComparacion comparacion)
        {
            string mensaje = "Ambos textos son iguales";
            int resultadoComparacion = comparacion(texto1, texto2);

            if (resultadoComparacion > 0)
            {
                mensaje = "Primer texto.";
            } else if (resultadoComparacion < 0)
            {
                mensaje = "Segundo texto.";
            }

            Console.WriteLine(mensaje);
        }
    }
}
