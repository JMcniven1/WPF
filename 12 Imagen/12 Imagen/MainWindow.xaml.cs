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
//Lo necesitamos para el OpenFileDialog
using Microsoft.Win32;

namespace _12_Imagen
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

        private void btnCargar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PNG (*.PNG)|*.png";

            if (openFileDialog.ShowDialog() == true) 
            { 
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgImagen.Source = new BitmapImage(fileUri);
            }
        }
    }
}
