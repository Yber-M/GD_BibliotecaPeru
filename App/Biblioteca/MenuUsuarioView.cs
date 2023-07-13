using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Biblioteca.views
{
    public partial class MenuUsuarioView : Form
    {
        public MenuUsuarioView()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitarLibro_Click(object sender, EventArgs e)
        {
            AbriForm(new FrmSolicitarLibro());
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            AbriForm(new FrmReservarSala());
        }

        private void AbriForm(object FormOpen)
        {
            if (this.pnlVisualizador.Controls.Count > 0)
                this.pnlVisualizador.Controls.RemoveAt(0);
            Form fh = FormOpen as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.pnlVisualizador.Controls.Add(fh);
            this.pnlVisualizador.Tag = fh;

            fh.Show();
        }

    }
}
