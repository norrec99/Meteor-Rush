using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    ReloadLevel();
  }

  void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.tag == "Player")
    {
      Debug.Log(other.gameObject);
      // Destroy(other.gameObject);
      Time.timeScale = 0f;
    }
  }

  void ReloadLevel()
  {
    if (Time.timeScale == 0f && Input.touchCount > 1)
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Time.timeScale = 1f;
    }
  }
}
