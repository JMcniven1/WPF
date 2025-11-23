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

namespace _26_Menu_Contextual
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

        private void mmuPaCm_Click(object sender, RoutedEventArgs e)
        {
            double valor = Convert.ToDouble(txtMedida.Text);
            valor *= 2.54;
            txtMedida.Text = valor.ToString();
        }

        private void mmuCmaP_Click(object sender, RoutedEventArgs e)
        {
            double valor = Convert.ToDouble(txtMedida.Text);
            valor /= 2.54;
            txtMedida.Text = valor.ToString();
        }
    }
}