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
            var clientes = _clienteControlador.Listar();

            dtgvClientes.DataSource = clientes.Select(c => new
            {
                c.Id,
                c.Nombre,
                c.Direccion,
                c.Telefono,
                Tipo = c is ClienteIndividual ? "Individual" : "Empresarial",
                Identificacion = c is ClienteIndividual ci ? ci.DNI : (c is ClienteEmpresarial ce ? ce.CUIT : "")
            }).ToList();

            dtgvClientes.Columns["Id"].HeaderText = "ID";
            dtgvClientes.Columns["Nombre"].HeaderText = "Nombre";
            dtgvClientes.Columns["Direccion"].HeaderText = "Dirección";
            dtgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
            dtgvClientes.Columns["Tipo"].HeaderText = "Tipo de Cliente";
            dtgvClientes.Columns["Identificacion"].HeaderText = "DNI/CUIT";
        }


        public void VaciarTxts()
        {
            txtDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtCUIT.Text = string.Empty;
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

            Cliente nuevoCliente;

            if (chEmpresarial.Checked)
            {
                nuevoCliente = new ClienteEmpresarial
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = telefono,
                    CUIT = txtCUIT.Text
                };
            }
            else
            {
                nuevoCliente = new ClienteIndividual
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = telefono,
                    DNI = txtDNI.Text
                };
            }


            _clienteControlador.Agregar(nuevoCliente); 
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
                    if (ClienteSeleccionado is ClienteIndividual ci)
                    {
                        txtDNI.Text = ci.DNI;
                    }
                    else if (ClienteSeleccionado is ClienteEmpresarial ce)
                    {
                        txtCUIT.Text = ce.CUIT;
                    }
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

                    if (ClienteSeleccionado is ClienteIndividual ci)
                    {
                        ci.DNI = txtDNI.Text;
                    }
                    else if (ClienteSeleccionado is ClienteEmpresarial ce)
                    {
                        ce.CUIT = txtCUIT.Text;
                    }

                    _clienteControlador.Modificar(ClienteSeleccionado);

                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
            VaciarTxts();
        }

        private void VistaClientes_Load(object sender, EventArgs e)
        {
            txtDNI.Visible = true;
            txtCUIT.Visible = false;
        }

        private void chEmpresarial_CheckedChanged(object sender, EventArgs e)
        {
            if (chEmpresarial.Checked)
            {
                txtDNI.Visible = false;
                txtCUIT.Visible = true;
            }
            else
            {
                txtDNI.Visible = true;
                txtCUIT.Visible = false;
            }
        }
    }
}
