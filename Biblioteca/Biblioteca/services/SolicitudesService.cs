using Biblioteca.database;
using System.Data.SqlClient;
using System;
using System.Data;
using Biblioteca.models;
using System.Collections.Generic;

namespace Biblioteca.services
{
    public class SolicitudesService
    {
        SqlConnection connection;

        public SolicitudesService()
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

        public List<ReservaLibro> obtener_solicitudes_libro()
        {
            List<ReservaLibro> reservas = new List<ReservaLibro>();

            SqlCommand comando = new SqlCommand("sp_reserva_libro_mantenimiento", connection);

            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@opcion", 4);

            SqlDataReader results =  comando.ExecuteReader();

            while (results.Read())
            {
                int id_solicitud = results.GetInt32(0);
                int id_usuario = results.GetInt32(1);
                int id_libro = results.GetInt32(2);
                string fecha_prestamo = $"{results.GetDateTime(3)}";
                string fecha_devolucion = $"{results.GetDateTime(4)}";
                string nombre_usuario = results.GetString(5);
                string titulo_libro = results.GetString(6);

                ReservaLibro reserva = new ReservaLibro(id_solicitud, id_usuario, id_libro, fecha_prestamo, fecha_devolucion, nombre_usuario, titulo_libro);
                reservas.Add(reserva);
            }
            results.Close();
            return reservas;
        }
        public void eliminar_solicitud_libro(int id_solicitud)
        {
            SqlCommand comando = new SqlCommand("sp_reserva_libro_mantenimiento", connection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_solicitud", id_solicitud);
            comando.Parameters.AddWithValue("@opcion", 3);
            comando.ExecuteNonQuery();
        }
    }
}
