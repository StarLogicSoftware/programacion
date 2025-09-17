using Clase1609.Clases;
using System.Text;
using System.Windows;

namespace Clase1609
{
    public partial class MainWindow : Window
    {
        // Aca se guardan los clientes en el sistema (como una mini base de datos)
        List<Cliente> clientes = new List<Cliente>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            /*
            Crear un cliente (un objeto cliente)
            Cargar los datos de la ventana en el objeto
            Agregar ese objeto a la lista de clientes
            Actualizar el datagrid con los clientes de la lista
            */
            Cliente c = new Cliente();

            c.Nombre = txtNombre.Text;
            c.Direccion = txtDireccion.Text;
            c.Telefono = txtTelefono.Text;

            clientes.Add(c);

            dtgClientes.ItemsSource = null; // forzamos al datagrid a volver a leer la lista
            dtgClientes.ItemsSource = clientes;
        }

        private void btnInformacion_Click(object sender, RoutedEventArgs e)
        {
            //Cliente clienteSeleccionado = (Cliente)dtgClientes.SelectedItem;
            Cliente clienteSeleccionado = dtgClientes.SelectedItem as Cliente;

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar primero un cliente");
            }
            else
            {
                MessageBox.Show($"Cliente seleccionado: {clienteSeleccionado.Nombre}", "cliente");
            }
        }
    }
}