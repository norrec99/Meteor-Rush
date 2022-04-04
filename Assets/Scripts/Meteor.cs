using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
  public float xForce;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    ProcessDownWard();
    Destroy(gameObject, 10f);
  }

  void ProcessDownWard()
  {
    xForce = Random.Range(5f, 7f);
    transform.position += (Vector3.down * xForce) * Time.deltaTime;
  }
}
