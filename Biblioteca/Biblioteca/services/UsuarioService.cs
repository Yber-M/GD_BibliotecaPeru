using Biblioteca.database;
using Biblioteca.models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.services
{
    public class UsuarioService
    {
        SqlConnection connection;

        public UsuarioService()
        {
            try
            {
                connection = SQLDatabase.GetConnecion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Usuario Sign_In(string username,string contrasenia) 
        {
            Usuario usuario = null;
            
            SqlCommand comando = new SqlCommand("sp_usuario_mantenimiento", connection);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);
            comando.Parameters.AddWithValue("@opcion", 4);

            try
            {
                SqlDataReader results = comando.ExecuteReader();

                if (results.Read())
                {
                    usuario = new Usuario();

                    usuario.Id_Usuario = results.GetInt32(0);
                    usuario.Username= results.GetString(1);
                    usuario.Nombre = results.GetString(2);
                    usuario.Apellido_Paterno = results.GetString(3);
                    usuario.Apellido_Materno = results.GetString(4);
                    usuario.Telefono = results.GetString(5);
                    usuario.Contrasenia = results.GetString(6);
                    usuario.Rol = results.GetString(7);
                }

                results.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return usuario;
        }
    }
}
