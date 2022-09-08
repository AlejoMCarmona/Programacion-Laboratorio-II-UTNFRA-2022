using System;

namespace C2_Ejercicio_04
{
    class Program
    {
        /*
        EJERCICIO 4:
         Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
         Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
          + Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación
          + Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
            Este método devolverá true si el operando es distinto de cero.
         Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
         El usuario decidirá cuándo finalizar el programa.
       */
        static void Main(string[] args)
         {
            string opcion;
            string continuar = "s";
            double primerOperando;
            double segundoOperando;
            double resultado;

            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("Elija la operación a realizar:\n" +
                                  "+: Suma\n" +
                                  "-: Resta\n" +
                                  "*: Multipliacion\n" +
                                  "/: Division\n");
                Console.Write("Opcion: ");

                opcion = Console.ReadLine();
                Console.WriteLine("");
                if (opcion != "+" && opcion != "-" && opcion != "*" && opcion != "/")
                {
                    Console.WriteLine("ERROR. ¡Ingrese una operación válida!\n");
                    continue;
                }

                primerOperando = IngresarDouble();
                segundoOperando = IngresarDouble();
                resultado = Calculadora.Calcular(primerOperando, segundoOperando, opcion);
                Console.WriteLine("");
                if (double.IsNaN(resultado))
                {
                    Console.WriteLine("ERROR a la hora de calcular. No puede dividir por cero.\n");
                } else
                {
                    Console.WriteLine("RESULTADO: {0}\n", resultado);
                }

                Console.Write("¿Desea seguir operando? (s para continuar): ");
                continuar = Console.ReadLine();
                Console.WriteLine("");
            } while (continuar == "s");
        }

        public static double IngresarDouble()
        {
            double numero;
            bool flag;

            do
            {
                Console.Write("Ingrese un número: ");
                flag = double.TryParse(Console.ReadLine(), out numero);
                if (!flag) Console.WriteLine("ERROR. ¡Reingrese el número nuevamente!");
            } while (!flag);

            return numero;
        }
    }
}
