using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  class YahtzeeModel
  {
    private YahtzeeController controller;
    private int amountOfDice = 3;

    public int AmountOfDice
    {
      get
      {
        return amountOfDice;
      }
    }

    public YahtzeeModel(YahtzeeController c)
    {
      controller = c;
    }
  }
}
