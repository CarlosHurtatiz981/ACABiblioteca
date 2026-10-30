namespace ACABiblioteca
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPrestamos = new FontAwesome.Sharp.IconButton();
            btnEditoriales = new FontAwesome.Sharp.IconButton();
            btnAutores = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnLibros = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.ActiveCaption;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnEditoriales);
            pnlMenu.Controls.Add(btnAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(344, 594);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;
            btnSalir.Location = new Point(0, 395);
            btnSalir.Margin = new Padding(0, 10, 0, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(344, 45);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.AutoSize = true;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 30;
            btnReportes.Location = new Point(0, 350);
            btnReportes.Margin = new Padding(0, 10, 0, 10);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(344, 45);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.AutoSize = true;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnPrestamos.IconColor = Color.Black;
            btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrestamos.IconSize = 30;
            btnPrestamos.Location = new Point(0, 305);
            btnPrestamos.Margin = new Padding(0, 10, 0, 10);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(344, 45);
            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.AutoSize = true;
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.FlatAppearance.BorderSize = 0;
            btnEditoriales.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditoriales.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btnEditoriales.IconColor = Color.Black;
            btnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditoriales.IconSize = 30;
            btnEditoriales.Location = new Point(0, 260);
            btnEditoriales.Margin = new Padding(0, 10, 0, 10);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(344, 45);
            btnEditoriales.TabIndex = 5;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.TextAlign = ContentAlignment.MiddleLeft;
            btnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditoriales.UseVisualStyleBackColor = true;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // btnAutores
            // 
            btnAutores.AutoSize = true;
            btnAutores.Dock = DockStyle.Top;
            btnAutores.FlatAppearance.BorderSize = 0;
            btnAutores.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            btnAutores.IconColor = Color.Black;
            btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutores.IconSize = 30;
            btnAutores.Location = new Point(0, 215);
            btnAutores.Margin = new Padding(0, 10, 0, 10);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(344, 45);
            btnAutores.TabIndex = 4;
            btnAutores.Text = "Autores";
            btnAutores.TextAlign = ContentAlignment.MiddleLeft;
            btnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAutores.UseVisualStyleBackColor = true;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = true;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;
            btnUsuarios.Location = new Point(0, 170);
            btnUsuarios.Margin = new Padding(0, 10, 0, 10);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(344, 45);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLibros
            // 
            btnLibros.AutoSize = true;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnLibros.IconColor = Color.Black;
            btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibros.IconSize = 30;
            btnLibros.Location = new Point(0, 125);
            btnLibros.Margin = new Padding(0, 10, 0, 10);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(344, 45);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.TextAlign = ContentAlignment.MiddleLeft;
            btnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnInicio
            // 
            btnInicio.AutoSize = true;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.Black;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 30;
            btnInicio.Location = new Point(0, 80);
            btnInicio.Margin = new Padding(0, 10, 0, 10);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(344, 45);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.DarkSlateBlue;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lblSubtitulo);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(344, 80);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.Logo_biblioteca_2;
            picLogo.Location = new Point(12, 10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(129, 60);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.WhiteSmoke;
            lblSubtitulo.Location = new Point(167, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(158, 22);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema de Gestion";
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Corbel", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Location = new Point(147, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(191, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOTECA";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.LightSteelBlue;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(344, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1014, 80);
            pnlSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(134, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = SystemColors.ScrollBar;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(344, 549);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(1014, 45);
            pnlEstado.TabIndex = 2;
            // 
            // pnlContenido
            // 
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(344, 80);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1014, 469);
            pnlContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 594);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion Biblioteca";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlContenido;
        private Panel pnlLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private PictureBox picLogo;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnEditoriales;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}
