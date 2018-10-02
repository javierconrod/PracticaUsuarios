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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaUsuarios
{
    /// <summary>
    /// Lógica de interacción para controlDatosAlumno.xaml
    /// </summary>
    public partial class controlDatosAlumno : UserControl
    {
        public controlDatosAlumno()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblNombre.Foreground = Brushes.Black;
        }

        private void txtDireccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblDireccion.Foreground = Brushes.Black;
        }

        private void txtPreparatoria_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblPrepa.Foreground = Brushes.Black;
        }
    }
}
