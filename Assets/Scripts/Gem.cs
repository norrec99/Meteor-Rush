using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
  public float xForce = 0.5f;
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

    if (accelerator >= 0.2f)
    {
      accelerator = 0.2f;
      transform.position += (Vector3.down * xForce * accelerator);
    }
    else
    {
      transform.position += (Vector3.down * xForce * accelerator);
    }
  }
}
