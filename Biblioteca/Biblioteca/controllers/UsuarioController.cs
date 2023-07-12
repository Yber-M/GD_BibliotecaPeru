using Biblioteca.models;
using Biblioteca.services;

namespace Biblioteca.controllers
{
    public class UsuarioController
    {
        private UsuarioService usuario_service;

        public UsuarioController() {
            usuario_service = new UsuarioService();
        }

        public Usuario Sign_In(string usuario, string contrasenia)
        {
            return usuario_service.Sign_In(usuario,contrasenia);
        }
    }
}
