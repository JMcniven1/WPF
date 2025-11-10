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

namespace _16_MessageBox
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

        private void btnMensaje_Click(object sender, RoutedEventArgs e)
        {
            //Solo mensaje
            //MessageBox.Show("Hola a todos");

            //Mensaje y titulo
            //MessageBox.Show("Hola a todos","Desde mi aplicacion");

            //Colocamos botones extra
            //OK, OKCancel, YesNoCancel, YesNo

            //MessageBoxResult seleccion = MessageBox.Show("Te gusta el curso?","Pregunta",
            //    MessageBoxButton.YesNoCancel);
            //switch(seleccion)
            //{
            //    case MessageBoxResult.Yes:
            //        MessageBox.Show("Dice SI");
            //        break;
            //    case MessageBoxResult.No:
            //        MessageBox.Show("Dice No");
            //        break;
            //    case MessageBoxResult.Cancel:
            //        MessageBox.Show("Dice Cancel");
            //        break;
            //}

            //Mensaje con imagen
            //Asterisk, Error, Exclamation, Hand, Information, None, Question, Stop, Warning
            //MessageBox.Show("Hola a todos", "desde mi aplicacion", MessageBoxButton.YesNo, MessageBoxImage.Stop);


            //Opcion de default
            MessageBox.Show("Hola a todos", "Desde mi aplicacion", MessageBoxButton.YesNoCancel, MessageBoxImage.Stop, MessageBoxResult.Cancel);
        }
    }
}