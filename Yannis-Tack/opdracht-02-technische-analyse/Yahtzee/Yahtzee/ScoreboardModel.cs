using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class ScoreboardModel
  {
    private ScoreboardController controller;
    private int score = 0;
    private int amountOfThrows;
    private int maxAmountOfThrows = 5;

    public int Score
    {
      get
      {
        return score;
      }
      set
      {
        score = value;
      }
    }

    public int AmountOfThrows
    {
      get
      {
        return amountOfThrows;
      }
      set
      {
        amountOfThrows = value;
      }
    }

    public int MaxAmountOfThrows
    {
      get
      {
        return maxAmountOfThrows;
      }
    }

    public ScoreboardModel(ScoreboardController c)
    {
      controller = c;
    }
  }
}
