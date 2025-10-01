using Clase_2309_Arq.Controlador;
using Clase_2309_Arq.Modelo;
using Clase_2309_Arq.Vista;
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

namespace Clase_2309_Arq
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TurnosControlador controladorTurnos = new TurnosControlador();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, RoutedEventArgs e)
        {
            bool reservaCorrecta = controladorTurnos.ReservarTurno(txtNombreTurno.Text, dtpFecha.Value.Value);
            

            if (reservaCorrecta)
            {
                dtgTurnos.ItemsSource = null;
                dtgTurnos.ItemsSource = controladorTurnos.ListarTurnos();
            }
            else
            {
                MessageBox.Show("No se pudo reservar", "error");
            }
        }

        private void btnBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            Turno turnoBuscado = controladorTurnos.BuscarPorNombre(txtNombreBusqueda.Text);

            if (turnoBuscado == null)
            {
                MessageBox.Show("No hay turnos para ese cliente");
            }
            else
            {
                MostrarTurno ventanaturno = new MostrarTurno(turnoBuscado);
                ventanaturno.Show();
            }
        }

        private void btnMarcarTurnoCompletado_Click(object sender, RoutedEventArgs e)
        {
            Turno turnoDataGrid = dtgTurnos.SelectedItem as Turno;

            if (turnoDataGrid == null)
            {
                MessageBox.Show("Primero debe seleccionar un turno");
            }
            else
            {
                MessageBoxResult acepta = MessageBox.Show("Desea marcar este turno como asistido?", "Cuidado", MessageBoxButton.OKCancel);

                controladorTurnos.MarcarTurnoComoCompletado(turnoDataGrid);
                dtgTurnos.ItemsSource = null;
                dtgTurnos.ItemsSource = controladorTurnos.ListarTurnos();
            }
        }
    }
}