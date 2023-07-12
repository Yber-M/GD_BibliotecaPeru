using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Biblioteca.database
{
    public class SQLDatabase
    {
        public static SqlConnection GetConnecion()
        {
            const string url = "Data Source=localhost,1433 ; Initial Catalog=Biblio_Final; User ID=sa; Password=sql@pass-s3cur3";
            try
            {
                SqlConnection connection = new SqlConnection(url);
                connection.Open();
                Console.WriteLine("connection ok");
                return connection;
            }
            catch (Exception ex)
            {
                if (ex is SqlException sqlex)
                    throw new Exception($"Ocurrio un error al conectar a SQL: {sqlex.Message}");
                else
                    throw new Exception($"Ocurrio un error al obtener la conexion: {ex.Message}");
            }
        }
    }
}
