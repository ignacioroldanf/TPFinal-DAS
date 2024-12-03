using Controladores;
using Modelo;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaClientes vista = new VistaClientes();
            vista.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contexto = new TiendaContext();
            var productoControlador = new ProductoControlador(contexto);
            var categoriaControlador = new CategoriaControlador(contexto);
            var proveedorControlador = new ProveedorControlador(contexto);

            var vista = new VistaProductos(productoControlador, categoriaControlador, proveedorControlador);
            vista.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaProveedores vista = new VistaProveedores();
            vista.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contexto = new TiendaContext();
            var clienteControlador = new ClienteControlador(contexto);
            var facturaControlador = new FacturaControlador(contexto);
            VistaVentas vista = new VistaVentas(clienteControlador, facturaControlador);
            vista.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contexto = new TiendaContext();
            var clienteControlador = new ClienteControlador(contexto);
            var facturaControlador = new FacturaControlador(contexto);
            var detallefacturaControlador = new DetalleFacturaControlador(contexto);
            var productoControlador = new ProductoControlador(contexto);
            var categoriaControlador = new CategoriaControlador(contexto);
            VistaReportes vista = new VistaReportes(clienteControlador, facturaControlador, detallefacturaControlador, productoControlador, categoriaControlador);
            vista.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
