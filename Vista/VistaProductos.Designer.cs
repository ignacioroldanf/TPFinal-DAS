namespace Vista
{
    partial class VistaProductos
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
            btnSalir = new Button();
            label2 = new Label();
            lblDescrip = new Label();
            txtDescripcion = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnListar = new Button();
            dtgvProductos = new DataGridView();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            label3 = new Label();
            txtStock = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            cmbProveedor = new ComboBox();
            cmbCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1050, 32);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 54);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 22;
            label2.Text = "Proveedor";
            // 
            // lblDescrip
            // 
            lblDescrip.AutoSize = true;
            lblDescrip.Location = new Point(25, 49);
            lblDescrip.Name = "lblDescrip";
            lblDescrip.Size = new Size(87, 20);
            lblDescrip.TabIndex = 20;
            lblDescrip.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(118, 46);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(146, 27);
            txtDescripcion.TabIndex = 19;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 16);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 13);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 27);
            txtNombre.TabIndex = 17;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(924, 32);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(120, 54);
            btnListar.TabIndex = 16;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dtgvProductos
            // 
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Location = new Point(25, 145);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.RowHeadersWidth = 51;
            dtgvProductos.Size = new Size(1145, 449);
            dtgvProductos.TabIndex = 15;
            dtgvProductos.CellClick += dtgvProductos_CellClick;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(798, 32);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 54);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(672, 32);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 54);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(546, 32);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 54);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 82);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 29;
            label1.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 49);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 27;
            label3.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(376, 46);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(146, 27);
            txtStock.TabIndex = 26;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(283, 16);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 25;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(376, 13);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(146, 27);
            txtPrecio.TabIndex = 24;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(118, 79);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(146, 28);
            cmbProveedor.TabIndex = 30;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(376, 79);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(146, 28);
            cmbCategoria.TabIndex = 31;
            // 
            // VistaProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 699);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbProveedor);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtStock);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(lblDescrip);
            Controls.Add(txtDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnListar);
            Controls.Add(dtgvProductos);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Name = "VistaProductos";
            Text = "VistaProductos";
            Load += VistaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label label2;
        private Label lblDescrip;
        private TextBox txtDescripcion;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnListar;
        private DataGridView dtgvProductos;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label label1;
        private Label label3;
        private TextBox txtStock;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private ComboBox cmbProveedor;
        private ComboBox cmbCategoria;
    }
}