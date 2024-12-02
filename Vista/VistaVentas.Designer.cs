namespace Vista
{
    partial class VistaVentas
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
            cmbClientes = new ComboBox();
            btnSalir = new Button();
            label2 = new Label();
            lblFecha = new Label();
            btnListar = new Button();
            dtgvFacturas = new DataGridView();
            btnAgregarVenta = new Button();
            dtFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgvFacturas).BeginInit();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(445, 26);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(146, 28);
            cmbClientes.TabIndex = 48;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1055, 12);
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
            label2.Location = new Point(384, 29);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 41;
            label2.Text = "Cliente";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(30, 29);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 38;
            lblFecha.Text = "Fecha";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(929, 12);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(120, 54);
            btnListar.TabIndex = 36;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dtgvFacturas
            // 
            dtgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFacturas.Location = new Point(30, 88);
            dtgvFacturas.Name = "dtgvFacturas";
            dtgvFacturas.RowHeadersWidth = 51;
            dtgvFacturas.Size = new Size(1145, 449);
            dtgvFacturas.TabIndex = 35;
            dtgvFacturas.CellDoubleClick += dtgvFacturas_CellDoubleClick;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(628, 12);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(120, 54);
            btnAgregarVenta.TabIndex = 32;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(83, 24);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(278, 27);
            dtFecha.TabIndex = 50;
            // 
            // VistaVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 649);
            Controls.Add(dtFecha);
            Controls.Add(cmbClientes);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(lblFecha);
            Controls.Add(btnListar);
            Controls.Add(dtgvFacturas);
            Controls.Add(btnAgregarVenta);
            Name = "VistaVentas";
            Text = "VistaVentas";
            Load += VistaVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbClientes;
        private Button btnSalir;
        private Label label2;
        private Label lblFecha;
        private Button btnListar;
        private DataGridView dtgvFacturas;
        private Button btnAgregarVenta;
        private DateTimePicker dtFecha;
    }
}