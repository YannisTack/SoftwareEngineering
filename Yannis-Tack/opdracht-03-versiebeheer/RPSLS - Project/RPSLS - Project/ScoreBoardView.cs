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
  public partial class ScoreBoardView : UserControl
  {
    private ScoreBoardController controller;
    public ScoreBoardView(ScoreBoardController c)
    {
      InitializeComponent();
      controller = c;
    }
    
        public void UpdateUI()
        {
            lblPoints.Text  = "Points: " + controller.GetPoints();
            lblSets.Text    = "Sets: " + controller.GetSetPoints();
        }

        private void ScoreBoardView_Load(object sender, EventArgs e)
        {
            lblPoints.Text  = "Points: 0";
            lblSets.Text    = "Sets: 0";
        }
    }
}
