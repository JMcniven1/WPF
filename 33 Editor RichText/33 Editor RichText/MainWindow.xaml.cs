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

namespace _33_Editor_RichText
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Rellenamos el comboBox de la tipografia
            cmbTipografia.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            //Rellenamos el comboBox de los tamanos
            cmbTamano.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

        }

        private void rbtTexto_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void cmbTipografia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbTipografia.SelectedItem != null)
                rtbTexto.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbTipografia.SelectedItem);
        }
        private void cmbTamano_TextChanged(object sender, TextChangedEventArgs e)
        {
            rtbTexto.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbTamano.Text);
        }


    }
}