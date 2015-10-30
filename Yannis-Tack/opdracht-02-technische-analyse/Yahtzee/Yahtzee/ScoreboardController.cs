using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class ScoreboardController
  {
    private GameController gameController;
    private ScoreboardModel model;
    private ScoreboardView view;

    public ScoreboardController()
    {
      model = new ScoreboardModel(this);
      view = new ScoreboardView(this);
    }

    public ScoreboardView GetView()
    {
      return view;
    }

    public void IncreasePoints()
    {
      model.Score++;
      view.UpdateUI();
    }

    public void IncreaseAmountOfThrows()
    {
      model.AmountOfThrows++;
      view.UpdateUI();
    }

    public int GetPoints()
    {
      return model.Score;
    }

    public int GetAmountOfThrows()
    {
      return model.AmountOfThrows;
    }

    public int GetMaxAmountOfThrows()
    {
      return model.MaxAmountOfThrows;
    }
  }
}
