using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  public class HandController
  {
    private HandModel model;
    private HandView view;
    private RPSLSController rpslsController;

    public HandController(bool isNpc, RPSLSController c)
    {
      model = new HandModel(this);
      view = new HandView(this, isNpc);
      model.IsNpc = isNpc;
      rpslsController = c;
    }

    public HandView getView()
    {
      return view;
    }

    public string GetHand()
    {
      return model.HandOfChoice;
    }

    public void NpcChoice()
    {
      model.ChooseRandom();
      view.UpdateUI(model.HandOfChoice);
      rpslsController.NextTurn();
    }

    public void PlayerChoice(string buttonText)
    {
      model.HandOfChoice = buttonText;
      view.UpdateUI(model.HandOfChoice);
      rpslsController.NextTurn();
    }

    public void ChooseHand()
    {
      model.HandOfChoice = "";
      if (model.IsNpc)
      {
        NpcChoice();
      }
      else
      {
        view.ButtonEnableDisable();
      }
    }
  }
}
