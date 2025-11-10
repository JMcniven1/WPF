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

namespace ImagenZoom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double zoom = 1.0;
        private const double ZoomFactor = 0.1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void imgZoom_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
                zoom += ZoomFactor;
            else
                zoom -= ZoomFactor;

            if (zoom < 0.1)
                zoom = 0.1;

            scaleTransform.ScaleX = zoom;
            scaleTransform.ScaleY = zoom;

            e.Handled = true; // previene scroll adicional fuera del área definida
        }
    }
}