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

namespace _27_Toolbar
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

        private void BtnSaludo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola a todos mis a amigos");
        }

        private void BtnCarita_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtMensaje.Text);
        }

        //<ToolbarTray DockPanel.Dock="Rigth" Orientation="Vertical">
    }
}