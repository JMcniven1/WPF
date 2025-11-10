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

namespace _3_Eventos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Aqui suscribimos por medio de codigo
            Segundo.Click += new RoutedEventHandler(Segundo_Click);
        }

        private void Segundo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("segundo boton rules");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has pulsado el boton");
        }
    }
}