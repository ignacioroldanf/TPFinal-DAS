using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class VistaReportes : Form
    {
        private readonly ClienteControlador _clienteControlador;
        private readonly FacturaControlador _facturaControlador;
        private readonly DetalleFacturaControlador _detallefacturaControlador;
        private readonly ProductoControlador _productoControlador;
        private readonly CategoriaControlador _categoriaControlador;

        private DateTime inicio;
        private DateTime final;
        public VistaReportes(ClienteControlador clienteControlador, FacturaControlador facturaControlador, DetalleFacturaControlador detalleFacturaControlador, ProductoControlador productoControlador, CategoriaControlador categoriaControlador)
        {
            _facturaControlador = facturaControlador;
            _clienteControlador = clienteControlador;
            _detallefacturaControlador = detalleFacturaControlador;
            _productoControlador = productoControlador;
            _categoriaControlador = categoriaControlador;
            InitializeComponent();
        }

        public void ListarPorFecha()
        {
            var facturas = _facturaControlador.Listar();
            var detfacturas = _detallefacturaControlador.Listar();
            var clientes = _clienteControlador.Listar();

            inicio = dtDesde.Value;
            final = dtHasta.Value;


            dtgvFacturasFecha.DataSource = facturas.Select(f => new
            {
                f.Id,
                f.Fecha,
                ClienteNombre = clientes.FirstOrDefault(c => c.Id == f.ClienteId)?.Nombre,
                Total = f.Detalles.Sum(d => d.Cantidad * d.Producto.Precio)
            })
                .Where(f => f.Fecha > inicio && f.Fecha < final)
                .ToList();

            dtgvFacturasFecha.Columns["Id"].HeaderText = "Codigo de Factura";
            dtgvFacturasFecha.Columns["ClienteNombre"].HeaderText = "Cliente";
        }


        public void ListarPorCliente()
        {
            var facturas = _facturaControlador.Listar();
            var detfacturas = _detallefacturaControlador.Listar();
            var clientes = _clienteControlador.Listar();

            dtgvFacturasClientes.DataSource = facturas.Select(f => new
            {
                f.Id,
                f.Fecha,
                ClienteNombre = clientes.FirstOrDefault(c => c.Id == f.ClienteId)?.Nombre,
                Total = f.Detalles.Sum(d => d.Cantidad * d.Producto.Precio)
            })
                .Where(f => f.ClienteNombre == cmbCliente.Text)
                .ToList();

            dtgvFacturasClientes.Columns["Id"].HeaderText = "Codigo de Factura";
            dtgvFacturasClientes.Columns["ClienteNombre"].HeaderText = "Cliente";
        }

        public void ListarTopProductos()
        {
            var facturas = _facturaControlador.Listar();
            var detfacturas = _detallefacturaControlador.Listar();
            var productos = _productoControlador.Listar();
            var categoria = _categoriaControlador.Listar();

            dtgvTopProductos.DataSource = productos.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Descripcion,
                Categoria = categoria.FirstOrDefault(c => c.Id == p.CategoriaId)?.Nombre,
                CantidadVendida = detfacturas.Count(df => df.ProductoId == p.Id)
            })
                .OrderByDescending(p => p.CantidadVendida)
                .ToList();

            dtgvTopProductos.Columns["Id"].HeaderText = "Codigo de Producto";
            dtgvTopProductos.Columns["CantidadVendida"].HeaderText = "Cantidad Vendida";
        }






        private void VistaReportes_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            dtgvTopProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            var clientes = _clienteControlador.Listar();
            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";

            ListarPorFecha();
            ListarPorCliente();
            ListarTopProductos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            ListarPorFecha();
        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            ListarPorFecha();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarPorCliente();
        }
    }
}
