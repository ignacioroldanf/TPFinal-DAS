namespace Vista
{
    partial class VistaClientes
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
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            dtgvClientes = new DataGridView();
            btnListar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label1 = new Label();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(261, 54);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 54);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(387, 54);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 54);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(513, 54);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 54);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dtgvClientes
            // 
            dtgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClientes.Location = new Point(12, 167);
            dtgvClientes.Name = "dtgvClientes";
            dtgvClientes.RowHeadersWidth = 51;
            dtgvClientes.Size = new Size(1145, 547);
            dtgvClientes.TabIndex = 3;
            dtgvClientes.CellClick += dtgvClientes_CellClick;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(639, 54);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(120, 54);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 8;
            label1.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(93, 68);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(146, 27);
            txtDireccion.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 10;
            label2.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(93, 101);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(146, 27);
            txtTelefono.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1037, 54);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 54);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // VistaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 795);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnListar);
            Controls.Add(dtgvClientes);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Name = "VistaClientes";
            Text = "VistaClientes";
            Load += VistaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private DataGridView dtgvClientes;
        private Button btnListar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label label1;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtTelefono;
        private Button btnSalir;
    }
}