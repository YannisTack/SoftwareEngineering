using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class GameController
  {
    private GameView view;
    private YahtzeeController yahtzeeController;
    private ScoreboardController scoreboardController;

    public GameController()
    {
      yahtzeeController = new YahtzeeController(this);
      scoreboardController = new ScoreboardController();
      view = new GameView(this);
    }

    public YahtzeeView GetYahtzeeView()
    {
      return yahtzeeController.GetView();
    }

    public ScoreboardView GetScoreboardView()
    {
      return scoreboardController.GetView();
    }

    public GameView GetView()
    {
      return view;
    }

    public void IncreaseAmountOfThrows()
    {
      
      scoreboardController.IncreaseAmountOfThrows();
    }

    public void IncreasePoints()
    {
      scoreboardController.IncreasePoints();
    }

    public bool AbleToThrowAll()
    {
      if (scoreboardController.GetAmountOfThrows() < scoreboardController.GetMaxAmountOfThrows())
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
