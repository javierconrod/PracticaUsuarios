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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelDatos.Children.Clear();
            switch(cbTipoUsuario.SelectedIndex)
            {
                case 0:
                    panelDatos.Children.Add(new controlDatosAlumno());
                    break;
                case 1:
                    panelDatos.Children.Add(new controlDatosMaestro());

                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            switch (cbTipoUsuario.SelectedIndex)
            {
                case 0:
                    var controlDatosAlumno = (controlDatosAlumno)(panelDatos.Children[0]);
                    if (controlDatosAlumno.txtNombre.Text == "")
                    {
                        controlDatosAlumno.lblNombre.Foreground = Brushes.Red;
                    }
                    if (controlDatosAlumno.txtDireccion.Text == "")
                    {
                        controlDatosAlumno.lblDireccion.Foreground = Brushes.Red;
                    }
                    if (controlDatosAlumno.txtPreparatoria.Text == "")
                    {
                        controlDatosAlumno.lblPrepa.Foreground = Brushes.Red;
                    }
                    break;
                case 1:
                    var controlDatosMaestro = (controlDatosMaestro)(panelDatos.Children[0]);
                    if (controlDatosMaestro.txtNombre.Text == "")
                    {
                        controlDatosMaestro.lblNombre.Foreground = Brushes.Red;
                    }
                    if (controlDatosMaestro.txtTelefono.Text == "")
                    {
                        controlDatosMaestro.lblTelefono.Foreground = Brushes.Red;
                    }
                    if (controlDatosMaestro.txtCedula.Text == "")
                    {
                        controlDatosMaestro.lblCedula.Foreground = Brushes.Red;
                    }
                    if (controlDatosMaestro.txtCarrera.Text == "")
                    {
                        controlDatosMaestro.lblCarrera.Foreground = Brushes.Red;
                    }
                    break;
                default:
                    break;
            }

            


            
        }
    }
}
