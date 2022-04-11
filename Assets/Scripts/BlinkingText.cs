using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour
{

  Text text;
  // Start is called before the first frame update
  void Start()
  {
    text = GetComponent<Text>();
    text.GetComponent<Text>().enabled = false;
  }

  IEnumerator Blink()
  {
    while (true)
    {
      switch (text.color.a.ToString())
      {
        case "0":
          text.color = new Color(text.color.r, text.color.g, text.color.b, 1);
          yield return new WaitForSeconds(0.5f);
          break;
        case "1":
          text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
          yield return new WaitForSeconds(0.5f);
          break;
      }
    }
  }

  public void StartBlinking()
  {
    text.GetComponent<Text>().enabled = true;
    StopCoroutine("Blink");
    StartCoroutine("Blink");
  }

  public void StopBlinking()
  {
    StopCoroutine("Blink");
  }

  // Update is called once per frame
  void Update()
  {

  }
}
