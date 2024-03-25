using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace AgarIO_IT3B
{
  public class Player
  {
    public double Size { get; set; }
    //public double Speed { get; set; }
    public Brush Color { get; set; }
    public string Name { get; set; }
    public Point Location { get; set; }

    public Player(Brush color, string name)
    {
      Color = color;
      Name = name;
      Size = 10;
      Location = new Point(0, 0);
    }
  }
}
