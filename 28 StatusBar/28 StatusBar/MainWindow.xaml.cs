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

namespace _28_StatusBar
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

        private void txtDatos_KeyDown(object sender, KeyEventArgs e)
        {
            //El +1 es porque usamos KeyDown
            int cantidad = txtDatos.Text.Length + 1;

            String[] palabras = txtDatos.Text.Split(new char[] { ' ' });
            int cantPalabras = palabras.Length;

            txtInformation.Text = "Se tienen " + cantidad.ToString() + "caracteres";
            txtPalabras.Text = "con" + cantPalabras.ToString() + " palabras";
        } 
    }
}