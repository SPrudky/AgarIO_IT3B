using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AgarIO_IT3B
{
    public partial class MainWindow : Window
    {
        private Player player;
        private bool isMousePressed = false;

        public MainWindow()
        {
            InitializeComponent();
            canvasGame.MouseLeftButtonDown += CanvasGame_MouseLeftButtonDown;
            canvasGame.MouseLeftButtonUp += CanvasGame_MouseLeftButtonUp;
            canvasGame.MouseMove += CanvasGame_MouseMove;
        }

        private void CanvasGame_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isMousePressed = true;
        }

        private void CanvasGame_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isMousePressed = false;
        }

        private void CanvasGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePressed && player != null)
            {
                Point mousePosition = e.GetPosition(canvasGame);
                player.Location = mousePosition;
                UpdatePlayerUI();
            }
        }

        private void See()
        {
            double y = canvasGame.ActualHeight / 2;
            double x = canvasGame.ActualWidth / 2;

            player = new Player(Brushes.Blue, "Martin")
            {
                Location = new Point(x, y),
            };
            UpdatePlayerUI();
        }

        private void UpdatePlayerUI()
        {
            canvasGame.Children.Clear();

            Ellipse ellipse = new Ellipse()
            {
                Fill = player.Color,
                Width = player.Size,
                Height = player.Size,
            };
            canvasGame.Children.Add(ellipse);
            Canvas.SetLeft(ellipse, player.Location.X - player.Size / 2);
            Canvas.SetTop(ellipse, player.Location.Y - player.Size / 2);
        }

        private void canvasGame_Loaded(object sender, RoutedEventArgs e)
        {
            See();
        }
    }
}
