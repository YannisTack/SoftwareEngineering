using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  public class GameController
  {
    private GameView view;
    private RPSLSController rpsls;
    private ScoreBoardController[] scoreboards;
    private int amountOfPlayers = 3;
    private int pointsRequiredForSet = 3;

    public GameController()
    {
      rpsls = new RPSLSController(this, amountOfPlayers);   // 2de parameter = amount of players
      scoreboards = new ScoreBoardController[amountOfPlayers];
      for (int i = 0; i < amountOfPlayers; i++)
      {
        scoreboards[i] = new ScoreBoardController(this, pointsRequiredForSet); // 2de parameter = amount of points nodig voor een set te winnen
      }
      view = new GameView(this);
    }

    public GameView GetView()
    {
      return view;
    }

    public RPSLSView GetRPSLSView()
    {
      return rpsls.GetView();
    }

    public List<ScoreBoardView> GetScoreboardViews()
    {
      List<ScoreBoardView> viewOfScoreboards = new List<ScoreBoardView>();
      foreach (ScoreBoardController scoreboard in scoreboards)
      {
        ScoreBoardView scoreboardView = scoreboard.GetView();
        viewOfScoreboards.Add(scoreboardView);
      }
      return viewOfScoreboards;
    }

    public void UpdateScoreboard(int winningPlayerNumber)
    {
      scoreboards[winningPlayerNumber - 1].UpdateView();
    }

    public void ResetPoints()
    {
      for (int i = 0; i < scoreboards.Length; i++)
      {
        scoreboards[i].ResetPoints();
      }
    }
  }
}
