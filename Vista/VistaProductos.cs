using Controladores;
using Microsoft.EntityFrameworkCore;
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
    public partial class VistaProductos : Form
    {
        private readonly ProductoControlador _productoControlador;
        private readonly CategoriaControlador _categoriaControlador;
        private readonly ProveedorControlador _proveedorControlador;


        public VistaProductos(ProductoControlador productoControlador, CategoriaControlador categoriaControlador, ProveedorControlador proveedorControlador)
        {
            _productoControlador = productoControlador;
            _categoriaControlador = categoriaControlador;
            _proveedorControlador = proveedorControlador;
            InitializeComponent();
        }

        private void VistaProductos_Load(object sender, EventArgs e)
        {

            var categorias = _categoriaControlador.Listar();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";

            //muestra el nombre de la categoria asociando el id como valor

            var proveedores = _proveedorControlador.Listar();
            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id";
        }


        public void CargarProductos()
        {
            var productos = _productoControlador.Listar();
            var categorias = _categoriaControlador.Listar();
            var proveedores = _proveedorControlador.Listar();

            dtgvProductos.DataSource = productos.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Descripcion,
                p.Precio,
                p.Stock,
                CategoriaNombre = categorias.FirstOrDefault(c => c.Id == p.CategoriaId)?.Nombre,
                ProveedorNombre = proveedores.FirstOrDefault(pr => pr.Id == p.ProveedorId)?.Nombre
            }).ToList();

            if (dtgvProductos.Columns.Contains("CategoriaId"))
            {
                dtgvProductos.Columns["CategoriaId"].Visible = false;
            }

            if (dtgvProductos.Columns.Contains("ProveedorId"))
            {
                dtgvProductos.Columns["ProveedorId"].Visible = false;
            }

            if (dtgvProductos.Columns.Contains("Categoria"))
            {
                dtgvProductos.Columns["Categoria"].Visible = false;
            }

            if (dtgvProductos.Columns.Contains("Proveedor"))
            {
                dtgvProductos.Columns["Proveedor"].Visible = false;
            }

            dtgvProductos.Columns["CategoriaNombre"].HeaderText = "Categoría";
            dtgvProductos.Columns["ProveedorNombre"].HeaderText = "Proveedor";
        }


        public void VaciarTxts()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;

            if (cmbCategoria.Items.Count > 0)
            {
                cmbCategoria.SelectedIndex = 0;
            }

            if (cmbProveedor.Items.Count > 0)
            {
                cmbProveedor.SelectedIndex = 0;
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarProductos();
            VaciarTxts();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (!float.TryParse(txtPrecio.Text, out float precio))
            {
                MessageBox.Show("Por favor, ingresa un número válido para el precio.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Por favor, ingresa un número válido para el stock.");
                return;
            }

            var proveedorSeleccionadoId = (int)cmbProveedor.SelectedValue;
            var proveedorSeleccionado = _proveedorControlador.BuscarPorID(proveedorSeleccionadoId);

            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Proveedor no válido.");
                return;
            }

            var nuevoProducto = new Producto
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = precio,
                Stock = stock,
                CategoriaId = (int)cmbCategoria.SelectedValue,
                ProveedorId = proveedorSeleccionadoId,
            };

            _productoControlador.Agregar(nuevoProducto);
            MessageBox.Show("Producto agregado correctamente");

            CargarProductos();
            VaciarTxts();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.SelectedRows.Count > 0)
            {

                int productoID = (int)dtgvProductos.SelectedRows[0].Cells["Id"].Value;
                var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    _productoControlador.Eliminar(productoID);
                    CargarProductos();

                    MessageBox.Show("Cliente eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgvProductos.Rows[e.RowIndex].Selected = true;
            }
            dtgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvProductos.MultiSelect = false;

            if (dtgvProductos.SelectedRows.Count > 0)
            {
                int productoID = (int)dtgvProductos.SelectedRows[0].Cells["Id"].Value;

                Producto ProductoSeleccionado = _productoControlador.BuscarPorID(productoID);

                if (ProductoSeleccionado != null)
                {
                    txtNombre.Text = ProductoSeleccionado.Nombre;
                    txtDescripcion.Text = ProductoSeleccionado.Descripcion;
                    txtPrecio.Text = ProductoSeleccionado.Precio.ToString();
                    txtStock.Text = ProductoSeleccionado.Stock.ToString();

                    cmbCategoria.SelectedValue = ProductoSeleccionado.CategoriaId;
                    cmbProveedor.SelectedValue = ProductoSeleccionado.ProveedorId;


                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Complete todos los campos.");
                    return;
                }

                if (!int.TryParse(txtPrecio.Text, out int precio))
                {
                    MessageBox.Show("Ingrese un número válido para el precio.");
                    return;
                }
                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("Ingrese un número válido para el stock.");
                    return;
                }

                int productoID = (int)dtgvProductos.SelectedRows[0].Cells["Id"].Value;

                Producto ProductoSeleccionado = _productoControlador.BuscarPorID(productoID);

                if (ProductoSeleccionado != null)
                {
                    ProductoSeleccionado.Nombre = txtNombre.Text;
                    ProductoSeleccionado.Descripcion = txtDescripcion.Text;
                    ProductoSeleccionado.Precio = precio;
                    ProductoSeleccionado.Stock = stock;

                    ProductoSeleccionado.CategoriaId = (int)cmbCategoria.SelectedValue; 
                    ProductoSeleccionado.ProveedorId = (int)cmbProveedor.SelectedValue; 



                    _productoControlador.Modificar(ProductoSeleccionado);

                    CargarProductos();
                    VaciarTxts();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
