using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Clase0909.Clases;

namespace Clase0909
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonPresionado(object sender, RoutedEventArgs e)
        {
            // es el contenido del messagebox
            //MessageBox.Show("Botón presionado");

            // contenido + titulo
            //MessageBox.Show("Botón presionado", "titulo de la ventanita");

            // contenido + titulo + botones
            var respuesta = MessageBox.Show("Botón presionado", "titulo de la ventanita", MessageBoxButton.YesNoCancel);

            if(respuesta == MessageBoxResult.Yes)
            {
                MessageBox.Show("Elegiste Yes");
            }
            else if (respuesta == MessageBoxResult.No)
            {
                MessageBox.Show("Elegiste No");
            }
            else if (respuesta == MessageBoxResult.Cancel)
            {
                MessageBox.Show("Elegiste Cancel");
            }
        }


        private void btnMensaje_Click(object sender, RoutedEventArgs e)
        {
            string mensajeLeido = txtNombre.Text;

            MessageBox.Show($"Nombre leido: {mensajeLeido}");
        }

        private void btnCambiarMensaje_Click(object sender, RoutedEventArgs e)
        {
            txtNombre.Text = "Mensaje cambiado desde el codigo";
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Carga de datos de usuario pero usando objetos (POO) <<manual>>
            /* Usuario usr = new Usuario();
            usr.Nombre = txtNombreUsuario.Text;
            usr.Edad = int.Parse(txtEdadUsuario.Text);

            MessageBox.Show($"Usuario registrado: {usr.Nombre}, {usr.Edad} años");
            */

            // Carga de datos de usuario pero usando objetos (POO) <<propiedades privadas>>
            Usuario usr = new Usuario();
            usr.CargarDatos(txtNombreUsuario.Text, int.Parse(txtEdadUsuario.Text));

            MessageBox.Show($"Usuario registrado: {usr.MostrarDatos}");
        }
    }
}