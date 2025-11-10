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

namespace _7_Label
{
    /// TEORIA
    /// Interaction logic for MainWindow.xaml
    /// Label es similar a Texblock, pero tienen una diferencia importante y es que en lugar de tener
    /// una propiedad Text, tiene una propiedad Content lo que le permite tener otros controles en su interior
    /// aunque la matoria solo se ubica texto ahi
    /// es mas rapido y consume menos recursos si solo se desea presentar texto
    /// se pueden usar para generar accesos rapidos ejemplo/
    /// Target = {Binding ElementName= txtNombre}
    /// Stack panel es un tip normal de pânel que nos permite organizar los elmentos de forma vertical 
    /// u horizontal es una sola linea
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMensaje_Click(object sender, RoutedEventArgs e)
        {
            lblMensaje.Content = "Saludo a todos";
        }
    }
}
