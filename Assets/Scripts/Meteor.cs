using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
  float xForce = 0.7f;
  float accelerator;

  void FixedUpdate()
  {
    ProcessDownWard();
    Destroy(gameObject, 10f);
  }

  void ProcessDownWard()
  {
    accelerator = Time.timeSinceLevelLoad * 0.01f;

    if (accelerator >= 0.3f)
    {
      accelerator = 0.3f;
      transform.position += (Vector3.down * xForce * accelerator);
    }
    else
    {
      transform.position += (Vector3.down * xForce * accelerator);
    }
  }
}
