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
            VistaClientes vistaClientes = new VistaClientes();
            vistaClientes.Show();

        }
    }
}
