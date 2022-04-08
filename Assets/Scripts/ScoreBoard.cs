using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{

  float score;

  Text scoreText;

  // Start is called before the first frame update
  void Start()
  {
    scoreText = GetComponent<Text>();
    scoreText.text = "Score: " + score;
  }

  public void IncreaseScore(float amountToIncrease)
  {
    score += amountToIncrease;
    float totalScore = Mathf.RoundToInt(score);
    scoreText.text = "Score: " + totalScore.ToString();
  }

  public void IncreaseScoreWithMultiplier(float amountToIncrease, float multiplier)
  {
    score += amountToIncrease * multiplier;
    int totalScore = Mathf.RoundToInt(score);
    int multiplierScore = Mathf.RoundToInt(multiplier * 10);
    scoreText.text = "Score: " + totalScore.ToString() + " x" + multiplierScore.ToString();
  }

}
