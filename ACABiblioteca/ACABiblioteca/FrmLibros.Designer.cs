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
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            pnlDatos = new Panel();
            txtExistencias = new TextBox();
            cmbEditorial = new ComboBox();
            lblExistencias = new Label();
            txtAño = new TextBox();
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
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.DarkSlateBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(800, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(220, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(327, 48);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestion de Libros";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(800, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(521, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(257, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(212, 31);
            txtBuscar.TabIndex = 3;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(153, 21);
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
            pnlDatos.Controls.Add(txtAño);
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
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(800, 447);
            pnlDatos.TabIndex = 2;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(257, 376);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(212, 31);
            txtExistencias.TabIndex = 12;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(257, 203);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(208, 33);
            cmbEditorial.TabIndex = 13;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(153, 376);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(105, 25);
            lblExistencias.TabIndex = 9;
            lblExistencias.Text = "Existencias:";
            // 
            // txtAño
            // 
            txtAño.Location = new Point(257, 320);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(212, 31);
            txtAño.TabIndex = 11;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(261, 149);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(208, 33);
            cmbAutor.TabIndex = 8;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(257, 258);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(212, 31);
            txtCategoria.TabIndex = 10;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(155, 320);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(50, 25);
            lblAño.TabIndex = 8;
            lblAño.Text = "Año:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(257, 88);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(212, 31);
            txtTitulo.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(257, 35);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(212, 31);
            txtISBN.TabIndex = 6;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(153, 149);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(65, 25);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(148, 264);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(96, 25);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria:";
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLib.Location = new Point(153, 94);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(65, 25);
            lblTituloLib.TabIndex = 4;
            lblTituloLib.Text = "Titulo:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(153, 35);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(56, 25);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(148, 203);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(85, 25);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial:";
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            Text = "FrmLibros";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private TextBox txtBuscar;
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
        private TextBox txtAño;
        private ComboBox cmbAutor;
        private TextBox txtCategoria;
    }
}