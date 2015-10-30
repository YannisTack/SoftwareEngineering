using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class YahtzeeController
  {
    private GameController gameController;
    private YahtzeeModel model;
    private YahtzeeView view;
    private DiceController[] dices;

    public YahtzeeController(GameController c)
    {
      gameController = c;
      model = new YahtzeeModel(this);
      view = new YahtzeeView(this);

      dices = new DiceController[model.AmountOfDice];

      for (int i = 0; i < dices.Length; i++)
      {
        dices[i] = new DiceController();
      }
    }

    public YahtzeeView GetView()
    {
      return view;
    }

    public List<DiceView> GetDiceViews()
    {
      List<DiceView> diceViews = new List<DiceView>();
      for (int i = 0; i < dices.Length; i++)
      {
        diceViews.Add(dices[i].GetView());
      }
      return diceViews;
    }

    public void ThrowAllDice()
    {
      if (gameController.AbleToThrowAll())
      {
        for (int i = 0; i < dices.Length; i++)
        {
          dices[i].RollDice();
        }
        if (CheckIfWon())
        {
          gameController.IncreasePoints();
        }
        gameController.IncreaseAmountOfThrows();
      }
    }

    private bool CheckIfWon()
    {
      bool hasWon = false;
      for(int i = 0; i < dices.Length - 1; i++)
      {
        if (dices[i].GetThrownNumber() == dices[i+1].GetThrownNumber())
        {
          hasWon = true;
        }
        else
        {
          return false;
        }
      }
      if (hasWon)
      {
        return hasWon;
      }
      return false;
    }
  }
}
