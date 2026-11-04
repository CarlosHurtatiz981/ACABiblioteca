namespace ACABiblioteca
{
    partial class FrmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscarISBN = new TextBox();
            lblBuscar = new Label();
            pnlDatos = new Panel();
            txtExistencias = new TextBox();
            cmbEditorial = new ComboBox();
            lblExistencias = new Label();
            txtAnio = new TextBox();
            cmbAutor = new ComboBox();
            txtCategoria = new TextBox();
            lblAño = new Label();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblAutor = new Label();
            lblCategoria = new Label();
            lblTituloLib = new Label();
            lblISBN = new Label();
            lblEditorial = new Label();
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.DarkSlateBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1344, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(472, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(327, 48);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestion de Libros";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscarISBN);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1344, 73);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(717, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarISBN
            // 
            txtBuscarISBN.Location = new Point(449, 18);
            txtBuscarISBN.Name = "txtBuscarISBN";
            txtBuscarISBN.Size = new Size(212, 31);
            txtBuscarISBN.TabIndex = 3;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(349, 21);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(52, 25);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "ISBN";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(txtAnio);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(lblAño);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblTituloLib);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 133);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1344, 429);
            pnlDatos.TabIndex = 2;
            pnlDatos.Paint += pnlDatos_Paint;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(518, 370);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(212, 31);
            txtExistencias.TabIndex = 12;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(518, 197);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(208, 33);
            cmbEditorial.TabIndex = 13;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(414, 370);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(105, 25);
            lblExistencias.TabIndex = 9;
            lblExistencias.Text = "Existencias:";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(518, 314);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(212, 31);
            txtAnio.TabIndex = 11;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(522, 143);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(208, 33);
            cmbAutor.TabIndex = 8;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(518, 252);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(212, 31);
            txtCategoria.TabIndex = 10;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(416, 314);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(50, 25);
            lblAño.TabIndex = 8;
            lblAño.Text = "Año:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(518, 82);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(212, 31);
            txtTitulo.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(518, 29);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(212, 31);
            txtISBN.TabIndex = 6;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(414, 143);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(65, 25);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(409, 258);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(96, 25);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria:";
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLib.Location = new Point(414, 88);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(65, 25);
            lblTituloLib.TabIndex = 4;
            lblTituloLib.Text = "Titulo:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(414, 29);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(56, 25);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(409, 197);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(85, 25);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial:";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(292, 580);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(858, 60);
            pnlBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(710, 14);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(543, 14);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(369, 14);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(117, 40);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(190, 14);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnNuevo.IconSize = 25;
            btnNuevo.Location = new Point(30, 14);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(117, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(157, 662);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 62;
            dgvLibros.Size = new Size(1100, 226);
            dgvLibros.TabIndex = 4;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 712);
            Controls.Add(dgvLibros);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private TextBox txtBuscarISBN;
        private Label lblBuscar;
        private Button btnBuscar;
        private Panel pnlDatos;
        private Label lblAutor;
        private Label lblTituloLib;
        private Label lblISBN;
        private Label lblEditorial;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private Label lblCategoria;
        private Label lblAño;
        private Label lblExistencias;
        private TextBox txtExistencias;
        private ComboBox cmbEditorial;
        private TextBox txtAnio;
        private ComboBox cmbAutor;
        private TextBox txtCategoria;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private DataGridView dgvLibros;
    }
}