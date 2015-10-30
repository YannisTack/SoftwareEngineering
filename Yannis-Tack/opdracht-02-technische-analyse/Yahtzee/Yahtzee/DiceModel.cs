using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class DiceModel
  {
    private DiceController controller;
    private Random random;
    private int thrownNumber;
    private bool isHeld = false;

    public int ThrownNumber
    {
      get
      {
        return thrownNumber;
      }
    }

    public bool IsHeld
    {
      get
      {
        return isHeld;
      }
      set
      {
        isHeld = value;
      }
    }

    public DiceModel(DiceController c)
    {
      controller = c;
      random = new Random();
    }

    public void ThrowRandom()
    {
      thrownNumber = random.Next(1, 7);
    }
  }
}
