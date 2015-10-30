using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  public class ScoreBoardModel
  {
    private int points;
    private int setPoints;
    private int pointsRequiredForSet;
    private ScoreBoardController controller;

    public int Points
    {
      get
      {
        return points;
      }
      set
      {
        points = value;
      }
    }

    public int SetPoints
    {
      get
      {
        return setPoints;
      }
      set
      {
        setPoints = value;
      }
    }

    public int PointsRequiredForSet
    {
      get
      {
        return pointsRequiredForSet;
      }
    }

    public ScoreBoardModel(ScoreBoardController c, int pointsRequiredForSetParameter)
    {
      controller = c;
      pointsRequiredForSet = pointsRequiredForSetParameter;
    }
  }
}
