using Clase_2309_Arq.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Clase_2309_Arq.Vista
{
    /// <summary>
    /// Lógica de interacción para MostrarTurno.xaml
    /// </summary>
    public partial class MostrarTurno : Window
    {
        public MostrarTurno(Turno turnoAMostrar)
        {
            InitializeComponent();

            lblCliente.Content = turnoAMostrar.NombreCliente;
            lblFecha.Content = turnoAMostrar.FechaTurno;
        }
    }
}
