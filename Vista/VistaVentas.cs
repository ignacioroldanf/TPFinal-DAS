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
    public partial class VistaVentas : Form
    {
        private readonly ClienteControlador _clienteControlador;
        private readonly FacturaControlador _facturaControlador;

        public VistaVentas(ClienteControlador clienteControlador, FacturaControlador facturaControlador)
        {
            _facturaControlador = facturaControlador;
            _clienteControlador = clienteControlador;
            InitializeComponent();
        }
        private void VistaVentas_Load(object sender, EventArgs e)
        {

            var clientes = _clienteControlador.Listar();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "Id";
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            var clienteSeleccionadoID = (int)cmbClientes.SelectedValue;
            var clienteSeleccionado = _clienteControlador.BuscarPorID(clienteSeleccionadoID);

            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.");
                return;
            }

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Cliente no válido.");
                return;
            }


            var nuevaFactura = new Factura
            {
                Fecha = dtFecha.Value,
                ClienteId = clienteSeleccionadoID
            };

            _facturaControlador.Agregar(nuevaFactura);

            MessageBox.Show("Factura creada correctamente");

            CargarFacturas();
        }


        public void CargarFacturas()
        {
            var facturas = _facturaControlador.Listar();
            var clientes = _clienteControlador.Listar();

            dtgvFacturas.DataSource = facturas.Select(f => new
            {
                f.Id,
                f.Fecha,
                ClienteNombre = clientes.FirstOrDefault(c => c.Id == f.ClienteId)?.Nombre,
                Total = f.Detalles.Sum(d => d.Cantidad * d.Producto.Precio)
            }).ToList();

            dtgvFacturas.Columns["ClienteNombre"].HeaderText = "Cliente";

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var facturaId = (int)dtgvFacturas.Rows[e.RowIndex].Cells["Id"].Value;

                var contexto = new TiendaContext();

                var productoControlador = new ProductoControlador(contexto);
                var detalleFacturaControlador = new DetalleFacturaControlador(contexto);
                var facturaControlador = new FacturaControlador(contexto);

                var vista = new VistaFacturas(facturaId, productoControlador, detalleFacturaControlador, facturaControlador);
                vista.ShowDialog();

                CargarFacturas();
            }
        }
    }
}
