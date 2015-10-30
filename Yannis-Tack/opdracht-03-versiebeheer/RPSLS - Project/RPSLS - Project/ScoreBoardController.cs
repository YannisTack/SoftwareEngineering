using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{

  public class ScoreBoardController
  {
        private GameController gameController;

        private ScoreBoardView view;
        private ScoreBoardModel model;

        public ScoreBoardController( GameController c, int pointsRequiredForSetParameter)
        {
            gameController = c;
            view = new ScoreBoardView(this);
            model = new ScoreBoardModel(this, pointsRequiredForSetParameter);
        }

        public ScoreBoardView GetView()
        {
            return view;
        }
        public void UpdateView()
        {
            IncreasePoints();
            view.UpdateUI();
        }

        private void IncreasePoints()
        {
            model.Points++;
            if (model.Points >= model.PointsRequiredForSet)
            {
                model.SetPoints++;
                gameController.ResetPoints();
            }
        }

        public int GetPoints()
        {
            return model.Points;
        }

        public int GetSetPoints()
        {
            return model.SetPoints;
        }

        public void ResetPoints()
        {
            model.Points = 0;
            view.UpdateUI();
    }
  }
}
