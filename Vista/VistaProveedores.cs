using Controladores;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
    public partial class VistaProveedores : Form
    {
        private readonly ProveedorControlador _proveedorControlador;

        public VistaProveedores()
        {
            InitializeComponent();
            _proveedorControlador = new ProveedorControlador(new TiendaContext());

        }

        public void CargarProveedores()
        {
            var proveedores = _proveedorControlador.Listar();

            dtgvProveedores.DataSource = proveedores;
        }

        public void VaciarTxts()
        {
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarProveedores();
            VaciarTxts();
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

            var nuevoProveedor = new Proveedor
            {
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = telefono
            };

            _proveedorControlador.Agregar(nuevoProveedor);
            MessageBox.Show("Proveedor agregado correctamente");
            CargarProveedores();
            VaciarTxts();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvProveedores.SelectedRows.Count > 0)
            {

                int proveedorID = (int)dtgvProveedores.SelectedRows[0].Cells["Id"].Value;
                var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este Proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    _proveedorControlador.Eliminar(proveedorID);
                    CargarProveedores();
                    MessageBox.Show("Proveedor eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.");
            }

            VaciarTxts();
        }

        private void dtgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgvProveedores.Rows[e.RowIndex].Selected = true;
            }
            dtgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvProveedores.MultiSelect = false;

            if (dtgvProveedores.SelectedRows.Count > 0)
            {
                int proveedorID = (int)dtgvProveedores.SelectedRows[0].Cells["Id"].Value;

                Proveedor ProveedorSeleccionado = _proveedorControlador.BuscarPorID(proveedorID);

                if (ProveedorSeleccionado != null)
                {
                    txtNombre.Text = ProveedorSeleccionado.Nombre;
                    txtDireccion.Text = ProveedorSeleccionado.Direccion;
                    txtTelefono.Text = ProveedorSeleccionado.Telefono.ToString();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgvProveedores.SelectedRows.Count > 0)
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

                int proveedorID = (int)dtgvProveedores.SelectedRows[0].Cells["Id"].Value;

                Proveedor ProveedorSeleccionado = _proveedorControlador.BuscarPorID(proveedorID);

                if (ProveedorSeleccionado != null)
                {
                    ProveedorSeleccionado.Nombre = txtNombre.Text;
                    ProveedorSeleccionado.Direccion = txtDireccion.Text;
                    ProveedorSeleccionado.Telefono = telefono;

                    _proveedorControlador.Modificar(ProveedorSeleccionado);

                    CargarProveedores();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado.");
                }
            }



            VaciarTxts();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaProveedores_Load(object sender, EventArgs e)
        {
            dtgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
