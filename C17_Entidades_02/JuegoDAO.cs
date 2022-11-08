using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Entidades_02
{
    public static class JuegoDAO
    {
        #region Atributos
        static string cadenaConexion;
        static SqlCommand command;
        static SqlConnection conexion;
        #endregion

        #region Constructores
        static JuegoDAO()
        {
            JuegoDAO.cadenaConexion = "Server=.;Database=EJERCICIOS_UTN;Trusted_Connection=True;";
            JuegoDAO.conexion = new SqlConnection(cadenaConexion);
            JuegoDAO.command = new SqlCommand();
            command.Connection = conexion;
        }
        #endregion

        #region  Métodos
        public static bool Eliminar(int codigoJuego)
        {
            bool resultado = false;

            try
            {
                command.CommandText = "DELETE FROM Juegos WHERE CODIGO_JUEGO = @codigoJuego";
                command.Parameters.AddWithValue("@codigoJuego", codigoJuego);
                conexion.Open();
                
                if (command.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
                command.Parameters.Clear();
                command.CommandText = "";
            }

            return resultado;
        }

        public static bool Guardar(Juego juego)
        {
            bool resultado = false;

            try
            {
                command.CommandText = "INSERT INTO Juegos VALUES (@codigoUsuario, @nombre, @precio, @genero)";
                command.Parameters.AddWithValue("@codigoUsuario", juego.CodigoUsuario);
                command.Parameters.AddWithValue("@nombre", juego.Nombre);
                command.Parameters.AddWithValue("@precio", juego.Precio);
                command.Parameters.AddWithValue("@genero", juego.Genero);

                conexion.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
                command.Parameters.Clear();
                command.CommandText = "";
            }

            return resultado;
        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> listaBiblioteca = new List<Biblioteca>();
            SqlDataReader reader;

            try
            {
                command.CommandText = "SELECT j.CODIGO_JUEGO, j.GENERO, j.NOMBRE, u.USERNAME FROM JUEGOS j INNER JOIN USUARIOS u ON j.CODIGO_USUARIO = u.CODIGO_USUARIO";
                conexion.Open();

                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    string username = reader["USERNAME"].ToString();
                    string nombreJuego = reader["NOMBRE"].ToString();
                    string genero = reader["GENERO"].ToString();
                    int codigoJuego = (int)reader["CODIGO_JUEGO"];
                    Biblioteca biblioteca = new Biblioteca(username, genero, nombreJuego, codigoJuego);
                    listaBiblioteca.Add(biblioteca);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
                command.CommandText = "";
            }

            return listaBiblioteca;
        }

        public static Juego LeerPorID(int codigoJuego)
        {
            Juego juego = null;
            SqlDataReader reader;

            try
            {
                command.CommandText = "SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = @codigo_juego";
                command.Parameters.AddWithValue("@codigo_juego", codigoJuego);

                conexion.Open();

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int codigoUsuario = (int)reader["CODIGO_USUARIO"];
                    string nombre = reader["NOMBRE"].ToString();
                    double precio = (double)reader["PRECIO"];
                    string genero = reader["GENERO"].ToString();
                    juego = new Juego(nombre, precio, genero, codigoJuego, codigoUsuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
                command.Parameters.Clear();
                command.CommandText = "";
            }

            return juego;
        }

        public static bool Modificar(Juego juego)
        {
            bool resultado = false;

            try
            {
                command.CommandText = "UPDATE JUEGOS SET PRECIO = @precio, NOMBRE = @nombre, GENERO = @genero WHERE CODIGO_JUEGO = @codigo_juego";
                command.Parameters.AddWithValue("@precio", juego.Precio);
                command.Parameters.AddWithValue("@nombre", juego.Nombre);
                command.Parameters.AddWithValue("@genero", juego.Genero);
                command.Parameters.AddWithValue("@codigo_juego", juego.CodigoJuego);

                conexion.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
                command.Parameters.Clear();
                command.CommandText = "";
            }

            return resultado;
        }
        #endregion
    }
}
