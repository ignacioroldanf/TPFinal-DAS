namespace Vista
{
    partial class Menu
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
            btnClientes = new Button();
            btnProductos = new Button();
            btnProveedores = new Button();
            btnVentas = new Button();
            btnReportes = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(122, 80);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(123, 63);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(251, 80);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(123, 63);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(380, 80);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(123, 63);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(635, 80);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(123, 63);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(789, 80);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(123, 63);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 663);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Controls.Add(btnProveedores);
            Controls.Add(btnProductos);
            Controls.Add(btnClientes);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProductos;
        private Button btnProveedores;
        private Button btnVentas;
        private Button btnReportes;
    }
}
