namespace Biblioteca.views
{
    partial class MenuUsuarioView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuarioView));
            panel1 = new Panel();
            label1 = new Label();
            btnMinimi = new Label();
            btnCerrar = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            btnReservar = new Button();
            btnSolicitarLibro = new Button();
            ptrBxUser = new PictureBox();
            pnlVisualizador = new Panel();
            pictureBox1 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptrBxUser).BeginInit();
            pnlVisualizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(104, 247, 157);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMinimi);
            panel1.Controls.Add(btnCerrar);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // btnMinimi
            // 
            resources.ApplyResources(btnMinimi, "btnMinimi");
            btnMinimi.Cursor = Cursors.Hand;
            btnMinimi.ForeColor = Color.FromArgb(38, 38, 38);
            btnMinimi.Name = "btnMinimi";
            btnMinimi.Click += btnMinimi_Click;
            // 
            // btnCerrar
            // 
            resources.ApplyResources(btnCerrar, "btnCerrar");
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.ForeColor = Color.FromArgb(38, 38, 38);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 38, 38);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnReservar);
            panel2.Controls.Add(btnSolicitarLibro);
            panel2.Controls.Add(ptrBxUser);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(104, 247, 157);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(38, 38, 38);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(104, 247, 157);
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(104, 247, 157);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(104, 247, 157);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.FromArgb(38, 38, 38);
            btnReservar.Cursor = Cursors.Hand;
            btnReservar.FlatAppearance.BorderSize = 0;
            btnReservar.FlatAppearance.MouseOverBackColor = Color.FromArgb(104, 247, 157);
            resources.ApplyResources(btnReservar, "btnReservar");
            btnReservar.ForeColor = Color.White;
            btnReservar.Name = "btnReservar";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnSolicitarLibro
            // 
            btnSolicitarLibro.BackColor = Color.FromArgb(38, 38, 38);
            btnSolicitarLibro.Cursor = Cursors.Hand;
            btnSolicitarLibro.FlatAppearance.BorderSize = 0;
            btnSolicitarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(104, 247, 157);
            resources.ApplyResources(btnSolicitarLibro, "btnSolicitarLibro");
            btnSolicitarLibro.ForeColor = Color.White;
            btnSolicitarLibro.Name = "btnSolicitarLibro";
            btnSolicitarLibro.UseVisualStyleBackColor = false;
            btnSolicitarLibro.Click += btnSolicitarLibro_Click;
            // 
            // ptrBxUser
            // 
            resources.ApplyResources(ptrBxUser, "ptrBxUser");
            ptrBxUser.Name = "ptrBxUser";
            ptrBxUser.TabStop = false;
            // 
            // pnlVisualizador
            // 
            pnlVisualizador.Controls.Add(pictureBox1);
            resources.ApplyResources(pnlVisualizador, "pnlVisualizador");
            pnlVisualizador.Name = "pnlVisualizador";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // MenuUsuarioView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlVisualizador);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuUsuarioView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptrBxUser).EndInit();
            pnlVisualizador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label btnCerrar;
        private Label btnMinimi;
        private PictureBox ptrBxUser;
        private Button btnReservar;
        private Button btnSolicitarLibro;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Button button1;
        private Label label1;
        private Panel pnlVisualizador;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
    }
}