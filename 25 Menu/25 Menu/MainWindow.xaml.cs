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

namespace _25_Menu
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

        private void mnuSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mnuSuma_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtValorA.Text);
            double b = Convert.ToDouble(txtValorB.Text);

            double r = a + b;
            txtR.Text = r.ToString();
        }

        private void mnuResta_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtValorA.Text);
            double b = Convert.ToDouble(txtValorB.Text);

            double r = a - b;
            txtR.Text = r.ToString();
        }

        private void mnuMulti_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtValorA.Text);
            double b = Convert.ToDouble(txtValorB.Text);

            double r = a * b;
            txtR.Text = r.ToString();
        }

        private void mnuDiv_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtValorA.Text);
            double b = Convert.ToDouble(txtValorB.Text);

            double r = a / b;
            txtR.Text = r.ToString();
        }
    }
}