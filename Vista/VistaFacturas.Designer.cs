namespace Vista
{
    partial class VistaFacturas
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
            cmbFactura = new ComboBox();
            cmbProductos = new ComboBox();
            lblFactura = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnSalir = new Button();
            label2 = new Label();
            btnListar = new Button();
            dtgvDetallesFactura = new DataGridView();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDetallesFactura).BeginInit();
            SuspendLayout();
            // 
            // cmbFactura
            // 
            cmbFactura.FormattingEnabled = true;
            cmbFactura.Location = new Point(89, 19);
            cmbFactura.Name = "cmbFactura";
            cmbFactura.Size = new Size(146, 28);
            cmbFactura.TabIndex = 49;
            cmbFactura.SelectedIndexChanged += cmbFactura_SelectedIndexChanged;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(316, 19);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(146, 28);
            cmbProductos.TabIndex = 48;
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Location = new Point(21, 22);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(56, 20);
            lblFactura.TabIndex = 47;
            lblFactura.Text = "Factura";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(468, 21);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 44;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(543, 18);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(146, 27);
            txtCantidad.TabIndex = 43;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1046, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 54);
            btnSalir.TabIndex = 42;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 22);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 41;
            label2.Text = "Producto";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(920, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(120, 54);
            btnListar.TabIndex = 36;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dtgvDetallesFactura
            // 
            dtgvDetallesFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDetallesFactura.Location = new Point(21, 74);
            dtgvDetallesFactura.Name = "dtgvDetallesFactura";
            dtgvDetallesFactura.RowHeadersWidth = 51;
            dtgvDetallesFactura.Size = new Size(1145, 449);
            dtgvDetallesFactura.TabIndex = 35;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(794, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 54);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // VistaFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 594);
            Controls.Add(cmbFactura);
            Controls.Add(cmbProductos);
            Controls.Add(lblFactura);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(btnListar);
            Controls.Add(dtgvDetallesFactura);
            Controls.Add(btnAgregar);
            Name = "VistaFacturas";
            Text = "VistaFacturas";
            Load += VistaFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDetallesFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFactura;
        private ComboBox cmbProductos;
        private Label lblFactura;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnSalir;
        private Label label2;
        private Button btnListar;
        private DataGridView dtgvDetallesFactura;
        private Button btnAgregar;
    }
}