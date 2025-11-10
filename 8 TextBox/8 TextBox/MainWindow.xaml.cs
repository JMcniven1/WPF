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

namespace _8_TextBox
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

        private void btnMensaje_Click(object sender, RoutedEventArgs e)
        {
            string mensaje = "Hola "+txtNombres.Text;
            txbEscribe.Text = mensaje;
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtMultilineas.Text = "escribe";
        }

        private void btnSeleccion_Click(object sender, RoutedEventArgs e)
        {
            string seleccionado = txtMultilineas.SelectedText;
            txbEscribe.Text = seleccionado;
        }
    }
}
