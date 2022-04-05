using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
  public float xForce;

  // Update is called once per frame
  void FixedUpdate()
  {
    ProcessDownWard();
    Destroy(gameObject, 5f);
  }

  void ProcessDownWard()
  {
    xForce = Random.Range(0.05f, 0.3f);
    transform.position += (Vector3.down * xForce);
  }
}
