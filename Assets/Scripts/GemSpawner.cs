using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
  [SerializeField] GameObject emeraldGem;
  [SerializeField] GameObject pinkGem;

  float emeraldGemLastSpawnTime;
  float pinkGemLastSpawnTime;

  // Update is called once per frame
  void Update()
  {
    SpawnEmeraldGem();
    SpawnPinkGem();
  }

  void SpawnEmeraldGem()
  {
    if (Time.timeSinceLevelLoad - emeraldGemLastSpawnTime >= Random.Range(10f, 20f))
    {
      Instantiate(emeraldGem, new Vector3(emeraldGem.transform.position.x + Random.Range(-2.5f, 2.5f), emeraldGem.transform.position.y + 5f, emeraldGem.transform.position.z), Quaternion.identity);
      emeraldGemLastSpawnTime = Time.timeSinceLevelLoad;
    }
  }
  void SpawnPinkGem()
  {
    if (Time.timeSinceLevelLoad - pinkGemLastSpawnTime >= Random.Range(15f, 25f))
    {
      Instantiate(pinkGem, new Vector3(pinkGem.transform.position.x + Random.Range(-2.5f, 2.5f), pinkGem.transform.position.y + 5f, pinkGem.transform.position.z), Quaternion.identity);
      pinkGemLastSpawnTime = Time.timeSinceLevelLoad;
    }
  }
}
