using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MultiplierText : MonoBehaviour
{
  TMP_Text multiplierText;

  //   float multiplier;
  // Start is called before the first frame update
  void Start()
  {
    multiplierText = GetComponent<TMP_Text>();
    multiplierText.text = "x ";
  }

  public void DisplayMultiplier(float multiplier)
  {
    int factor = Mathf.RoundToInt(multiplier);
    multiplierText.text = "x " + factor.ToString();
  }
}
