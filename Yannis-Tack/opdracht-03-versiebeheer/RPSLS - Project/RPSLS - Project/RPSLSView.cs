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
  public partial class RPSLSView : UserControl
  {
    private RPSLSController controller;
    public RPSLSView(RPSLSController c)
    {
      controller = c;
      InitializeComponent();
    }

    private void RPSLSView_Load(object sender, EventArgs e)
    {
      List<HandView> hands = controller.GetViewHands();

      int handWidth = hands.First().Width;
      int handHeight = hands.First().Height;

      this.Width = handWidth * hands.Count;
      this.Height = handHeight;
      Console.WriteLine("HandSize: " + handWidth + "," + handHeight);
      Console.WriteLine("RPSLS Size: " + Width + "," + Height);

      foreach (HandView hand in hands)
      {
        HandView tempHand = hand;
        int xPos = hands.IndexOf(hand) * handWidth;
        hand.Location = new Point(xPos, 0);
        Controls.Add(tempHand);
      }
    }
  }
}
