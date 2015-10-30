using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLS___Project
{
  public partial class HandView : UserControl
  {
    private HandController controller;

    public HandView(HandController c, bool isNpc)
    {
      InitializeComponent();

      controller = c;

      if (isNpc)
      {
        lblNaam.Text = "NPC";
        
      }
      else if (!isNpc)
      {
        lblNaam.Text = "Player";
      }
      btnLizard.Enabled = false;
      btnPaper.Enabled = false;
      btnRock.Enabled = false;
      btnScissors.Enabled = false;
      btnSpock.Enabled = false;
    }

    private void btnRock_Click(object sender, EventArgs e)
    {
      ButtonEnableDisable();
      controller.PlayerChoice(this.btnRock.Text);
    }

    private void btnPaper_Click(object sender, EventArgs e)
    {
      ButtonEnableDisable();
      controller.PlayerChoice(this.btnPaper.Text);
    }

    private void btnScissors_Click(object sender, EventArgs e)
    {
      ButtonEnableDisable();
      controller.PlayerChoice(this.btnScissors.Text);
    }

    private void btnLizard_Click(object sender, EventArgs e)
    {
      ButtonEnableDisable();
      controller.PlayerChoice(this.btnLizard.Text);
    }

    private void btnSpock_Click(object sender, EventArgs e)
    {
      ButtonEnableDisable();
      controller.PlayerChoice(this.btnSpock.Text);
    }

    public void ButtonEnableDisable()
    {
      btnLizard.Enabled = !btnLizard.Enabled;
      btnPaper.Enabled = !btnPaper.Enabled;
      btnRock.Enabled = !btnRock.Enabled;
      btnScissors.Enabled = !btnScissors.Enabled;
      btnSpock.Enabled = !btnSpock.Enabled;
    }

    public void UpdateUI(string choice)
    {
      lblChoice.Text = choice;
    }
  }
}
