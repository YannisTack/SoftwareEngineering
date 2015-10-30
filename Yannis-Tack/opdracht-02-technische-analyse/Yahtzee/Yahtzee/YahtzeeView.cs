using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
  public partial class YahtzeeView : UserControl
  {
    private YahtzeeController controller;
    public YahtzeeView(YahtzeeController c)
    {
      InitializeComponent();

      controller = c;
    }

    public void UpdateUI()
    {

    }

    private void YahtzeeView_Load(object sender, EventArgs e)
    {
      List<DiceView> diceViews = controller.GetDiceViews();

      int diceWidth = diceViews.First().Width;
      int diceHeight = diceViews.First().Height;

      this.Width = diceWidth * diceViews.Count;
      this.Height = 200;

      foreach (DiceView diceView in diceViews)
      {
        DiceView tempDice = diceView;
        int xPos = diceWidth * diceViews.IndexOf(diceView);
        tempDice.Location = new Point(xPos, 0);

        Controls.Add(tempDice);
      }
    }

    private void btnThrowAll_Click(object sender, EventArgs e)
    {
      controller.ThrowAllDice();
    }
  }
}
