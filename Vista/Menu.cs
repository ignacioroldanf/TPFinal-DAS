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

        private void btnClientes_Click(object sender, EventArgs e)
        {
            VistaClientes vista = new VistaClientes();
            vista.Show();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var contexto = new TiendaContext();
            var productoControlador = new ProductoControlador(contexto);
            var categoriaControlador = new CategoriaControlador(contexto);
            var proveedorControlador = new ProveedorControlador(contexto);

            var vista = new VistaProductos(productoControlador, categoriaControlador, proveedorControlador);
            vista.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            VistaProveedores vista = new VistaProveedores();
            vista.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var contexto = new TiendaContext();
            var clienteControlador = new ClienteControlador(contexto);
            var facturaControlador = new FacturaControlador(contexto);
            VistaVentas vista = new VistaVentas(clienteControlador, facturaControlador);
            vista.Show();
        }
    }
}
