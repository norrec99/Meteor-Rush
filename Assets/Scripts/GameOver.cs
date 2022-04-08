using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
  Text gameOver;

  // Start is called before the first frame update
  void Start()
  {
    gameOver = GetComponent<Text>();
    gameOver.GetComponent<Text>().enabled = false;
  }

  public void GameOverText()
  {
    gameOver.GetComponent<Text>().enabled = true;
    gameOver.text = "Game Over!";
  }
}
