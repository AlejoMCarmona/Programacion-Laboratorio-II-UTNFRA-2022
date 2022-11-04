using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace C17_Ejercicio_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //******************LECTURA******************
            ////**ESTABLECIENDO LA CONEXIÓN**
            //SqlConnection conexion = null;
            //string connectionString;
            //try 
            //{
            //    //La conexión string se obtuvo de: Server = myServerAddress; Database = myDataBase; Trusted_Connection = True;
            //    connectionString = "Server = .; Database = C16_01_EMPRESA_DB; Trusted_Connection = True";

            //    //Necesitamos una cadena de conexión para conectar la BBDD.
            //    conexion = new SqlConnection(connectionString);

            //    //Debemos, antes de realizar consultas, abrir la conexion:
            //    conexion.Open();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //Luego de abrir una conexion, debe cerrarse, aunque en este caso se usará más adelante así que no.
            //    //conexion.Close();
            //}

            ////**EJECUTANDO UN COMANDO**
            ////Necesitamos un command, que será donde colocaremos la query a realizar y quien ejecutará la misma:
            //SqlCommand command;
            //SqlDataReader reader;
            //command = new SqlCommand();
            //try
            //{
            //    //Especificamos el tipo de comando:
            //    command.CommandType = System.Data.CommandType.Text;
            //    //Especificamos a través de quien realizaremos la conexión:
            //    command.Connection = conexion;

            //    //Especificamos la consulta SQL:
            //    command.CommandText = "SELECT * FROM Empleados";

            //    //Pero... donde guardo lo que devuelve?
            //    //Para eso usamos la clase SqlDataReader:
            //    reader = command.ExecuteReader();

            //    List<Empleado> empleados = new List<Empleado>();
            //    //Leemos lo que tiene el reader.
            //    //Mientras tenga datos para leer, sigue trayendo datos.
            //    while (reader.Read()) //Devuelve false si no hay más filas a leer.
            //    {
            //        //Obtengo el dato que quiero del reader y lo muestro:
            //        string nombre = reader["NOMBRE"].ToString();
            //        double sueldo = (double)reader["SALARIO"];
            //        int idPuesto = (int)reader["ID_PUESTO"];

            //        Empleado e = new Empleado(nombre, idPuesto, sueldo);
            //        empleados.Add(e);

            //        Console.Write(e.IdPuesto);
            //        Console.Write(e.Nombre);
            //        Console.WriteLine($" - {e.Sueldo}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //Debemos cerrar la conexion si está abierta:
            //    if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
            //}

            //******************INSERCIÓN******************
            //string connectionString = "Server = .; Database = C16_01_EMPRESA_DB; Trusted_Connection = True";
            //SqlConnection conexion = new SqlConnection(connectionString);

            //string consulta = "INSERT INTO Empleados VALUES ('Juancito', 'Perez', 1, 150, 'true', '2012-01-01', NULL, NULL)";

            ////Otra forma de instanciar un comando:
            //SqlCommand command = new SqlCommand(consulta, conexion);

            //try
            //{
            //    //Abrimos la conexión:
            //    conexion.Open();

            //    //Ejecutamos el comando:
            //    int filasAfectadas = command.ExecuteNonQuery(); //Nos devuelve la cantidad de filas afectadas.
            //    if (filasAfectadas == 0)
            //    {
            //        Console.WriteLine("No se agregó el empleado");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Se agregó el empleado");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
            //}

            //******************ACTUALIZACIÓN******************
            //Empleado e = new Empleado(1, "Juan", "Luis", 1, 200, true, "2012-01-01");
            //string connectionString = "Server = .; Database = C16_01_EMPRESA_DB; Trusted_Connection = True";
            //SqlConnection conexion = new SqlConnection(connectionString);

            ////BUENA MANERA DE HACER CONSULTAS (más segura):
            //string consulta = "UPDATE Empleados SET nombre = @nombre WHERE id_empleado = @id";

            ////instanciar un comando:
            //SqlCommand command = new SqlCommand(consulta, conexion);

            ////Con "command" le paso parámetros, especificando que quiero que tenga cada uno.
            ////Es MUCHO MEJOR porque tiene una capa de seguridad:
            //command.Parameters.AddWithValue("@nombre", e.Nombre);
            //command.Parameters.AddWithValue("@id", e.Id);

            //conexion.Open();

            ////Ejecutamos el comando:
            //int filasAfectadas = command.ExecuteNonQuery(); //Nos devuelve la cantidad de filas afectadas.
            //if (filasAfectadas == 0)
            //{
            //    Console.WriteLine("No se cambio el empleado");
            //}
            //else
            //{
            //    Console.WriteLine("Se cambio el empleado");
            //}

            //conexion.Close();

            //******************ELIMINACIÓN******************
            Empleado e = new Empleado(1, "Juan", "Luis", 1, 200, true, "2012-01-01");

            string connectionString = "Server = .; Database = C16_01_EMPRESA_DB; Trusted_Connection = True";
            SqlConnection conexion = new SqlConnection(connectionString);

            string consulta = "DELETE Empleados WHERE id_empleado = @id";

            //instanciar un comando:
            SqlCommand command = new SqlCommand(consulta, conexion);
            //le paso parámetros a "command", especificando que quiero que tenga cada uno.
            command.Parameters.AddWithValue("@id", e.Id);

            try
            {
                //Abrimos la conexión:
                conexion.Open();

                //Ejecutamos el comando:
                int filasAfectadas = command.ExecuteNonQuery(); //Nos devuelve la cantidad de filas afectadas.
                if (filasAfectadas == 0)
                {
                    Console.WriteLine("No se eliminó el empleado");
                }
                else
                {
                    Console.WriteLine("Se eliminó el empleado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
            }
        }
    }
}
