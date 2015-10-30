using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  public class RPSLSController
  {
    private HandController[] playerArray;
    private HandController player, npc;
    private RPSLSModel model;
    private RPSLSView view;
    private GameController gameController;

    public RPSLSController(GameController c, int amountOfPlayers)
    {
      int playerCount = 0;
      playerArray = new HandController[amountOfPlayers];
      for (int i = 0; i < amountOfPlayers; i++)
      {
        if (i > 0)  // Meerdere nps's
        {
          playerArray[i] = new HandController(true, this);
        }
        else    // Enkel 1 player
        {
          playerArray[i] = new HandController(false, this);
        }
      }
      
      //player = new HandController(false, this);
      //playerArray[playerCount] = player;
      //playerCount++;

      //npc = new HandController(true, this);
      //playerArray[playerCount] = npc;
      //playerCount++;

      model = new RPSLSModel(amountOfPlayers);
      view = new RPSLSView(this);

      gameController = c;

      StartTurn();
    }

    public RPSLSView GetView()
    {
      return view;
    }

    public List<HandView> GetViewHands()
    {
      List<HandView> viewOfHands = new List<HandView>();
      foreach (HandController hand in playerArray)
      {
        HandView handView = hand.getView();
        viewOfHands.Add(handView);
      }
      return viewOfHands;
    }

    private void StartTurn()
    {
      playerArray[model.PlayerTurn].ChooseHand();
    }

    public void NextTurn()
    {
      if (model.PlayerTurn == playerArray.Length - 1)   // Als iedereen aan de beurt is geweest
      {
        int winningNumber = CalculateWinner();
        if (winningNumber == 0)
        {
          Console.WriteLine("Draw !");
        }
        else
        {
          Console.WriteLine("Player" + CalculateWinner() + " wins !");
          gameController.UpdateScoreboard(winningNumber);
        }
        model.PlayerTurn = 0;
        StartTurn();
      }
      else
      {
        model.PlayerTurn++;
        StartTurn();
      }
    }

    private int CalculateWinner()
    {
      string[] handsOfChoice = new string[playerArray.Length];
      int[] tempPoints = new int[playerArray.Length];
      for (int i = 0; i < playerArray.Length; i++)      //  Get all handsOfChoice
      {
        handsOfChoice[i] = playerArray[i].GetHand();
        Console.WriteLine("Player" + (i + 1) + " chooses: " + playerArray[i].GetHand());
      }

      for (int i = 0; i < handsOfChoice.Length; i++)    //  Vergelijkt alle handsOfChoice met de rest
      {
        for (int j = 0; j < handsOfChoice.Length; j++)
        {
          if (j != i)
          {
            tempPoints[i] += CalculateHands(handsOfChoice[i], handsOfChoice[j]);
          }
          Console.WriteLine("Player" + (i + 1) + " has " + tempPoints[i] + " points");
        }
       
      }
      Console.WriteLine(tempPoints[0] + " - " + tempPoints[1] + " - " + tempPoints[2]);

      int winningPlayerNumber = 0;
      int highestPoints = 0;
      for (int i = 1; i <= tempPoints.Length; i++)   // i = 1 omdat Draw = 0
      {
        if (tempPoints[i - 1] > highestPoints)
        {
          winningPlayerNumber = i;
          highestPoints = tempPoints[i - 1];
        }
        else if (tempPoints[i - 1] == highestPoints)
        {
          winningPlayerNumber = 0;
          highestPoints = tempPoints[i - 1];
        }
        
      }
      return winningPlayerNumber;
    }

    private int CalculateHands(string s, string t)
    {
      switch (s)
      {
        case "Rock":
          {
            if (t == "Rock" || t == "Paper" || t == "Spock")
            {
              return 0;
            }
            else if (t == "Scissors" || t == "Lizard")
            {
              return 1;
            }
            return 0;
          }
        case "Paper":
          {
            if (t == "Lizard" || t == "Paper" || t == "Scissors")
            {
              return 0;
            }
            else if (t == "Rock" || t == "Spock")
            {
              return 1;
            }
            return 0;
          }
        case "Scissors":
          {
            if (t == "Rock" || t == "Scissors" || t == "Spock")
            {
              return 0;
            }
            else if (t == "Paper" || t == "Lizard")
            {
              return 1;
            }
            return 0;
          }
        case "Lizard":
          {
            if (t == "Rock" || t == "Scissors" || t == "Lizard")
            {
              return 0;
            }
            else if (t == "Spock" || t == "Paper")
            {
              return 1;
            }
            return 0;
          }
        case "Spock":
          {
            if (t == "Lizard" || t == "Paper" || t == "Spock")
            {
              return 0;
            }
            else if (t == "Scissors" || t == "Rock")
            {
              return 1;
            }
            return 0;
          }
        default: return 0;
      }
    }
  }
}
