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
    public partial class VistaClientes : Form
    {
        private readonly ClienteControlador _clienteControlador;
        public VistaClientes()
        {
            InitializeComponent();
            _clienteControlador = new ClienteControlador(new TiendaContext());

        }

        public void CargarClientes()
        {
            var clientes = _clienteControlador.GetList();

            dtgvClientes.DataSource = clientes;

        }
        public void VaciarTxts()
        {
            txtDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (!int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("Por favor, ingresa un número válido para el teléfono.");
                return;
            }

            var nuevoCliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = telefono
            };

            _clienteControlador.Agregar(nuevoCliente); // Llama al controlador para agregar el cliente
            MessageBox.Show("Cliente agregado correctamente");
            CargarClientes();
            VaciarTxts();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvClientes.SelectedRows.Count > 0)
            {

                int clienteId = (int)dtgvClientes.SelectedRows[0].Cells["Id"].Value;
                var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    _clienteControlador.Eliminar(clienteId);
                    CargarClientes();
                    MessageBox.Show("Cliente eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgvClientes.Rows[e.RowIndex].Selected = true;
            }
            dtgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvClientes.MultiSelect = false;

            if (dtgvClientes.SelectedRows.Count > 0)
            {
                int clienteId = (int)dtgvClientes.SelectedRows[0].Cells["Id"].Value;

                Cliente ClienteSeleccionado = _clienteControlador.BuscarPorID(clienteId);

                if (ClienteSeleccionado != null)
                {
                    txtNombre.Text = ClienteSeleccionado.Nombre;
                    txtDireccion.Text = ClienteSeleccionado.Direccion;
                    txtTelefono.Text = ClienteSeleccionado.Telefono.ToString();
                }
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgvClientes.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Complete todos los campos.");
                    return;
                }

                if (!int.TryParse(txtTelefono.Text, out int telefono))
                {
                    MessageBox.Show("Ingrese un número válido para el teléfono.");
                    return;
                }

                int clienteId = (int)dtgvClientes.SelectedRows[0].Cells["Id"].Value;

                Cliente ClienteSeleccionado = _clienteControlador.BuscarPorID(clienteId);

                if (ClienteSeleccionado != null)
                {
                    ClienteSeleccionado.Nombre = txtNombre.Text;
                    ClienteSeleccionado.Direccion = txtDireccion.Text;
                    ClienteSeleccionado.Telefono = telefono;

                    _clienteControlador.Modificar(ClienteSeleccionado);

                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
        }
    }
}
