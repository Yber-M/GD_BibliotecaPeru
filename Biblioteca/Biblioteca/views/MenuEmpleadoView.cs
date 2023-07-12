using Biblioteca.controllers;
using System;
using System.Windows.Forms;

namespace Biblioteca.views
{
    public partial class MenuEmpleadoView : Form
    {
        private ReservaLibroController reserva_ctrl;

        public MenuEmpleadoView()
        {
            InitializeComponent();

            reserva_ctrl = new ReservaLibroController();

            cargar_solicitudes_libros();
        }


        void cargar_solicitudes_libros()
        {
            dgvSolicitudes.Rows.Clear();

            reserva_ctrl.obtener_solicitudes().ForEach((solicitud)=>{
                object[] reserva = {solicitud.Id_Solicitud, solicitud.Nombre_Usuario,solicitud.Titulo_Libro,solicitud.Fecha_Prestamo,solicitud.Fecha_Devolucion };
                dgvSolicitudes.Rows.Add(reserva);
            });
        }

        private void btnEliminarReserva_Click(object sender, System.EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {

                DataGridViewRow fila_seleccionada = dgvSolicitudes.SelectedRows[0];
                int id_solicitud = int.Parse(fila_seleccionada.Cells[0].Value.ToString());

                reserva_ctrl.eliminar_solicitud(id_solicitud);
                MessageBox.Show("Solicitud eliminada correctamente");
                cargar_solicitudes_libros();
            }
            else
            {
                MessageBox.Show("Selecciona la fila que quiere eliminar");
            }
        }
    }
}
