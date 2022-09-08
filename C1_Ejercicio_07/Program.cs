using System;

namespace C1_Ejercicio_07
{
    class Program
    {
        /*
        EJERCICIO 7:
         Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
         Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
         Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
        Importante
         Utilizar sentencias de iteración y selectivas.
         No es necesario ni se deben utilizar vectores/arrays.
        */
        static void Main(string[] args)
        {
            double valorHora;
            string nombre;
            string recibos = "";
            double totalBruto;
            double totalNeto;
            int cantidadAniosAntiguedad;
            int cantidadHorasTrabajadas;
            string respuesta;
            bool flag;

            Console.WriteLine("Ingreso de información de empleados");
            do
            {
                do
                {
                    Console.Write("Ingrese el valor hora: ");
                    flag = double.TryParse(Console.ReadLine(), out valorHora);
                    if (!flag || valorHora < 1) Console.WriteLine("ERROR ¡Ingrese un valor hora válido!");
                } while (!flag || valorHora < 1);

                do
                {
                    Console.Write("Ingrese el nombre del empleado: ");
                    nombre = Console.ReadLine();
                    if (String.IsNullOrEmpty(nombre)) Console.WriteLine("ERROR ¡Ingrese un nombre válido!");
                } while (String.IsNullOrEmpty(nombre));

                do
                {
                    Console.Write("Ingrese la antiguedad en años del empleado: ");
                    flag = int.TryParse(Console.ReadLine(), out cantidadAniosAntiguedad);
                    if (!flag || cantidadAniosAntiguedad < 0) Console.WriteLine("ERROR ¡Ingrese una cantidad de años válida!");
                } while (!flag || cantidadAniosAntiguedad < 0);

                do
                {
                    Console.Write("Ingrese la cantidad de horas trabajadas: ");
                    flag = int.TryParse(Console.ReadLine(), out cantidadHorasTrabajadas);
                    if (!flag || cantidadHorasTrabajadas < 0) Console.WriteLine("ERROR ¡Ingrese una cantidad de horas válidas!");
                } while (!flag || cantidadHorasTrabajadas < 0);

                totalBruto = (valorHora * cantidadHorasTrabajadas) + cantidadAniosAntiguedad * 150;
                totalNeto = totalBruto * 0.87;

                recibos += ("Nombre: " + nombre + "\nAntiguedad: " + cantidadAniosAntiguedad + "\nValor de hora: $" + valorHora + "\nTotal a cobrar en bruto: $" + totalBruto + "\nTotal a cobrar en neto: $" + totalNeto + "\n--------------------------\n"); 

                Console.Write("¿Desea seguir ingresando empleados? (S para continuar): ");
                respuesta = Console.ReadLine();
                Console.WriteLine("---------------------------------");
            } while (respuesta.Equals("S"));

            Console.WriteLine("\nRECIBOS:\n{0}", recibos);
        }
    }
}

/*
 DATOS DE PRUEBA:
valor hora: 50
nombre: alejo
antiguedad: 5
horas: 50

bruto: 3250
neto:2827.5

valor hora: 50
nombre: juan
antiguedad: 9
horas: 80

bruto:5350
neto:4654.5

valor hora: 90
nombre: martin
antiguedad: 15
horas: 91

bruto: 10440
neto:9082.8

valor hora: 20
nombre: santiago
antiguedad: 0
horas: 40

bruto: 800
neto: 696
 
 
 */
