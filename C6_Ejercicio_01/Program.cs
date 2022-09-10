using System;

namespace C6_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arrayNumeros = new int[20];
            int contador = 0;

            //Cargo un array, evitando que se me carguen números negativos.
            while (contador < 20)
            {
                arrayNumeros[contador] = random.Next(-100, 101); //número entre -100 y 100
                if (arrayNumeros[contador] != 0)
                {
                    contador++;
                }
            }

            //Muestro el array
            Console.WriteLine("Vector tal cual fue ingresado:");
            Program.MostrarVector(arrayNumeros);

            //Ordeno de manera ascendente y luego invierto el array
            Array.Sort(arrayNumeros);
            Array.Reverse(arrayNumeros);
            //Muestro solo los números positivos del array
            Console.WriteLine("Vector ordenado de manera decreciente (positivos):");
            Program.MostrarVector(arrayNumeros, 0);

            //Invierto el array
            Array.Reverse(arrayNumeros);
            //Muestro solos los números negativos del array
            Console.WriteLine("Vector ordenado de manera creciente (negativos):");
            Program.MostrarVector(arrayNumeros, 1);
        }

        #region Metodos distintos al Main
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
        public static void MostrarVector(int[] arrayNumeros,  int positivoONegativo)
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
