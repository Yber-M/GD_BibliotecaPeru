using Biblioteca.controllers;
using Biblioteca.database;
using Biblioteca.models;
using Biblioteca.services;
using Biblioteca.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Login : Form
    {
        private UsuarioController usuario_ctrl;

        public Login()
        {
            InitializeComponent();
            usuario_ctrl = new UsuarioController();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string contrasenia = txtContraseña.Text;

            Usuario usuario = usuario_ctrl.Sign_In(username, contrasenia);

            if (usuario != null)
            {
                Form form_view = null;

                // Verificamos el tipo de rol
                switch (usuario.Rol)
                {
                    case "Alumno":
                        form_view = new MenuUsuarioView();
                        break;
                    case "Docente":
                        form_view = new MenuUsuarioView();
                        break;
                    case "Auxiliar de Biblioteca":
                        form_view = new MenuEmpleadoView();
                        break;
                    case "Jefe de Logistica":
                        form_view = new MenuEmpleadoView();
                        break;
                    case "Jefe de biblioteca":
                        form_view = new MenuEmpleadoView();
                        break;
                    case "Bibliotecario":
                        form_view = new MenuEmpleadoView();
                        break;
                }

                // Abrimos el formulario
                form_view.Show();

                // Ocultando el formulario actual del login
                Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
