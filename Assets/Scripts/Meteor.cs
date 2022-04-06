using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
  public float xForce;
  float accelerator;

  void FixedUpdate()
  {
    ProcessDownWard();
    Destroy(gameObject, 10f);
  }

  void ProcessDownWard()
  {
    accelerator = Time.timeSinceLevelLoad * 0.01f;

    if (accelerator >= 0.3)
    {
      accelerator = 0.3f;
      xForce = Random.Range(0.5f, 1f);
      transform.position += (Vector3.down * xForce * accelerator);
    }
    else
    {
      xForce = Random.Range(1f, 1.5f);
      transform.position += (Vector3.down * xForce * accelerator);
    }
  }
}
