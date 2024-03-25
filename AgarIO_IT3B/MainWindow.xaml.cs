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

namespace AgarIO_IT3B
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>,
  public partial class MainWindow : Window
  {

    public MainWindow()
    {
     
    }
    public void See()
    {
            double x = canvasGame.ActualWidth / 2;
            double y = canvasGame.ActualHeight / 2;

        Player player = new Player(Brushes.Black, "Tonda");
            player.Location = new Point(x, y);
            Ellipse elipse = new Ellipse()
            {
                Fill = player.Color,
                Width = player.Size,
                Height = player.Size
            };
            canvasGame.Children.Add(elipse);
            Canvas.SetTop(elipse,player.Location.Y);    
            Canvas.SetLeft(elipse,player.Location.X);
    }
  }
}