using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class DiceController
  {
    private DiceModel model;
    private DiceView view;

    public DiceController()
    {
      model = new DiceModel(this);
      view = new DiceView(this);
    }

    public DiceView GetView()
    {
      return view;
    }

    public void RollDice()
    {
      if (!model.IsHeld)
      {
        model.ThrowRandom();
        view.UpdateUI(model.IsHeld);
      }
    }

    public int GetThrownNumber()
    {
      return model.ThrownNumber;
    }

    public void ChangeHeldStatus()
    {
      model.IsHeld = !model.IsHeld;
      view.UpdateUI(model.IsHeld);
    }
  }
}
