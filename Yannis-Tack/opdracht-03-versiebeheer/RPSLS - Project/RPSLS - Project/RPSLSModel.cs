using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  class RPSLSModel
  {
    private int amountOfPlayers = 0, playerTurn = 0;

    public int PlayerTurn
    {
      get
      {
        return playerTurn;
      }
      set
      {
        playerTurn = value;
      }
    }

    public RPSLSModel(int playerCount)
    {
      amountOfPlayers = playerCount;
    }
  }
}
