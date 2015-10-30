using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
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
      YahtzeeView yahtzeeView = controller.GetYahtzeeView();
      ScoreboardView scoreboardView = controller.GetScoreboardView();

      yahtzeeView.Location = new Point(0, scoreboardView.Height);

      Controls.Add(scoreboardView);
      Controls.Add(yahtzeeView);
    }
  }
}
