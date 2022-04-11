using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySpeed : MonoBehaviour
{

  Text speedText;

  float speed;
  // Start is called before the first frame update
  void Start()
  {
    speedText = GetComponent<Text>();
    speedText.text = "Speed: " + speed;
  }

  public void DisplaySpeedText(float force, float accelerator)
  {
    speed = force * accelerator * 100;
    int totalSpeed = Mathf.RoundToInt(speed);
    speedText.text = "Speed: " + totalSpeed.ToString();
  }
}
