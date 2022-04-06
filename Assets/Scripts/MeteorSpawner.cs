using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
  [SerializeField] GameObject hugeMeteor;
  [SerializeField] GameObject bigMeteor;
  [SerializeField] GameObject medMeteor;
  [SerializeField] GameObject smallMeteor;

  float hugeMeteorLastSpawnTime;
  float bigMeteorLastSpawnTime;
  float medMeteorLastSpawnTime;
  float smallMeteorLastSpawnTime;

  // Update is called once per frame
  void Update()
  {
    SpawnHugeMeteor();
    SpawnBigMeteor();
    SpawnMedMeteor();
    SpawnSmallMeteor();
  }

  void SpawnHugeMeteor()
  {
    if (Time.timeSinceLevelLoad - hugeMeteorLastSpawnTime >= Random.Range(8f, 15f))
    {
      Instantiate(hugeMeteor, new Vector3(hugeMeteor.transform.position.x + Random.Range(-2.5f, 2.5f), hugeMeteor.transform.position.y + 5f, hugeMeteor.transform.position.z), Quaternion.identity);
      hugeMeteorLastSpawnTime = Time.timeSinceLevelLoad;
    }
  }
  void SpawnBigMeteor()
  {
    if (Time.timeSinceLevelLoad - bigMeteorLastSpawnTime >= Random.Range(5f, 10f))
    {
      Instantiate(bigMeteor, new Vector3(bigMeteor.transform.position.x + Random.Range(-2.5f, 2.5f), bigMeteor.transform.position.y + 5f, bigMeteor.transform.position.z), Quaternion.identity);
      bigMeteorLastSpawnTime = Time.timeSinceLevelLoad;
    }
  }
  void SpawnMedMeteor()
  {
    if (Time.timeSinceLevelLoad - medMeteorLastSpawnTime >= Random.Range(2f, 6f))
    {
      Instantiate(medMeteor, new Vector3(medMeteor.transform.position.x + Random.Range(-2.5f, 2.5f), medMeteor.transform.position.y + 5f, medMeteor.transform.position.z), Quaternion.identity);
      medMeteorLastSpawnTime = Time.timeSinceLevelLoad;
    }
  }
  void SpawnSmallMeteor()
  {
    if (Time.timeSinceLevelLoad - smallMeteorLastSpawnTime >= Random.Range(1f, 5f))
    {
      Instantiate(smallMeteor, new Vector3(smallMeteor.transform.position.x + Random.Range(-2.5f, 2.5f), smallMeteor.transform.position.y + 6f, smallMeteor.transform.position.z), Quaternion.identity);
      smallMeteorLastSpawnTime = Time.timeSinceLevelLoad;
    }
  }
}
