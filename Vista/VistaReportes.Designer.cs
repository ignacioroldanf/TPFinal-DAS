namespace Vista
{
    partial class VistaReportes
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
            cmbCliente = new ComboBox();
            lblCliente = new Label();
            label3 = new Label();
            btnSalir = new Button();
            label2 = new Label();
            dtgvFacturasFecha = new DataGridView();
            dtDesde = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dtHasta = new DateTimePicker();
            dtgvFacturasClientes = new DataGridView();
            dtgvTopProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvFacturasFecha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvFacturasClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvTopProductos).BeginInit();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(671, 83);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(146, 28);
            cmbCliente.TabIndex = 49;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(610, 86);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 47;
            lblCliente.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 38);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 46;
            label3.Text = "Facturas emitidas";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1043, 560);
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
            label2.Location = new Point(31, 577);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 41;
            label2.Text = "Productos mas vendidos";
            // 
            // dtgvFacturasFecha
            // 
            dtgvFacturasFecha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFacturasFecha.Location = new Point(31, 149);
            dtgvFacturasFecha.Name = "dtgvFacturasFecha";
            dtgvFacturasFecha.RowHeadersWidth = 51;
            dtgvFacturasFecha.Size = new Size(553, 377);
            dtgvFacturasFecha.TabIndex = 35;
            // 
            // dtDesde
            // 
            dtDesde.Location = new Point(88, 69);
            dtDesde.Name = "dtDesde";
            dtDesde.Size = new Size(274, 27);
            dtDesde.TabIndex = 52;
            dtDesde.ValueChanged += dtDesde_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 74);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 54;
            label4.Text = "Desde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 107);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 56;
            label5.Text = "Hasta";
            // 
            // dtHasta
            // 
            dtHasta.Location = new Point(88, 102);
            dtHasta.Name = "dtHasta";
            dtHasta.Size = new Size(274, 27);
            dtHasta.TabIndex = 55;
            dtHasta.ValueChanged += dtHasta_ValueChanged;
            // 
            // dtgvFacturasClientes
            // 
            dtgvFacturasClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFacturasClientes.Location = new Point(610, 149);
            dtgvFacturasClientes.Name = "dtgvFacturasClientes";
            dtgvFacturasClientes.RowHeadersWidth = 51;
            dtgvFacturasClientes.Size = new Size(553, 377);
            dtgvFacturasClientes.TabIndex = 57;
            // 
            // dtgvTopProductos
            // 
            dtgvTopProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTopProductos.Location = new Point(31, 640);
            dtgvTopProductos.Name = "dtgvTopProductos";
            dtgvTopProductos.RowHeadersWidth = 51;
            dtgvTopProductos.Size = new Size(1132, 377);
            dtgvTopProductos.TabIndex = 58;
            // 
            // VistaReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1709, 1084);
            Controls.Add(dtgvTopProductos);
            Controls.Add(dtgvFacturasClientes);
            Controls.Add(label5);
            Controls.Add(dtHasta);
            Controls.Add(label4);
            Controls.Add(dtDesde);
            Controls.Add(cmbCliente);
            Controls.Add(lblCliente);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(dtgvFacturasFecha);
            Name = "VistaReportes";
            Text = "VistaReportes";
            Load += VistaReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvFacturasFecha).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvFacturasClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvTopProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCliente;
        private Label lblCliente;
        private Label label3;
        private Button btnSalir;
        private Label label2;
        private DataGridView dtgvFacturasFecha;
        private DateTimePicker dtDesde;
        private Label label4;
        private Label label5;
        private DateTimePicker dtHasta;
        private DataGridView dtgvFacturasClientes;
        private DataGridView dtgvTopProductos;
    }
}