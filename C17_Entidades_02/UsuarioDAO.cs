using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Entidades_02
{
    public static class UsuarioDAO
    {
        #region Atributos
        static string cadenaConexion;
        static SqlCommand command;
        static SqlConnection conexion;
        #endregion

        static UsuarioDAO()
        {
            UsuarioDAO.cadenaConexion = "Server=.;Database=EJERCICIOS_UTN;Trusted_Connection=True;";
            UsuarioDAO.conexion = new SqlConnection(cadenaConexion);
            UsuarioDAO.command = new SqlCommand();
            command.Connection = conexion;
        }

        #region Métodos
        public static List<Usuario> Leer()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            SqlDataReader reader;

            try
            {
                command.CommandText = "SELECT USERNAME, CODIGO_USUARIO FROM USUARIOS";
                conexion.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader["USERNAME"].ToString();
                    int codigoUsuario  = (int)reader["CODIGO_USUARIO"];
                    Usuario usuario = new Usuario(username, codigoUsuario);
                    listaUsuarios.Add(usuario);
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

            return listaUsuarios;
        }
        #endregion
    }
}
