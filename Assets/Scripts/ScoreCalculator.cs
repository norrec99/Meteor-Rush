using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
  [SerializeField] float scorePerSecond = 5f;
  [SerializeField] AudioClip collectSound;

  ScoreBoard scoreBoard;
  AudioSource audioSource;

  MultiplierText multiplierText;

  float multiplier = 0.01f;
  float totalScore;
  // Start is called before the first frame update
  void Start()
  {
    scoreBoard = FindObjectOfType<ScoreBoard>();
    multiplierText = FindObjectOfType<MultiplierText>();
    audioSource = GetComponent<AudioSource>();
  }

  // Update is called once per frame
  void Update()
  {
    CalculateScore();
    multiplierText.DisplayMultiplier(multiplier * 100);
  }

  void CalculateScore()
  {
    if (Time.timeSinceLevelLoad > 5)
    {
      IncreaseScore(totalScore, multiplier * 5);
    }
    else if (Time.timeSinceLevelLoad > 15)
    {
      IncreaseScore(totalScore, multiplier * 10);
    }
    else if (Time.timeSinceLevelLoad > 25)
    {
      IncreaseScore(totalScore, multiplier * 50);
    }
    else
    {
      IncreaseScore(totalScore, multiplier);
    }
  }

  void IncreaseScore(float score, float factor)
  {
    score += scorePerSecond * factor * Time.timeSinceLevelLoad;
    scoreBoard.IncreaseScore(score);
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "Gem")
    {
      audioSource.PlayOneShot(collectSound);
      multiplier += 0.01f;
      Destroy(other.gameObject);
    }
  }
}
