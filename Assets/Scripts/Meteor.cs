using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
  public float xForce = 0.7f;
  public float accelerator;

  DisplaySpeed displaySpeed;

  void Start()
  {
    displaySpeed = FindObjectOfType<DisplaySpeed>();
  }

  void FixedUpdate()
  {
    ProcessDownWard();
    Destroy(gameObject, 10f);
    displaySpeed.DisplaySpeedText(xForce, accelerator);
  }

  void ProcessDownWard()
  {
    accelerator = Time.timeSinceLevelLoad * 0.01f;

    if (accelerator >= 0.3f)
    {
      accelerator = 0.3f;
      transform.position += (Vector3.down * xForce * accelerator);
      Debug.Log("speed: " + accelerator * xForce);
    }
    else
    {
      transform.position += (Vector3.down * xForce * accelerator);
      Debug.Log("speed: " + accelerator * xForce);
    }
  }
}
