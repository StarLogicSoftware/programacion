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

namespace Clase_2309_ventanas
{
    /// <summary>
    /// Lógica de interacción para SegundaVentana.xaml
    /// </summary>
    public partial class SegundaVentana : Window
    {
        public SegundaVentana(string dato)
        {
            InitializeComponent();

            lblDato.Content = dato;
        }
    }
}
