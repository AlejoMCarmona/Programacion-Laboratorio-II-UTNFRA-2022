using System;

namespace C2_Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int opcion;
            bool flag;
            double longitudLado;
            double longitudLadoAux;
            double areaCalculada = 0;

            do
            {
                do
                {
                    Console.WriteLine("Elija un área a calcular:");
                    Console.WriteLine("1- Cuadrado\n2- Triangulo\n3- Círculo\n");
                    flag = int.TryParse(Console.ReadLine(), out opcion);
                    if (!flag || (opcion != 1 && opcion != 2 && opcion != 3)) Console.WriteLine("ERROR ¡Ingrese una opción válida!\n");
                } while (!flag || (opcion != 1 && opcion != 2 && opcion != 3));

                Console.WriteLine("");
                switch (opcion)
                {
                    case 1:
                        longitudLado = Program.IngresarDoublePositivo("Ingrese la longitud de los lados: ", "ERROR ¡Ingrese una longitud válida!");
                        areaCalculada = CalculadoraDeArea.CalcularAreaCuadrado(longitudLado);
                        break;
                    case 2:
                        longitudLado = Program.IngresarDoublePositivo("Ingrese la longitud de la base: ", "ERROR ¡Elija una longitud válida!");
                        longitudLadoAux = Program.IngresarDoublePositivo("Ingrese la longitud de la altura: ", "ERROR ¡Ingrese una longitud válida!");
                        areaCalculada = CalculadoraDeArea.CalcularAreaTriangulo(longitudLado, longitudLadoAux);
                        break;
                    case 3:
                        longitudLado = Program.IngresarDoublePositivo("Ingrese el radio del círculo: ", "ERROR ¡Ingrese un radio válido!");
                        areaCalculada = CalculadoraDeArea.CalcularAreaCirculo(longitudLado);
                        break;
                }

                Console.WriteLine("Resultado del área: {0}\n", areaCalculada);

                Console.WriteLine("¿Desea seguir calculando áreas? (S para continuar)");
                respuesta = Console.ReadLine();
                Console.WriteLine("\n------------------------------------------");
            } while (respuesta.Equals("S"));
        }

        public static double IngresarDoublePositivo(string mensaje, string mensajeError)
        {
            double numero;
            bool flag;

            do
            {
                Console.Write(mensaje);
                flag = double.TryParse(Console.ReadLine(), out numero);
                if (!flag || numero < 0) Console.WriteLine(mensajeError);
            } while (!flag || numero < 0);

            return numero;
        }
    }
}

/*
            do
            {
                do
                {
                    Console.Write("Ingrese el tipo de área a calcular: ");
                    flag = int.TryParse(Console.ReadLine(), out opcion);
                    if (!flag && opcion != 1 && opcion != 2 && opcion != 3) Console.WriteLine("ERROR ¡Elija una opción válida
                } while (!flag && opcion != 1 && opcion != 2 && opcion != 3);

                Console.WriteLine("¿Desea seguir calculando áreas?");
                respuesta = Console.ReadLine();
            } while (true);
 */
