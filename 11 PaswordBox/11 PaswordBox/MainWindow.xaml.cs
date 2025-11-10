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

namespace _11_PaswordBox
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

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            //Obtenemos los datos
            string nombre = txtNombre.Text;
            string pass = pwdPassword.Password;

            if (nombre == "yo@miweb.com" && pass == "abc123")
                MessageBox.Show("Haz entrado al sitio");
            else
                MessageBox.Show("Nombre o password erroneo");


            //Podemos colocar el caracter con PasswordChar
            //y la cantidad de caracteres con MaxLength
        }

        private void x(object sender, RoutedEventArgs e)
        {

        }
    }
}
