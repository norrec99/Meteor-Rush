using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  public float moveSpeed = 0.2f;

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
        transform.Translate(moveSpeed, 0, 0);
      }
      else if (mousePos.x < -1)
      {
        //move left
        transform.Translate(-moveSpeed, 0, 0);
      }
    }
  }
}
