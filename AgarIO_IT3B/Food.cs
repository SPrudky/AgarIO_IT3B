using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace AgarIO_IT3B
{
  public class Food
  {
    public Point Location { get; }
    public Brush Color { get; }
    public int Value { get; } = 1;

    public Food(Point location, Brush color)
    {
      Location = location;
      Color = color;
    }
  }
}
