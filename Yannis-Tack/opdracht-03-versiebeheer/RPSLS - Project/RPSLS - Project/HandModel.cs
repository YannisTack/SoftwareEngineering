using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  public class HandModel
  {
    private static Random randomGenerator;
    private string handOfChoice;
    private bool isNpc;
    private HandController controller;
    private string[] handArray = new string[5] { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

    public string HandOfChoice
    {
      get
      {
        return handOfChoice;
      }
      set
      {
        handOfChoice = value;
      }
    }

    public bool IsNpc
    {
      get
      {
        return isNpc;
      }
      set
      {
        isNpc = value;
      }
    }

    public HandModel(HandController c)
    {
      randomGenerator = new Random();
      controller = c;
    }

    public void ChooseRandom()
    {
      handOfChoice = handArray[randomGenerator.Next(0,5)];
    }
  }
}
