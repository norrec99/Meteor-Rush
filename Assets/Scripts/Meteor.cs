using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
  [SerializeField] float xForce = 5f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    ProcessDownWard();
  }

  void ProcessDownWard()
  {
    transform.position += (Vector3.down * xForce) * Time.deltaTime;
  }
}
