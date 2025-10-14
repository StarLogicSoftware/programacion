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

namespace DemoBrazoRobotico
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GestionPuertoSerie gestion = new GestionPuertoSerie();

        public MainWindow()
        {
            InitializeComponent();
        }

        // ====== Listar Puertos ======
        private void ListarPuertos_Click(object sender, RoutedEventArgs e)
        {
            comboPuertos.ItemsSource = gestion.ObtenerPuertosDisponibles();
            if (comboPuertos.Items.Count > 0)
                comboPuertos.SelectedIndex = 0;

            AgregarMensaje("Puertos listados.");
        }

        // ====== Conectar ======
        private void Conectar_Click(object sender, RoutedEventArgs e)
        {
            if (comboPuertos.SelectedItem == null)
            {
                AgregarMensaje("Seleccione un puerto antes de conectar.");
                return;
            }

            string puerto = comboPuertos.SelectedItem.ToString();

            if (gestion.Conectar(puerto))
                AgregarMensaje("Conectado al puerto " + puerto);
            else
                AgregarMensaje("Error al conectar al puerto " + puerto);
        }

        // ====== Desconectar ======
        private void Desconectar_Click(object sender, RoutedEventArgs e)
        {
            gestion.Desconectar();
            AgregarMensaje("Desconectado del puerto serie.");
        }

        // ====== Función auxiliar para enviar comandos ======
        private void Enviar(string comando)
        {
            if (!gestion.EstaConectado())
            {
                AgregarMensaje("No hay conexión activa.");
                return;
            }

            string respuesta = gestion.EnviarComando(comando);
            AgregarMensaje(">> " + comando);
            AgregarMensaje("<< " + respuesta);
        }

        private void AgregarMensaje(string texto)
        {
            listMensajes.Items.Insert(0, texto);
        }

        // ====== MOTOR 1 ======
        private void Motor1Adelante_Presionado(object sender, MouseButtonEventArgs e)
            => Enviar("M1-1-" + (int)sliderVelocidad.Value);

        private void Motor1Atras_Presionado(object sender, MouseButtonEventArgs e)
            => Enviar("M1-2-" + (int)sliderVelocidad.Value);

        private void Motor1_Soltado(object sender, MouseButtonEventArgs e)
            => Enviar("M1-0-0");

        // ====== MOTOR 2 ======
        private void Motor2Adelante_Presionado(object sender, MouseButtonEventArgs e)
            => Enviar("M2-1-" + (int)sliderVelocidad.Value);

        private void Motor2Atras_Presionado(object sender, MouseButtonEventArgs e)
            => Enviar("M2-2-" + (int)sliderVelocidad.Value);

        private void Motor2_Soltado(object sender, MouseButtonEventArgs e)
            => Enviar("M2-0-0");

        // ====== MOTOR 3 ======
        private void Motor3Adelante_Presionado(object sender, MouseButtonEventArgs e)
            => Enviar("M3-1-" + (int)sliderVelocidad.Value);

        private void Motor3Atras_Presionado(object sender, MouseButtonEventArgs e)
            => Enviar("M3-2-" + (int)sliderVelocidad.Value);

        private void Motor3_Soltado(object sender, MouseButtonEventArgs e)
            => Enviar("M3-0-0");
    }
}