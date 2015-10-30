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
  public partial class DiceView : UserControl
  {
    private DiceController controller;
    public DiceView(DiceController c)
    {
      InitializeComponent();

      controller = c;
      lblDice.BackColor = Color.White;
    }

    public void UpdateUI(bool isHeld)
    {
      int newNumber = controller.GetThrownNumber();
      lblDice.Text = newNumber.ToString();

      if (isHeld)
      {
        lblDice.BackColor = Color.Red;
      }
      else
      {
        lblDice.BackColor = Color.White;
      }
    }

    private void btnThrow_Click(object sender, EventArgs e)
    {
      controller.RollDice();
    }

    private void lblDice_Click(object sender, EventArgs e)
    {
      controller.ChangeHeldStatus();
    }
  }
}
