using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLS___Project
{
    public partial class GameView : Form
    {
        private GameController controller;
        public GameView(GameController c)
        {
            InitializeComponent();
      
            controller = c;
        }

    private void GameView_Load(object sender, EventArgs e)
    {
      RPSLSView rpslsView = controller.GetRPSLSView();
      List<ScoreBoardView> scoreboards = controller.GetScoreboardViews();
      int scoreboardWidth = scoreboards.First().Width;
      int scoreboardHeight = scoreboards.First().Height;
      //scoreboardView.Width = 100;
      //scoreboardView.Height = 100;
      //scoreboards.Location = new Point(0, 200);
      this.Width = scoreboards.Count();
      //this.Width = rpslsView.Width;
      this.Height = 400;

      foreach(ScoreBoardView scoreboard in scoreboards)
      {
        ScoreBoardView tempScoreboard = scoreboard;
        int xPos = scoreboards.IndexOf(scoreboard) * scoreboardWidth;
        scoreboard.Location = new Point(xPos, 230);
        Controls.Add(tempScoreboard);
      }

      // Debugging
      Console.WriteLine("RPSLS Location: " + rpslsView.Location);
      Console.WriteLine("RPSLS Height: " + rpslsView.Height);
      Controls.Add(rpslsView);
    }
  }
}
