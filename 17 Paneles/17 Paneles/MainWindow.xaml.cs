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

namespace _17_Paneles
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
        //Los paneles actuan como contenedores para otros controles
        //Esto nos permite control en la organizacion nde ventanas
        //Como la ventana solo puede tener un hijo, colocamos un tipo de panel como su hijo
       //y esto nos permite mas controles

        //Los paneles se comportan de formas diferentes
        //por eso es importante seleccionar el correcto

        //canvas
        //Se pqrece q lq formq en aue trqbqjq Winform
        //Nos permite colocar coordenadas a cada control y de esq forma colocamos
        //donde deseamos los controles

        //WrapPanel
        //Este posiciona cadq control junto al otro de forma goriwontal o vertical
        //Es util cuando deseamos tener un ordenamiento horizontal o vertical
        //que se ajuste automaticamente

        //Stackpanel
        //Es en cierta forma similar a wrapPanel, va colocando los controles
        //de forma horizontal o vertical, uno junto a otro
        //La diferencia consiste en aue lugar de cambiar fila o comulna,
        //expande cuando ya no hay mas area

        //DockPanel
        //En este los controles son colocados en posicion por medio de valores aue indican
        //la distancia a la parte superior, inferior, derecha o izquierda (Top, Bottom, Left? Rigth)
        //Por default el ultimo control suele usar el espacio remanente
        //Es util cuando deseamos dividir las ventanas en areas

    }
}