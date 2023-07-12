namespace Biblioteca.views
{
    partial class MenuEmpleadoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inicio = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.tabSolicitudes = new System.Windows.Forms.TabPage();
            this.tabLibros = new System.Windows.Forms.TabPage();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.id_solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.Inicio.SuspendLayout();
            this.tabSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // Inicio
            // 
            this.Inicio.Controls.Add(this.tabInicio);
            this.Inicio.Controls.Add(this.tabSolicitudes);
            this.Inicio.Controls.Add(this.tabLibros);
            this.Inicio.Location = new System.Drawing.Point(-2, -2);
            this.Inicio.Name = "Inicio";
            this.Inicio.SelectedIndex = 0;
            this.Inicio.Size = new System.Drawing.Size(803, 455);
            this.Inicio.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(795, 429);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // tabSolicitudes
            // 
            this.tabSolicitudes.Controls.Add(this.dgvSolicitudes);
            this.tabSolicitudes.Location = new System.Drawing.Point(4, 22);
            this.tabSolicitudes.Name = "tabSolicitudes";
            this.tabSolicitudes.Padding = new System.Windows.Forms.Padding(3);
            this.tabSolicitudes.Size = new System.Drawing.Size(795, 429);
            this.tabSolicitudes.TabIndex = 1;
            this.tabSolicitudes.Text = "Solicitudes";
            this.tabSolicitudes.UseVisualStyleBackColor = true;
            // 
            // tabLibros
            // 
            this.tabLibros.Location = new System.Drawing.Point(4, 22);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.Size = new System.Drawing.Size(795, 429);
            this.tabLibros.TabIndex = 2;
            this.tabLibros.Text = "Libros";
            this.tabLibros.UseVisualStyleBackColor = true;
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_solicitud,
            this.nombre_usuario,
            this.nombre_libro,
            this.fecha_prestamo,
            this.fecha_devolucion});
            this.dgvSolicitudes.Location = new System.Drawing.Point(6, 77);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.Size = new System.Drawing.Size(786, 346);
            this.dgvSolicitudes.TabIndex = 0;
            // 
            // id_solicitud
            // 
            this.id_solicitud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_solicitud.Frozen = true;
            this.id_solicitud.HeaderText = "ID Solicitud";
            this.id_solicitud.Name = "id_solicitud";
            this.id_solicitud.ReadOnly = true;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_usuario.HeaderText = "Nombre Usuario";
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.ReadOnly = true;
            // 
            // nombre_libro
            // 
            this.nombre_libro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_libro.HeaderText = "Libro";
            this.nombre_libro.Name = "nombre_libro";
            this.nombre_libro.ReadOnly = true;
            // 
            // fecha_prestamo
            // 
            this.fecha_prestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_prestamo.HeaderText = "Fecha Prestamo";
            this.fecha_prestamo.Name = "fecha_prestamo";
            this.fecha_prestamo.ReadOnly = true;
            // 
            // fecha_devolucion
            // 
            this.fecha_devolucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_devolucion.HeaderText = "Fecha Devolucion";
            this.fecha_devolucion.Name = "fecha_devolucion";
            this.fecha_devolucion.ReadOnly = true;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(8, 459);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(131, 43);
            this.btnEliminarReserva.TabIndex = 1;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // MenuEmpleadoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.Inicio);
            this.Name = "MenuEmpleadoView";
            this.Text = "MenuEmpleadoView";
            this.Inicio.ResumeLayout(false);
            this.tabSolicitudes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Inicio;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabSolicitudes;
        private System.Windows.Forms.TabPage tabLibros;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_devolucion;
        private System.Windows.Forms.Button btnEliminarReserva;
    }
}