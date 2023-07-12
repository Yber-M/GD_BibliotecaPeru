using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.models
{
    public class ReservaLibro
    {
        private int id_solicitud;
        private int id_usuario;
        private int id_libro;
        private string fecha_prestamo;
        private string fecha_devolucion;
        private string nombre_usuario;
        private string titulo_libro;

    
            
        public ReservaLibro(int id_solicitud, int id_usuario, int  id_libro, string fecha_prestamo, string fecha_devolucion, string nombre_usuario, string titulo_libro)
        {
            this.id_solicitud = id_solicitud;
            this.id_usuario = id_usuario;
            this.id_libro = id_libro;
            this.fecha_prestamo = fecha_prestamo;
            this.fecha_devolucion = fecha_devolucion;
            this.nombre_usuario = nombre_usuario;
            this.titulo_libro = titulo_libro;
        }

        public int Id_Solicitud
        {
            get { return id_solicitud;  }
            set { id_solicitud = value; }
        }

        public int Id_Usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public int Id_Libro
        {
            get { return id_libro; }
            set { id_libro = value; }
        }

        public string Fecha_Prestamo
        {
            get { return fecha_prestamo; }
            set { fecha_prestamo = value;  }
        }
        public string Fecha_Devolucion
        {
            get { return fecha_devolucion; }
            set { fecha_devolucion = value; }
        }

        public string Nombre_Usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        public string Titulo_Libro
        {
            get { return titulo_libro; }
            set { titulo_libro = value; }
        }
    }
}
