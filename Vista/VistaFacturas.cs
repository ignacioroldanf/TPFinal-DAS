using Controladores;
using Modelo;
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
    public partial class VistaFacturas : Form
    {
        private readonly int _facturaId;
        private readonly ProductoControlador _productoControlador;
        private readonly DetalleFacturaControlador _detalleFacturaControlador;
        private readonly FacturaControlador _facturaControlador;
        private int facturaId;

        public VistaFacturas(int facturaId, ProductoControlador productoControlador, DetalleFacturaControlador detalleFacturaControlador, FacturaControlador facturaControlador)
        {
            _facturaId = facturaId; // Asignar correctamente el ID de la factura
            _productoControlador = productoControlador;
            _detalleFacturaControlador = detalleFacturaControlador;
            _facturaControlador = facturaControlador;

            InitializeComponent(); // Inicializar los componentes de la vista
        }



        private void VistaFacturas_Load(object sender, EventArgs e)
        {
            var facturaActual = _facturaControlador.BuscarPorID(_facturaId);
            if (facturaActual == null)
            {
                MessageBox.Show("Factura no encontrada.");
                return;
            }

            // Filtrar las facturas del mismo cliente
            var facturasDelCliente = _facturaControlador.Listar()
                .Where(f => f.ClienteId == facturaActual.ClienteId)
                .ToList();

            cmbFactura.DataSource = facturasDelCliente;
            cmbFactura.DisplayMember = "Id";
            cmbFactura.ValueMember = "Id";
            cmbFactura.SelectedValue = _facturaId;

            // Configurar productos
            var productos = _productoControlador.Listar();
            cmbProductos.DataSource = productos;
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Id";

            CargarFacturas();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            var productoId = (int)cmbProductos.SelectedValue;

            var nuevoDetalle = new DetalleFactura
            {
                FacturaId = _facturaId,
                ProductoId = productoId,
                Cantidad = cantidad
            };

            _detalleFacturaControlador.Agregar(nuevoDetalle);
            CargarFacturas();

        }

        public void CargarFacturas()
        {
            var productos = _productoControlador.Listar();
            var detalleFacturas = _detalleFacturaControlador.Listar().Where(df => df.FacturaId == _facturaId).ToList(); // Filtrar por _facturaId
            var facturas = _facturaControlador.Listar();

            dtgvDetallesFactura.DataSource = detalleFacturas.Select(df => new
            {
                FacturaNumero = facturas.FirstOrDefault(f => f.Id == df.FacturaId)?.Id,
                df.Id,
                ClienteNombre = facturas.FirstOrDefault(f => f.Id == df.FacturaId)?.Cliente?.Nombre,
                ProductoNombre = productos.FirstOrDefault(p => p.Id == df.ProductoId)?.Nombre,
                PrecioUnitario = productos.FirstOrDefault(p => p.Id == df.ProductoId)?.Precio, // Precio unitario del producto
                df.Cantidad,
                PrecioTotal = productos.FirstOrDefault(p => p.Id == df.ProductoId)?.Precio * df.Cantidad,

            }).ToList();

            dtgvDetallesFactura.Columns["FacturaNumero"].HeaderText = "Numero de Factura";
            dtgvDetallesFactura.Columns["Id"].HeaderText = "Numero de Detalle";
            dtgvDetallesFactura.Columns["ClienteNombre"].HeaderText = "Cliente";
            dtgvDetallesFactura.Columns["ProductoNombre"].HeaderText = "Producto";
            dtgvDetallesFactura.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
            dtgvDetallesFactura.Columns["PrecioTotal"].HeaderText = "Precio Total";





        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
