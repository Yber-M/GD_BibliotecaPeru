using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.models
{
    public class Usuario
    {
        private int id_usuario;
        private string username;
        private string nombre;
        private string apellido_paterno;
        private string apellido_materno;
        private string telefono;
        private string contrasenia;
        private string rol;

        public int Id_Usuario{
            get { return id_usuario; }
            set { id_usuario = value; }
        }
      
        public string Username
        {
            get { return username;  }
            set { username = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido_Paterno
        {
            get { return apellido_paterno; }
            set { apellido_paterno = value; }
        }

        public string Apellido_Materno
        {
            get { return apellido_materno; }
            set { apellido_materno = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value;  }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

    }
}
