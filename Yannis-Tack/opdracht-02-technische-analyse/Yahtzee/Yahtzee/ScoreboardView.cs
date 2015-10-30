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
  public partial class ScoreboardView : UserControl
  {
    private ScoreboardController controller;
    public ScoreboardView(ScoreboardController c)
    {
      InitializeComponent();

      controller = c;
    }

    public void UpdateUI()
    {
      lblPoints.Text = "Points: " + controller.GetPoints().ToString();
      lblThrows.Text = "Throws: " + controller.GetAmountOfThrows() + "/" + controller.GetMaxAmountOfThrows();
    }

    private void ScoreboardView_Load(object sender, EventArgs e)
    {
      UpdateUI();
    }
  }
}
