using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17_Entidades_01
{
    public class PersonaDAO
    {
        public bool Guardar(Persona nuevaPersona)
        {
            bool resultado = true;

            using (SqlConnection conexion = new SqlConnection("Server = .; Database = C17_DB_01; Trusted_Connection = True"))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Personas VALUES (@nombre, @apellido)", conexion);
                command.Parameters.AddWithValue("@nombre", nuevaPersona.Nombre);
                command.Parameters.AddWithValue("@apellido", nuevaPersona.Apellido);

                conexion.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public List<Persona> Leer()
        {
            List<Persona> listaPersonas = new List<Persona>();

            using (SqlConnection conexion = new SqlConnection("Server = .; Database = C17_DB_01; Trusted_Connection = True"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Personas", conexion);
                conexion.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int ID = (int)reader["ID"];
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellido"].ToString();
                    listaPersonas.Add(new Persona(ID, nombre, apellido));
                }
            }

            return listaPersonas;
        }

        public Persona LeerPorID(int id)
        {
            Persona persona = null;

            using (SqlConnection conexion = new SqlConnection("Server = .; Database = C17_DB_01; Trusted_Connection = True"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Personas WHERE ID = @id", conexion);
                command.Parameters.AddWithValue("@id", id);

                conexion.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) //Solo leerá, como mucho, un solo resultado.
                {
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellido"].ToString();
                    persona = new Persona(id, nombre, apellido);
                }
            }

            return persona;
        }


        public bool ModificarPorID(Persona personaModificacion)
        {
            bool resultado = false;

            if (personaModificacion is null)
            {
                return resultado;
            }

            using (SqlConnection conexion = new SqlConnection("Server = .; Database = C17_DB_01; Trusted_Connection = True"))
            {
                SqlCommand command = new SqlCommand("UPDATE Personas SET Nombre = @nombre, Apellido = @apellido WHERE ID = @id", conexion);
                command.Parameters.AddWithValue("@id", personaModificacion.ID);
                command.Parameters.AddWithValue("@nombre", personaModificacion.Nombre);
                command.Parameters.AddWithValue("@apellido", personaModificacion.Apellido);

                conexion.Open();

                if (command.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public bool Borrar(int id)
        {
            bool resultado = false;

            using (SqlConnection conexion = new SqlConnection("Server = .; Database = C17_DB_01; Trusted_Connection = True")) 
            {
                SqlCommand command = new SqlCommand("DELETE FROM Personas WHERE ID = @id", conexion);
                command.Parameters.AddWithValue("@id", id);

                conexion.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }
    }
}
