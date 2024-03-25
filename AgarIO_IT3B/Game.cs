using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace AgarIO_IT3B
{
  public class Game
  {
    public Rectangle Space { get; }
    public List<Player> Players { get; }
    public List<Food> Food { get; }

    public Game(int width, int height)
    {
      Space = new Rectangle() { Width = width, Height = height };
      Players = new List<Player>();
      Food = new List<Food>();
    }

    public void Initialize(Player player)
    {
      Players.Add(player);

    }
  }
}
