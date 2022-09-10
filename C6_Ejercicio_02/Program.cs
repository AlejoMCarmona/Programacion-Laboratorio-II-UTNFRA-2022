using System;
using System.Collections.Generic;

namespace C6_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            Queue<int> colaNumeros = new Queue<int>();
            Stack<int> pilaNumeros = new Stack<int>();
            int[] arrayPila;
            int[] arrayCola;

            //Cargo las colecciones con números enteros entre -100 y 100, y sin el cero.
            for (int i = 0; i < 20; i++)
            {
                listaNumeros.Add(ObtenerAleatorioDistintoDeNum(-100, 100, 0));
                colaNumeros.Enqueue(ObtenerAleatorioDistintoDeNum(-100, 100, 0));
                pilaNumeros.Push(ObtenerAleatorioDistintoDeNum(-100, 100, 0));
            }

            //Muestro las colecciones tal cual:
            Console.WriteLine("Muestro la lista tal como fue cargada:");
            MostrarLista(listaNumeros);
            Console.WriteLine("Muestro la pila tal como fue cargada:");
            arrayPila = pilaNumeros.ToArray();
            MostrarVector(arrayPila);
            Console.WriteLine("Muestro la cola tal como fue cargada:");
            arrayCola = colaNumeros.ToArray();
            MostrarVector(arrayCola);


            //ORDENARLAS:
            //LISTA
            //1. Ordeno de manera ascendente y luego invierto la lista
            listaNumeros.Sort();
            listaNumeros.Reverse();
            //Muestro solo los números positivos de la lista
            Console.WriteLine("Lista ordenada de manera decreciente (positivos):");
            Program.MostrarLista(listaNumeros, 0);

            //2. Invierto la lista
            listaNumeros.Reverse();
            //Muestro solos los números negativos de la lista
            Console.WriteLine("Lista ordenada de manera creciente (negativos):");
            Program.MostrarLista(listaNumeros, 1);

            //PILA
            //1. Ordeno de manera ascendente y luego invierto el array de la pila
            Array.Sort(arrayPila);
            Array.Reverse(arrayPila);
            //Muestro solo los números positivos del array de la pila
            Console.WriteLine("Pila ordenada de manera decreciente (positivos):");
            Program.MostrarVector(arrayPila, 0);

            //2. Invierto el array de la pila
            Array.Reverse(arrayPila);
            //Muestro solos los números negativos del array de la pila
            Console.WriteLine("Pila ordenada de manera creciente (negativos):");
            Program.MostrarVector(arrayPila, 1);

            //1. COLA
            //Ordeno de manera ascendente y luego invierto el array de la cola
            Array.Sort(arrayCola);
            Array.Reverse(arrayCola);
            //Muestro solo los números positivos del array de la cola
            Console.WriteLine("Cola ordenada de manera decreciente (positivos):");
            Program.MostrarVector(arrayCola, 0);

            //2. Invierto el array de la cola
            Array.Reverse(arrayCola);
            //Muestro solos los números negativos del array de la cola
            Console.WriteLine("Cola ordenada de manera creciente (negativos):");
            Program.MostrarVector(arrayCola, 1);
        }

        #region Metodos distintos al Main
        /// <summary>
        /// Obtiene un número aleatorio entre un determinado rango, pero asegurando que un número no salga elegido.
        /// </summary>
        /// <param name="min">Mínimo del rango, inclusivo</param>
        /// <param name="max">Máximo del rango, inclusivo</param>
        /// <param name="numeroNoAceptado">Número no aceptado en el rango</param>
        /// <returns></returns>
        public static int ObtenerAleatorioDistintoDeNum(int min, int max, int numeroNoAceptado)
        {
            Random r = new Random();
            int numeroRandom;
            do
            {
                numeroRandom = r.Next(min, max + 1);
            } while (numeroRandom == numeroNoAceptado);
            return numeroRandom;
        }

        /// <summary>
        /// Muestra una lista de enteros, tan solo recorriéndola en su totalidad
        /// </summary>
        /// <param name="lista">Lista de enteros a recorrer</param>
        public static void MostrarLista(List<int> lista)
        {
            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }
        }

        /// <summary>
        /// Muestra una lista de enteros en su totalidad, eligiendo si se quieren mostrar los números positivos o negativos. El cero no se
        /// muestra nunca, al considerarsele un número neutro.
        /// </summary>
        /// <param name="lista">Lista de enteros a recorrer</param>
        /// <param name="positivoONegativo">
        ///     Parámetro que determina si se muestran los números enteros positivos o negativos de la lista:
        ///         .Si es igual a 1, se muestran los positivos.
        ///         .Si es cualquier otro número, se muestran los negativos.
        /// </param>
        public static void MostrarLista(List<int> lista, int positivoONegativo)
        {
            foreach (int numero in lista)
            {
                if ((numero > 0 && positivoONegativo == 0) || (numero < 0 && positivoONegativo != 0))
                {
                    Console.WriteLine(numero);
                }
            }
        }

        /// <summary>
        /// Muestra un vector de enteros, tan solo recorriéndolo en su totalidad
        /// </summary>
        /// <param name="arrayNumeros">Vector de enteros a recorrer</param>
        public static void MostrarVector(int[] arrayNumeros)
        {
            foreach (int numero in arrayNumeros)
            {
                Console.WriteLine(numero);
            }
        }

        /// <summary>
        /// Muestra un vector de enteros en su totalidad, eligiendo si se quieren mostrar los números positivos o negativos. El cero no se
        /// muestra nunca, al considerarsele un número neutro.
        /// </summary>
        /// <param name="arrayNumeros">Vector de enteros a recorrer</param>
        /// <param name="positivoONegativo">
        ///     Parámetro que determina si se muestran los números enteros positivos o negativos del array:
        ///         .Si es igual a 1, se muestran los positivos.
        ///         .Si es cualquier otro número, se muestran los negativos.
        /// </param>
        public static void MostrarVector(int[] arrayNumeros, int positivoONegativo)
        {
            foreach (int numero in arrayNumeros)
            {
                if ((numero > 0 && positivoONegativo == 0) || (numero < 0 && positivoONegativo != 0))
                {
                    Console.WriteLine(numero);
                }
            }
        }
        #endregion
    }
}
