using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Joystick joystick;

  public float speed = 800f;

  Rigidbody2D rb;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    ProcessMove();

  }

  void ProcessMove()
  {
    float x = joystick.Horizontal; //Equals the joystick handle's position from the center of the joystick on the horizontal axis

    Vector3 moveDirection = transform.right * x; //Direction of movement

    rb.velocity = moveDirection * speed * Time.deltaTime; //Velocity of movement
  }
}
