namespace Vista
{
    partial class VistaProveedores
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
            txtTelefono = new TextBox();
            label1 = new Label();
            txtDireccion = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnListar = new Button();
            dtgvProveedores = new DataGridView();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1052, 37);
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
            label2.Location = new Point(27, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 22;
            label2.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(108, 84);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(146, 27);
            txtTelefono.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 54);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 20;
            label1.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(108, 51);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(146, 27);
            txtDireccion.TabIndex = 19;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(108, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 27);
            txtNombre.TabIndex = 17;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(654, 37);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(120, 54);
            btnListar.TabIndex = 16;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dtgvProveedores
            // 
            dtgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProveedores.Location = new Point(27, 150);
            dtgvProveedores.Name = "dtgvProveedores";
            dtgvProveedores.RowHeadersWidth = 51;
            dtgvProveedores.Size = new Size(1145, 388);
            dtgvProveedores.TabIndex = 15;
            dtgvProveedores.CellClick += dtgvProveedores_CellClick;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(528, 37);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 54);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(402, 37);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 54);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(276, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 54);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // VistaProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 570);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnListar);
            Controls.Add(dtgvProveedores);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Name = "VistaProveedores";
            Text = "VistaProveedores";
            Load += VistaProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label label2;
        private TextBox txtTelefono;
        private Label label1;
        private TextBox txtDireccion;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnListar;
        private DataGridView dtgvProveedores;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
    }
}