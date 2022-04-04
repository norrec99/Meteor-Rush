using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
  [SerializeField] GameObject bigMeteor;
  [SerializeField] GameObject smallMeteor;

  float bigMeteorLastSpawnTime;
  float smallMeteorLastSpawnTime;

  // Update is called once per frame
  void Update()
  {
    SpawnBigMeteor();
    SpawnSmallMeteor();
  }

  void SpawnBigMeteor()
  {
    if (Time.time - bigMeteorLastSpawnTime >= Random.Range(3f, 5f))
    {
      Instantiate(bigMeteor, new Vector3(bigMeteor.transform.position.x + Random.Range(-2.5f, 2.5f), bigMeteor.transform.position.y + 5f, bigMeteor.transform.position.z), Quaternion.identity);
      bigMeteorLastSpawnTime = Time.time;
    }
  }
  void SpawnSmallMeteor()
  {
    if (Time.time - smallMeteorLastSpawnTime >= Random.Range(2f, 3f))
    {
      Instantiate(smallMeteor, new Vector3(smallMeteor.transform.position.x + Random.Range(-2.5f, 2.5f), smallMeteor.transform.position.y + 6f, smallMeteor.transform.position.z), Quaternion.identity);
      smallMeteorLastSpawnTime = Time.time;
    }
  }
}
