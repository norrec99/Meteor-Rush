using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
  [SerializeField] ParticleSystem explosionParticle;
  // [SerializeField] float levelLoadDelay = 2f;

  GameObject[] meteors;
  MeteorSpawner meteorSpawner;
  GameManager gameManager;
  GameOver gameOver;
  ScoreCalculator scoreCalculator;
  BlinkingText blinkingText;

  bool isCollided = false;

  // Start is called before the first frame update
  void Start()
  {
    gameManager = FindObjectOfType<GameManager>();
    meteorSpawner = FindObjectOfType<MeteorSpawner>();
    gameOver = FindObjectOfType<GameOver>();
    scoreCalculator = FindObjectOfType<ScoreCalculator>();
    blinkingText = FindObjectOfType<BlinkingText>();
    blinkingText.StopBlinking();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.touchCount > 0 && isCollided)
    {
      ReloadLevel();
      blinkingText.StopBlinking();
    }

  }

  void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.tag == "Meteor")
    {
      StartCrashSequence();
      gameOver.GameOverText();
      DestroyClones();
    }

  }

  void DestroyClones()
  {
    meteorSpawner.GetComponent<MeteorSpawner>().enabled = false;
    meteors = GameObject.FindGameObjectsWithTag("Meteor");
    foreach (GameObject meteor in meteors)
    {
      Destroy(meteor);
    }
  }

  void StartCrashSequence()
  {
    isCollided = true;
    explosionParticle.Play();
    blinkingText.StartBlinking();
    GetComponent<PlayerMovement>().enabled = false;
    scoreCalculator.GetComponent<ScoreCalculator>().enabled = false;
    // gameManager.DestroyPlayer();
    // Destroy(gameObject, 0.5f);
  }

  void ReloadLevel()
  {
    if (Input.GetTouch(0).tapCount == 2 && isCollided)
    {
      blinkingText.StopBlinking();
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      isCollided = false;

    }
  }
}
