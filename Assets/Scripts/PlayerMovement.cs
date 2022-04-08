using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  // [SerializeField] ParticleSystem explosionParticle;

  ScoreBoard scoreBoard;

  public float moveSpeed = 0.2f;

  void Start()
  {

  }

  void FixedUpdate()
  {
    TouchMove();
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
}
