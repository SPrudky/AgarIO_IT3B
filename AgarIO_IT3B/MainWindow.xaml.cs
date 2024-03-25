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
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }
  
    public void See()
        {
            double y = canvasGame.ActualHeight / 2;
            double x = canvasGame.ActualWidth / 2;

            Player player = new Player(Brushes.Blue, "Martin")
            {
                Location = new Point(x,y),
            };
            Ellipse ellipse = new Ellipse()
            {
                Fill = player.Color,
                Width = player.Size,
                Height = player.Size,
            };
            canvasGame.Children.Add(ellipse);
            Canvas.SetLeft(ellipse, player.Location.X);
            Canvas.SetTop(ellipse, player.Location.Y);
        }
  }
}