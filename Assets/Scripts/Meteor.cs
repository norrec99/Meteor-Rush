using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
  public float xForce;

  // Update is called once per frame
  void Update()
  {
    ProcessDownWard();
    Destroy(gameObject, 10f);
  }

  void ProcessDownWard()
  {
    xForce = Random.Range(1f, 5f);
    transform.position += (Vector3.down * xForce) * Time.deltaTime;
  }
}
