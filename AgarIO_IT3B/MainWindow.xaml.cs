using System.Numerics;
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
        Ellipse elipse = new Ellipse();
    public MainWindow()
    {
     
    }
    public void See()
    {
            double x = canvasGame.ActualWidth / 2;
            double y = canvasGame.ActualHeight / 2;

        Player player = new Player(Brushes.Black, "Tonda");
            player.Location = new Point(x, y);

            new Ellipse
            {
                Fill = player.Color,
                Width = player.Size,
                Height = player.Size
            };
            canvasGame.Children.Add(elipse);
            Canvas.SetTop(elipse,player.Location.Y);    
            Canvas.SetLeft(elipse,player.Location.X);
    }

        private void CanvasGame_MouseMove(object sender, MouseEventArgs e)
        {
            double mouseX = e.GetPosition(canvasGame).X;
            double mouseY = e.GetPosition(canvasGame).Y;

            Canvas.SetTop(elipse, mouseY - player.Size / 2);
            Canvas.SetLeft(elipse, mouseX - player.Size / 2);
            player.Location = new Point(mouseX, mouseY);
        }

        private void CanvasGame_MouseLeave(object sender, MouseEventArgs e)
        {
            // Pokud myš opustí canvas, můžete například nastavit pozici mimo viditelnou oblast
            // nebo skrýt elipsu, v závislosti na požadavcích hry.
            Canvas.SetTop(ellipse, -player.Size);
            Canvas.SetLeft(ellipse, -player.Size);
        }
    }
    private void canvasGame_Loaded(object sender, RoutedEventArgs e)
        {
            See();
        }
        //nevim co s tim mam delat kod mi nefungoval sorry XDDD
    }
}