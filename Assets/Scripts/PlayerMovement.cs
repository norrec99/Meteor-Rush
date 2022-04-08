using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  // [SerializeField] ParticleSystem explosionParticle;

  ScoreBoard scoreBoard;

  public float moveSpeed = 0.2f;
  [SerializeField] float multiplier = 0.1f;
  [SerializeField] float scorePerSecond = 5f;
  float totalScore;

  void Start()
  {
    scoreBoard = FindObjectOfType<ScoreBoard>();
  }

  void FixedUpdate()
  {
    TouchMove();
    ScoreCalculator();
  }

  void TouchMove()
  {
    if (Input.GetMouseButton(0))
    {
      Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

      if (mousePos.x > 1)
      {
        //move right
        transform.Translate(0, -moveSpeed, 0);
      }
      else if (mousePos.x < -1)
      {
        //move left
        transform.Translate(0, moveSpeed, 0);
      }
    }
  }

  void ScoreCalculator()
  {
    if (Time.timeSinceLevelLoad < 5)
    {
      totalScore += scorePerSecond * multiplier * Time.deltaTime;
      scoreBoard.IncreaseScore(totalScore);
    }
    else if (Time.timeSinceLevelLoad > 5)
    {
      totalScore += scorePerSecond * multiplier * Time.deltaTime;
      scoreBoard.IncreaseScoreWithMultiplier(totalScore, 0.2f);
    }
    else if (Time.timeSinceLevelLoad > 15)
    {
      totalScore += scorePerSecond * multiplier * Time.deltaTime;
      scoreBoard.IncreaseScoreWithMultiplier(totalScore, 0.3f);
    }
    else if (Time.timeSinceLevelLoad > 25)
    {
      totalScore += scorePerSecond * multiplier * Time.deltaTime;
      scoreBoard.IncreaseScoreWithMultiplier(totalScore, 0.5f);
    }
  }

  // void OnCollisionEnter2D(Collision2D other)
  // {
  //   if (other.gameObject.tag == "Meteor")
  //   {
  //     explosionParticle.Play();
  //   }
  // }
}
