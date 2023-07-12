using Biblioteca.models;
using Biblioteca.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.controllers
{
    public class ReservaLibroController
    {
        private SolicitudesService reserva_service;
        public ReservaLibroController()
        {
            reserva_service = new SolicitudesService();
        }

        public List<ReservaLibro> obtener_solicitudes_libro()
        {
            return reserva_service.obtener_solicitudes_libro();
        }

        public void eliminar_solicitud_libro(int id_solicitud) {
            reserva_service.eliminar_solicitud_libro(id_solicitud);
        }

    }
}
