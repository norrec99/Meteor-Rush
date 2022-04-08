using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
  [SerializeField] float multiplier = 0.1f;
  [SerializeField] float scorePerSecond = 5f;

  ScoreBoard scoreBoard;

  float totalScore;
  // Start is called before the first frame update
  void Start()
  {
    scoreBoard = FindObjectOfType<ScoreBoard>();
  }

  // Update is called once per frame
  void Update()
  {
    CalculateScore();
  }

  void CalculateScore()
  {
    if (Time.timeSinceLevelLoad < 5)
    {
      totalScore += scorePerSecond * multiplier * Time.timeSinceLevelLoad;
      scoreBoard.IncreaseScore(totalScore);
    }
    else if (Time.timeSinceLevelLoad > 5)
    {
      totalScore += scorePerSecond * multiplier * Time.timeSinceLevelLoad;
      scoreBoard.IncreaseScoreWithMultiplier(totalScore, 0.2f);
    }
    else if (Time.timeSinceLevelLoad > 15)
    {
      totalScore += scorePerSecond * multiplier * Time.timeSinceLevelLoad;
      scoreBoard.IncreaseScoreWithMultiplier(totalScore, 0.3f);
    }
    else if (Time.timeSinceLevelLoad > 25)
    {
      totalScore += scorePerSecond * multiplier * Time.timeSinceLevelLoad;
      scoreBoard.IncreaseScoreWithMultiplier(totalScore, 0.5f);
    }
  }
}
