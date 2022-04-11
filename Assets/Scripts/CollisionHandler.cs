using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
  [SerializeField] ParticleSystem explosionParticle;
  [SerializeField] AudioClip explosionAudio;
  // [SerializeField] float levelLoadDelay = 2f;

  GameObject[] meteors;
  MeteorSpawner meteorSpawner;
  GameObject[] gems;
  GemSpawner gemSpawner;
  GameOver gameOver;
  ScoreCalculator scoreCalculator;
  BlinkingText blinkingText;
  AudioSource audioSource;

  bool isCollided = false;

  // Start is called before the first frame update
  void Start()
  {
    meteorSpawner = FindObjectOfType<MeteorSpawner>();
    gemSpawner = FindObjectOfType<GemSpawner>();
    gameOver = FindObjectOfType<GameOver>();
    scoreCalculator = FindObjectOfType<ScoreCalculator>();
    blinkingText = FindObjectOfType<BlinkingText>();
    blinkingText.StopBlinking();
    audioSource = GetComponent<AudioSource>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.touchCount > 0 && isCollided)
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
      DestroyMeteorClones();
      DestroyGemClones();
    }
  }

  void DestroyMeteorClones()
  {
    meteorSpawner.GetComponent<MeteorSpawner>().enabled = false;
    meteors = GameObject.FindGameObjectsWithTag("Meteor");
    foreach (GameObject meteor in meteors)
    {
      Destroy(meteor);
    }
  }

  void DestroyGemClones()
  {
    gemSpawner.GetComponent<GemSpawner>().enabled = false;
    gems = GameObject.FindGameObjectsWithTag("Gem");
    foreach (GameObject gem in gems)
    {
      Destroy(gem);
    }
  }

  void StartCrashSequence()
  {
    isCollided = true;
    explosionParticle.Play();
    audioSource.PlayOneShot(explosionAudio);
    blinkingText.StartBlinking();
    GetComponent<PlayerMovement>().enabled = false;
    GetComponent<SpriteRenderer>().enabled = false;
    scoreCalculator.GetComponent<ScoreCalculator>().enabled = false;
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
