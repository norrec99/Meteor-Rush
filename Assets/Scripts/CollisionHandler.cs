using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

  [SerializeField] ParticleSystem explosionParticle;
  // [SerializeField] float levelLoadDelay = 2f;

  GameOver gameOver;

  bool isCollided = false;

  // Start is called before the first frame update
  void Start()
  {
    gameOver = FindObjectOfType<GameOver>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.touchCount > 0)
    {
      ReloadLevel();
    }
  }

  void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.tag == "Meteor")
    {
      StartCrashSequence();
      gameOver.GameOverText();

    }

  }

  void StartCrashSequence()
  {
    isCollided = true;
    explosionParticle.Play();
    GetComponent<PlayerMovement>().enabled = false;
    // Destroy(gameObject, 0.5f);
  }

  void ReloadLevel()
  {
    if (Input.GetTouch(0).tapCount == 2 && isCollided)
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      isCollided = false;

    }
  }
}
