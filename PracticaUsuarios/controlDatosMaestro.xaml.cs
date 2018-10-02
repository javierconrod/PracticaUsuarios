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
    /// Lógica de interacción para controlDatosMaestro.xaml
    /// </summary>
    public partial class controlDatosMaestro : UserControl
    {
        public controlDatosMaestro()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblNombre.Foreground = Brushes.Black;
        }

        private void txtTelefono_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTelefono.Foreground = Brushes.Black;
        }

        private void txtCedula_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblCedula.Foreground = Brushes.Black;
        }

        private void txtCarrera_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblCarrera.Foreground = Brushes.Black;
        }
    }
}
