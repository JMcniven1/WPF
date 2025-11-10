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

namespace _9_ChechBox
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            //Obtenemos la cantidad
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            //Hacemos la sumatoria de lo que lleva la hamburguesa
            double total = 25; //Precio inicial

            //Dpedniendo de que este seleccionado se aumenta el total
            if (chkCebolla.IsChecked == true)
                total += 1 ;
            if (chkJitomate.IsChecked == true)
                total += 3.5 ;
            if (chkPapas.IsChecked == true)
                total += 12.35;

            double granTotal = total * cantidad;

            // Mostramos el resultado
            txbTotal.Text = "$" + granTotal.ToString();
        }
    }
}
